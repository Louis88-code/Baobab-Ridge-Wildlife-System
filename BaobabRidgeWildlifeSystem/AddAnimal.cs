namespace BaobabRidgeWildlifeSystem
{
    public partial class AddAnimal : Form
    {
        // where the animals get saved
        private string filePath = new AnimalFileService().FilePath;

        // sets up the form
        public AddAnimal()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "The Add Animal screen could not be created.");
            }
        }

        // add button: checks the boxes, then saves the animal to the file
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtAnimalId.Text.Trim().ToUpper();
                string name = txtName.Text.Trim();
                string species = txtSpecies.Text.Trim();
                string ageText = txtAge.Text.Trim();
                string scoreText = txtRecoveryScore.Text.Trim();

                txtAnimalId.Text = id;

                // check everything first
                if (!CheckInputs(id, name, species, ageText, scoreText))
                {
                    return;
                }

                int age = int.Parse(ageText);
                int score = int.Parse(scoreText);

                Animal animal = new Animal(id, name, species, age, score);
                string line = animal.ToFileString();

                // if the last line has no enter at the end, add one first
                string extra = NewLine() ? Environment.NewLine : "";
                File.AppendAllText(filePath, extra + line + Environment.NewLine);

                MessageBox.Show($"Animal {animal.Id} added successfully!\n\n" + $"Status: {animal.GetStatus()}\n" + $"Housing Unit: {animal.GetHousingUnit()}", "Animal Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearBoxes();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "The animal could not be added.");
            }
        }

        // checks all the boxes (the rules are in AnimalValidator)
        private bool CheckInputs(string id, string name, string species, string ageText, string scoreText)
        {
            // id should look like WR-1234
            string error = AnimalValidator.CheckId(id);
            if (error != "")
            {
                ShowError(error, txtAnimalId);
                return false;
            }

            // id already used?
            if (IdExists(id))
            {
                ShowError($"Animal ID '{id}' already exists in the system.", txtAnimalId);
                return false;
            }

            // name
            error = AnimalValidator.CheckName(name);
            if (error != "")
            {
                ShowError(error, txtName);
                return false;
            }

            // species
            error = AnimalValidator.CheckSpecies(species);
            if (error != "")
            {
                ShowError(error, txtSpecies);
                return false;
            }

            // age
            error = AnimalValidator.CheckAge(ageText);
            if (error != "")
            {
                ShowError(error, txtAge);
                return false;
            }

            // recovery score
            error = AnimalValidator.CheckScore(scoreText);
            if (error != "")
            {
                ShowError(error, txtRecoveryScore);
                return false;
            }

            return true;
        }

        // true if the file has stuff in it but doesn't end with an enter
        private bool NewLine()
        {
            if (!File.Exists(filePath)) return false;

            string text = File.ReadAllText(filePath);
            if (text.Length == 0) return false;

            return !text.EndsWith('\n') && !text.EndsWith('\r');
        }

        // looks through the file for the same id
        private bool IdExists(string id)
        {
            if (!File.Exists(filePath)) return false;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split('|');
                if (parts[0].Trim().Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        // pop up the error and go back to the box
        private void ShowError(string message, TextBox box)
        {
            try
            {
                MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box.Focus();
                box.SelectAll();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not show the validation message.");
            }
        }

        // clears the boxes
        private void ClearBoxes()
        {
            try
            {
                txtAnimalId.Clear();
                txtName.Clear();
                txtSpecies.Clear();
                txtAge.Clear();
                txtRecoveryScore.Clear();
                txtAnimalId.Focus();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not clear the input boxes.");
            }
        }
    }
}