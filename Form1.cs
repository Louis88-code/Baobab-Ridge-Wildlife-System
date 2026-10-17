using System.ComponentModel;
using BaobabRidgeWildlifeSystem.Models;
using BaobabRidgeWildlifeSystem.Services;

namespace BaobabRidgeWildlifeSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StyleAnimalGrid();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            // Load records automatically when the form opens.
            LoadAnimals();
        }

        private void StyleAnimalGrid()
        {
            animalsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 78, 59);
            animalsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            animalsGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            animalsGrid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            animalsGrid.DefaultCellStyle.ForeColor = Color.FromArgb(42, 52, 44);
            animalsGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 233, 218);
            animalsGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(35, 55, 39);
            animalsGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 247);
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
                SetHeader("RecordId", "Record ID");
                SetHeader("Name", "Animal Name");
                SetHeader("Species", "Species");
                SetHeader("Age", "Age (years)");
                SetHeader("Weight", "Weight (kg)");
                SetHeader("HealthStatus", "Health Status");
                SetHeader("Location", "Current Location");
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
            if (animalsGrid.Columns.Contains(propertyName))
                animalsGrid.Columns[propertyName].HeaderText = headerText;
        }

        // These buttons are present in the form for a consistent workflow.
        // Add, Update and Delete are separate project options and are not implemented here.
        private void AddButton_Click(object? sender, EventArgs e)
        {
            ShowFeatureNotice("Add Animal", "Animal creation belongs to Option 1 and is not connected in this Option 2 build.");
        }

        private void UpdateButton_Click(object? sender, EventArgs e)
        {
            ShowFeatureNotice("Update Animal", "Animal updates are handled by the Update Animal feature, not Option 2.");
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            ShowFeatureNotice("Delete Animal", "Animal deletion is handled by the Delete Animal feature, not Option 2.");
        }

        private static void ShowFeatureNotice(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CloseButton_Click(object? sender, EventArgs e) => Close();

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
