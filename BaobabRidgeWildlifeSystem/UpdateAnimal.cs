using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BaobabRidgeWildlifeSystem
{
    public partial class UpdateAnimal : Form
    {
        private Animal? selectedAnimal;
        private bool isEditMode = false;

        private List<Animal> animals = new List<Animal>();

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

            string filePath = Path.Combine(
                AppContext.BaseDirectory,
                "animals.txt");

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

                if (!int.TryParse(fields[3], out int age))
                    continue;

                if (!int.TryParse(fields[4], out int recoveryScore))
                    continue;

                Animal animal = new Animal
                {
                    ID = fields[0].Trim(),
                    Name = fields[1].Trim(),
                    Species = fields[2].Trim(),
                    Age = age,
                    RecoveryScore = recoveryScore,
                    Status = fields[5].Trim(),
                    HousingUnit = fields[6].Trim()
                };

                animals.Add(animal);
            }

            DGV1.DataSource = null;
            DGV1.DataSource = animals;
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

            Animal? animal =
                DGV1.CurrentRow.DataBoundItem as Animal;

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

            txtID.Text = animal.ID;
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
            txtRecoveryScore.Text =
                animal.RecoveryScore.ToString();
            txtStatus.Text = animal.Status;
            txtHousing.Text = animal.HousingUnit;
        }

        private void SaveChangesButton_Click(object? sender, EventArgs e)
        {
            if (!isEditMode || selectedAnimal == null)
            {
                MessageBox.Show(
                    "Please select an animal and click Update first.");

                return;
            }

            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSpecies.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtRecoveryScore.Text))
            {
                MessageBox.Show(
                    "Please complete all required fields.");

                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) ||
                age < 0)
            {
                MessageBox.Show(
                    "Age must be a whole number greater than or equal to 0.");

                return;
            }

            if (!int.TryParse(
                    txtRecoveryScore.Text,
                    out int recoveryScore) ||
                recoveryScore < 0 ||
                recoveryScore > 100)
            {
                MessageBox.Show(
                    "Recovery Score must be between 0 and 100.");

                return;
            }

            selectedAnimal.ID = txtID.Text.Trim();
            selectedAnimal.Name = txtName.Text.Trim();
            selectedAnimal.Species = txtSpecies.Text.Trim();
            selectedAnimal.Age = age;
            selectedAnimal.RecoveryScore = recoveryScore;

            selectedAnimal.CalculateClassification();

            txtStatus.Text = selectedAnimal.Status;
            txtHousing.Text = selectedAnimal.HousingUnit;

            DGV1.Refresh();

            SaveAnimalsToFile();

            MessageBox.Show(
                "Animal details updated successfully.",
                "Update Animal",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            isEditMode = false;
            selectedAnimal = null;
        }

        private void SaveAnimalsToFile()
        {
            string filePath = @"C:\Users\lgcoe\OneDrive\Documents\PRG272 Project OCT 2026\BaobabRidgeWildlifeSystem\BaobabRidgeWildlifeSystem\animals.txt";

            List<string> lines = new List<string>();

            foreach (Animal animal in animals)
            {
                lines.Add(
                    $"{animal.ID}|{animal.Name}|{animal.Species}|" +
                    $"{animal.Age}|{animal.RecoveryScore}|" +
                    $"{animal.Status}|{animal.HousingUnit}");
            }

            try
            {
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Could not save animal records:\n{ex.Message}",
                    "File Saving Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

            DGV1.ClearSelection();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}