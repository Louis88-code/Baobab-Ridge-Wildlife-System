using System.Globalization;
using BaobabRidgeWildlifeSystem.Models;

namespace BaobabRidgeWildlifeSystem.Services
{
    public sealed class AnimalFileService
    {
        private const int ExpectedFieldCount = 7;
        private readonly string _filePath;

        public AnimalFileService(string fileName = "animals.txt")
        {
            _filePath = FindFile(fileName);
        }

        public string FilePath => _filePath;

        public List<AnimalRecord> LoadAnimals()
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException(
                    $"Could not find '{Path.GetFileName(_filePath)}'. Place it in the solution folder or next to the application executable.",
                    _filePath);
            }

            var animals = new List<AnimalRecord>();
            var errors = new List<string>();
            string[] lines = File.ReadAllLines(_filePath);

            for (int index = 0; index < lines.Length; index++)
            {
                string line = lines[index].Trim();

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] fields = line.Split('|');

                if (fields.Length != ExpectedFieldCount)
                {
                    errors.Add($"Line {index + 1}: expected 7 fields separated by '|'.");
                    continue;
                }

                for (int i = 0; i < fields.Length; i++)
                    fields[i] = fields[i].Trim();

                if (fields.Any(string.IsNullOrWhiteSpace))
                {
                    errors.Add($"Line {index + 1}: one or more fields are empty.");
                    continue;
                }

                if (!int.TryParse(fields[3], NumberStyles.Integer, CultureInfo.InvariantCulture, out int age) || age < 0)
                {
                    errors.Add($"Line {index + 1}: Age must be a whole number greater than or equal to 0.");
                    continue;
                }

                if (!decimal.TryParse(fields[4], NumberStyles.Number, CultureInfo.InvariantCulture, out decimal weight) || weight < 0)
                {
                    errors.Add($"Line {index + 1}: Weight must be a number greater than or equal to 0.");
                    continue;
                }

                animals.Add(new AnimalRecord
                {
                    RecordId = fields[0],
                    Name = fields[1],
                    Species = fields[2],
                    Age = age,
                    Weight = weight,
                    HealthStatus = fields[5],
                    Location = fields[6]
                });
            }

            if (animals.Count == 0 && errors.Count == 0)
                throw new InvalidDataException("The animals.txt file is empty or contains no animal records.");

            if (errors.Count > 0)
            {
                throw new InvalidDataException(
                    "Some records in animals.txt could not be loaded:\n\n" +
                    string.Join("\n", errors) +
                    $"\n\nValid records found: {animals.Count}. Correct the listed lines and try again.");
            }

            return animals;
        }

        private static string FindFile(string fileName)
        {
            string[] startingFolders =
            {
                AppContext.BaseDirectory,
                Directory.GetCurrentDirectory()
            };

            foreach (string startFolder in startingFolders)
            {
                DirectoryInfo? folder = new DirectoryInfo(startFolder);

                while (folder is not null)
                {
                    string candidate = Path.Combine(folder.FullName, fileName);
                    if (File.Exists(candidate))
                        return candidate;

                    folder = folder.Parent;
                }
            }

            return Path.Combine(Directory.GetCurrentDirectory(), fileName);
        }
    }
}
