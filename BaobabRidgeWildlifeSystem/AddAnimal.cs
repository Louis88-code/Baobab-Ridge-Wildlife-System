using System.Text.RegularExpressions;

namespace BaobabRidgeWildlifeSystem
{
    public partial class AddAnimal : Form
    {
        // where the animals get saved
        private string filePath = Path.Combine(Application.StartupPath, "animals.txt");

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

        private void lblAnimalId_Click(object sender, EventArgs e)
        {
            // designer
        }

        // add button
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
                // ========================================NB====================================================
                // member 2 grid refresh method
                // ========================================NB====================================================
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "The animal could not be added.");
            }
        }

        // checks all the boxes
        private bool CheckInputs(string id, string name, string species, string ageText, string scoreText)
        {
            // id should look like WR-1234
            if (!Regex.IsMatch(id, @"^WR-[0-9]{4}$"))
            {
                ShowError("Animal ID must be 'WR-' followed by 4 digits (e.g. WR-1001).", txtAnimalId);
                return false;
            }

            // id already used?
            if (IdExists(id))
            {
                ShowError($"Animal ID '{id}' already exists in the system.", txtAnimalId);
                return false;
            }

            // name
            if (name.Length < 1 || name.Length > 30 || name.Contains("|"))
            {
                ShowError("Name is required (1-30 characters) and cannot contain '|'.", txtName);
                return false;
            }

            // species
            if (species.Length < 1 || species.Length > 30 || species.Contains("|"))
            {
                ShowError("Species is required (1-30 characters) and cannot contain '|'.", txtSpecies);
                return false;
            }

            // age
            if (!int.TryParse(ageText, out int age) || age < 0 || age > 100)
            {
                ShowError("Age must be a whole number between 0 and 100.", txtAge);
                return false;
            }

            // recovery score
            if (!int.TryParse(scoreText, out int score) || score < 0 || score > 100)
            {
                ShowError("Recovery Score must be a whole number between 0 and 100.", txtRecoveryScore);
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

        // clear boxes
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