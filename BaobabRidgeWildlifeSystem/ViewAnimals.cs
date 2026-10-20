using System.ComponentModel;

namespace BaobabRidgeWildlifeSystem
{
    public partial class ViewAnimals : Form
    {
        public ViewAnimals()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            try
            {
                // Load records automatically when the form opens.
                LoadAnimals();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not open the animal records.");
            }
        }

        private void LoadButton_Click(object? sender, EventArgs e)
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
            loadButton.Enabled = false;
            statusLabel.Text = "Loading animal records...";

            try
            {
                var fileService = new AnimalFileService();
                List<AnimalRecord> animals = fileService.LoadAnimals();
                animalsGrid.DataSource = new BindingList<AnimalRecord>(animals);
                countLabel.Text = $"{animals.Count} animal record(s)";
                statusLabel.Text = $"Loaded successfully from {fileService.FilePath}";

                // Use readable column headings in the table.
                SetHeader("RecordId", "Animal ID");
                SetHeader("Name", "Animal Name");
                SetHeader("Species", "Species");
                SetHeader("Age", "Age (years)");
                SetHeader("RecoveryScore", "Recovery Score (0-100)");
                SetHeader("Status", "Status");
                SetHeader("HousingUnit", "Housing Unit");
            }
            catch (Exception ex)
            {
                animalsGrid.DataSource = null;
                countLabel.Text = "0 animal records";
                statusLabel.Text = "Unable to load animal records.";
                ExceptionHandler.Handle(ex, "Animal records could not be loaded.");
            }
            finally
            {
                loadButton.Enabled = true;
            }
        }

        private void SetHeader(string propertyName, string headerText)
        {
            try
            {
                if (animalsGrid.Columns.Contains(propertyName)) animalsGrid.Columns[propertyName].HeaderText = headerText;
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not set the column heading.");
            }
        }

        // opens the Add Animal form, then refreshes the grid when it closes
        private void AddButton_Click(object? sender, EventArgs e)
        {
            try
            {
                using (var addForm = new AddAnimal())
                {
                    addForm.ShowDialog(this);
                }

                LoadAnimals();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not open the Add Animal screen.");
            }
        }

        // opens the Update Animal form, then refreshes the grid when it closes
        private void UpdateButton_Click(object? sender, EventArgs e)
        {
            try
            {
                using (var updateForm = new UpdateAnimal())
                {
                    updateForm.ShowDialog(this);
                }

                LoadAnimals();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not open the Update Animal screen.");
            }
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            try
            {
                if (animalsGrid.CurrentRow == null)
                {
                    MessageBox.Show("Please select an animal to delete.");
                    return;
                }

                string recordId = animalsGrid.CurrentRow
                    .Cells["RecordId"].Value?.ToString() ?? "";

                DialogResult answer = MessageBox.Show(
                    $"Are you sure you want to delete animal {recordId}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (answer != DialogResult.Yes)
                    return;

                var fileService = new AnimalFileService();

                if (fileService.DeleteAnimal(recordId))
                {
                    MessageBox.Show("Animal deleted successfully!");
                    LoadAnimals();
                }
                else
                {
                    MessageBox.Show("Animal not found in the file.");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not delete the animal.");
            }
        }

        private void CloseButton_Click(object? sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "Could not close the window.");
            }
        }
    }
}