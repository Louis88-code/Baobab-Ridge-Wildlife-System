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
            // Load records automatically when the form opens.
            LoadAnimals();
        }

        private void LoadButton_Click(object? sender, EventArgs e) => LoadAnimals();

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
            catch (Exception ex) when (
                ex is IOException ||
                ex is UnauthorizedAccessException ||
                ex is ArgumentException ||
                ex is InvalidDataException)
            {
                animalsGrid.DataSource = null;
                countLabel.Text = "0 animal records";
                statusLabel.Text = "Unable to load animal records.";
                MessageBox.Show(ex.Message, "Animal File Loading Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadButton.Enabled = true;
            }
        }

        private void SetHeader(string propertyName, string headerText)
        {
            if (animalsGrid.Columns.Contains(propertyName)) animalsGrid.Columns[propertyName].HeaderText = headerText;
        }

        // opens the Add Animal form, then refreshes the grid when it closes
        private void AddButton_Click(object? sender, EventArgs e)
        {
            using (var addForm = new AddAnimal())
            {
                addForm.ShowDialog(this);
            }

            LoadAnimals();
        }

        // opens the Update Animal form, then refreshes the grid when it closes
        private void UpdateButton_Click(object? sender, EventArgs e)
        {
            using (var updateForm = new UpdateAnimal())
            {
                updateForm.ShowDialog(this);
            }

            LoadAnimals();
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
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

            try
            {
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
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show($"Could not delete animal: {ex.Message}");
            }
        }

        private void CloseButton_Click(object? sender, EventArgs e) => Close();
    }
}