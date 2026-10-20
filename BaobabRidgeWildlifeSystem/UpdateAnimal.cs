namespace BaobabRidgeWildlifeSystem
{
    public partial class UpdateAnimal : Form
    {
        private Animal? selectedAnimal;
        private bool isEditMode = false;

        private readonly List<Animal> animals = new List<Animal>();
        private readonly AnimalFileService fileService = new AnimalFileService();

        public UpdateAnimal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAnimals();
        }

        private void LoadAnimals()
        {
            animals.Clear();

            string filePath = fileService.FilePath;

            if (!File.Exists(filePath))
            {
                MessageBox.Show(
                    $"Could not find animals.txt at:\n{filePath}",
                    "Animal File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            foreach (string line in File.ReadAllLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] fields = line.Split('|');

                if (fields.Length != 7)
                    continue;

                if (!int.TryParse(fields[3].Trim(), out int age) || age < 0)
                    continue;

                if (!int.TryParse(fields[4].Trim(), out int recoveryScore) ||
                    recoveryScore < 0 || recoveryScore > 100)
                    continue;

                // status and housing are worked out from the score by the Animal class
                animals.Add(new Animal(
                    fields[0].Trim(),
                    fields[1].Trim(),
                    fields[2].Trim(),
                    age,
                    recoveryScore));
            }

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            DGV1.DataSource = null;
            DGV1.DataSource = animals;

            SetHeader("Id", "Animal ID");
            SetHeader("Name", "Name");
            SetHeader("Species", "Species");
            SetHeader("Age", "Age");
            SetHeader("RecoveryScore", "Recovery Score");
            SetHeader("Status", "Status");
            SetHeader("HousingUnit", "Housing Unit");
        }

        private void SetHeader(string propertyName, string headerText)
        {
            if (DGV1.Columns.Contains(propertyName)) DGV1.Columns[propertyName].HeaderText = headerText;
        }

        private void UpdateButton_Click(object? sender, EventArgs e)
        {
            if (DGV1.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select an animal first.",
                    "Update Animal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            Animal? animal = DGV1.CurrentRow.DataBoundItem as Animal;

            if (animal == null)
            {
                MessageBox.Show(
                    "Unable to read the selected animal.",
                    "Update Animal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            selectedAnimal = animal;
            isEditMode = true;

            btnSaveChanges.Enabled = true;

            txtID.Text = animal.Id;
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
            txtRecoveryScore.Text = animal.RecoveryScore.ToString();
            txtStatus.Text = animal.GetStatus();
            txtHousing.Text = animal.GetHousingUnit();
        }

        private void SaveChangesButton_Click(object? sender, EventArgs e)
        {
            if (!isEditMode || selectedAnimal == null)
            {
                MessageBox.Show("Please select an animal and click Update first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSpecies.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtRecoveryScore.Text))
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

            string newId = txtID.Text.Trim();
            string newName = txtName.Text.Trim();
            string newSpecies = txtSpecies.Text.Trim();

            // '|' is the file separator, so it can't be part of the data
            if (newId.Contains('|') || newName.Contains('|') || newSpecies.Contains('|'))
            {
                MessageBox.Show("Fields cannot contain the '|' character.");
                return;
            }

            // don't allow two animals with the same ID
            bool duplicateId = animals.Any(a =>
                !ReferenceEquals(a, selectedAnimal) &&
                a.Id.Equals(newId, StringComparison.OrdinalIgnoreCase));

            if (duplicateId)
            {
                MessageBox.Show($"Animal ID '{newId}' already exists in the system.");
                return;
            }

            if (!int.TryParse(txtAge.Text.Trim(), out int age) || age < 0)
            {
                MessageBox.Show("Age must be a whole number greater than or equal to 0.");
                return;
            }

            if (!int.TryParse(txtRecoveryScore.Text.Trim(), out int recoveryScore) ||
                recoveryScore < 0 || recoveryScore > 100)
            {
                MessageBox.Show("Recovery Score must be between 0 and 100.");
                return;
            }

            selectedAnimal.Id = newId;
            selectedAnimal.Name = newName;
            selectedAnimal.Species = newSpecies;
            selectedAnimal.Age = age;
            selectedAnimal.RecoveryScore = recoveryScore;

            // status and housing follow the new recovery score
            txtStatus.Text = selectedAnimal.GetStatus();
            txtHousing.Text = selectedAnimal.GetHousingUnit();

            if (SaveAnimalsToFile())
            {
                RefreshGrid();

                MessageBox.Show(
                    "Animal details updated successfully.",
                    "Update Animal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                isEditMode = false;
                selectedAnimal = null;
                btnSaveChanges.Enabled = false;
            }
        }

        private bool SaveAnimalsToFile()
        {
            List<string> lines = new List<string>();

            foreach (Animal animal in animals)
            {
                lines.Add(animal.ToFileString());
            }

            try
            {
                File.WriteAllLines(fileService.FilePath, lines);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Could not save animal records:\n{ex.Message}",
                    "File Saving Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        private void ClearButton_Click(object? sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtRecoveryScore.Clear();
            txtStatus.Clear();
            txtHousing.Clear();

            selectedAnimal = null;
            isEditMode = false;
            btnSaveChanges.Enabled = false;

            DGV1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
        }
    }
}