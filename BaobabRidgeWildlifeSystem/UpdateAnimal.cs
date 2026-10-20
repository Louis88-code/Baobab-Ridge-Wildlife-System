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
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "The Update Animal screen could not be created.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAnimals();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not load the animal records.");
            }
        }

        private void LoadAnimals()
        {
            try
            {
                animals.Clear();

                string filePath = fileService.FilePath;

                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException(
                        $"Could not find animals.txt at:\n{filePath}", filePath);
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
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Animal records could not be loaded.");
            }
        }

        private void RefreshGrid()
        {
            try
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
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "The animal list could not be displayed.");
            }
        }

        private void SetHeader(string propertyName, string headerText)
        {
            try
            {
                if (DGV1.Columns.Contains(propertyName)) DGV1.Columns[propertyName].HeaderText = headerText;
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not set the column heading.");
            }
        }

        private void UpdateButton_Click(object? sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not load the selected animal for editing.");
            }
        }

        private void SaveChangesButton_Click(object? sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "The changes could not be saved.");
            }
        }

        private bool SaveAnimalsToFile()
        {
            try
            {
                List<string> lines = new List<string>();

                foreach (Animal animal in animals)
                {
                    lines.Add(animal.ToFileString());
                }

                File.WriteAllLines(fileService.FilePath, lines);
                return true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not save the animal records.");
                return false;
            }
        }

        private void ClearButton_Click(object? sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not clear the form.");
            }
        }

        private void dataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
        }
    }
}