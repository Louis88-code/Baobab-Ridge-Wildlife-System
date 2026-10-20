namespace BaobabRidgeWildlifeSystem
{
    public partial class UpdateAnimal : Form
    {
        private Animal? selectedAnimal;
        private bool isEditMode = false;

        private readonly List<Animal> animals = new List<Animal>();
        private readonly AnimalFileService fileService = new AnimalFileService();

        // sets up the form
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

        // loads the records when the form opens
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

        // reads the animals from the file into the list
        private void LoadAnimals()
        {
            try
            {
                animals.Clear();
                animals.AddRange(fileService.LoadAnimals());

                RefreshGrid();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Animal records could not be loaded.");
            }
        }

        // shows the list in the grid again
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

        // changes the heading text of one column
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

        // puts an animal in the boxes and switches to edit mode
        private void LoadRecordIntoForm(Animal animal)
        {
            selectedAnimal = animal;
            isEditMode = true;

            btnSaveChanges.Enabled = true;

            // the id can't be changed while editing
            txtID.ReadOnly = true;
            txtID.BackColor = Color.FromArgb(238, 242, 236);

            txtID.Text = animal.Id;
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
            txtRecoveryScore.Text = animal.RecoveryScore.ToString();
            txtStatus.Text = animal.GetStatus();
            txtHousing.Text = animal.GetHousingUnit();
        }

        // update button: loads the selected row into the boxes
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

                LoadRecordIntoForm(animal);
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not load the selected animal for editing.");
            }
        }

        // clicking a row in the grid also loads it into the boxes
        private void DGV1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // -1 means the header was clicked
                if (e.RowIndex < 0)
                    return;

                Animal? animal = DGV1.Rows[e.RowIndex].DataBoundItem as Animal;

                if (animal != null)
                {
                    LoadRecordIntoForm(animal);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not load the selected animal for editing.");
            }
        }

        // search button: finds an animal by its exact id (not case sensitive)
        private void SearchButton_Click(object? sender, EventArgs e)
        {
            try
            {
                string searchId = txtSearch.Text.Trim();

                if (searchId == "")
                {
                    MessageBox.Show("Please type an Animal ID to search for.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Focus();
                    return;
                }

                Animal? found = null;

                foreach (Animal animal in animals)
                {
                    if (animal.Id.Equals(searchId, StringComparison.OrdinalIgnoreCase))
                    {
                        found = animal;
                        break;
                    }
                }

                if (found == null)
                {
                    MessageBox.Show($"Animal ID '{searchId}' was not found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Focus();
                    txtSearch.SelectAll();
                    return;
                }

                // highlight the animal in the grid
                foreach (DataGridViewRow row in DGV1.Rows)
                {
                    if (ReferenceEquals(row.DataBoundItem, found))
                    {
                        row.Selected = true;
                        DGV1.CurrentCell = row.Cells[0];
                        break;
                    }
                }

                LoadRecordIntoForm(found);
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "The search could not be completed.");
            }
        }

        // pop up the error and go back to the box
        private void ShowError(string message, TextBox box)
        {
            MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            box.Focus();
            box.SelectAll();
        }

        // save changes button: checks the boxes (same rules as Add), then saves
        private void SaveChangesButton_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!isEditMode || selectedAnimal == null)
                {
                    MessageBox.Show("Please select an animal and click Update first.");
                    return;
                }

                string name = txtName.Text.Trim();
                string species = txtSpecies.Text.Trim();
                string ageText = txtAge.Text.Trim();
                string scoreText = txtRecoveryScore.Text.Trim();

                // the id is read-only so it can't change and can't clash with another animal
                string error = AnimalValidator.CheckName(name);
                if (error != "")
                {
                    ShowError(error, txtName);
                    return;
                }

                error = AnimalValidator.CheckSpecies(species);
                if (error != "")
                {
                    ShowError(error, txtSpecies);
                    return;
                }

                error = AnimalValidator.CheckAge(ageText);
                if (error != "")
                {
                    ShowError(error, txtAge);
                    return;
                }

                error = AnimalValidator.CheckScore(scoreText);
                if (error != "")
                {
                    ShowError(error, txtRecoveryScore);
                    return;
                }

                selectedAnimal.Name = name;
                selectedAnimal.Species = species;
                selectedAnimal.Age = int.Parse(ageText);
                selectedAnimal.RecoveryScore = int.Parse(scoreText);

                // status and housing follow the new recovery score
                if (fileService.UpdateAnimal(selectedAnimal))
                {
                    RefreshGrid();

                    MessageBox.Show(
                        "Animal details updated successfully.",
                        "Update Animal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Animal not found in the file.");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "The changes could not be saved.");
            }
        }

        // empties the boxes and leaves edit mode
        private void ClearForm()
        {
            txtSearch.Clear();
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

            // the id box can be typed in again
            txtID.ReadOnly = false;
            txtID.BackColor = SystemColors.Window;

            DGV1.ClearSelection();
        }

        // clear button
        private void ClearButton_Click(object? sender, EventArgs e)
        {
            try
            {
                ClearForm();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not clear the form.");
            }
        }
    }
}
