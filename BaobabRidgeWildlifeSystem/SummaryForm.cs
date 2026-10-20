using System.Globalization;
using System.Text;

namespace BaobabRidgeWildlifeSystem
{
    public partial class SummaryForm : Form
    {
        // sets up the form
        public SummaryForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "The Summary Report screen could not be created.");
            }
        }

        // generate button: builds the report, shows it and saves it to summary.txt
        private void GenerateButton_Click(object? sender, EventArgs e)
        {
            try
            {
                AnimalFileService fileService = new AnimalFileService();
                List<Animal> animals = fileService.LoadAnimals();

                string report = BuildReport(animals);

                // summary.txt goes in the same folder as animals.txt (overwritten each time)
                string folder = Path.GetDirectoryName(fileService.FilePath) ?? AppContext.BaseDirectory;
                string summaryPath = Path.Combine(folder, "summary.txt");
                File.WriteAllText(summaryPath, report, new UTF8Encoding(false));

                txtSummary.Text = report;
                lblStatus.Text = "Report saved to " + summaryPath;
            }
            catch (Exception ex)
            {
                ExceptionHandler.Handle(ex, "The summary report could not be created.");
            }
        }

        // works out the totals and averages and puts the report text together
        private string BuildReport(List<Animal> animals)
        {
            int total = animals.Count;

            // averages are N/A when there are no animals
            string ageText = "N/A";
            string scoreText = "N/A";

            if (total > 0)
            {
                ageText = animals.Average(a => a.Age).ToString("F2", CultureInfo.InvariantCulture);
                scoreText = animals.Average(a => a.RecoveryScore).ToString("F2", CultureInfo.InvariantCulture);
            }

            string[] statuses =
            {
                AnimalClassifier.StatusCritical,
                AnimalClassifier.StatusSerious,
                AnimalClassifier.StatusStable,
                AnimalClassifier.StatusRecovering,
                AnimalClassifier.StatusReleaseReady
            };

            StringBuilder report = new StringBuilder();
            report.AppendLine("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
            report.AppendLine("ANIMAL SUMMARY REPORT");
            report.AppendLine("Generated: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
            report.AppendLine("----------------------------------------");
            report.AppendLine($"Total animals:            {total}");
            report.AppendLine($"Average age (years):      {ageText}");
            report.AppendLine($"Average recovery score:   {scoreText}");
            report.AppendLine("----------------------------------------");
            report.AppendLine("Animals per status:");

            // every status is listed, even when the count is 0
            foreach (string status in statuses)
            {
                int count = animals.Count(a => a.Status == status);
                string label = "  " + status + ":";
                report.AppendLine(label.PadRight(26) + count);
            }

            return report.ToString();
        }

        // close button
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
