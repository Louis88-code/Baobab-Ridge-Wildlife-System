using System.Globalization;
using System.Text.RegularExpressions;

namespace BaobabRidgeWildlifeSystem
{
    public sealed class AnimalFileService
    {
        private const int ExpectedFieldCount = 7;
        private readonly string _filePath;

        // finds the file when the service is made
        public AnimalFileService(string fileName = "animals.txt")
        {
            _filePath = FindFile(fileName);
        }

        // where the file is
        public string FilePath => _filePath;

        // how many bad lines were skipped the last time LoadAnimals ran
        public int SkippedLines { get; private set; }

        // reads animals.txt, bad lines are skipped and counted instead of crashing
        public List<Animal> LoadAnimals()
        {
            SkippedLines = 0;
            List<Animal> animals = new List<Animal>();

            // no file yet, so make an empty one
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "");
                return animals;
            }

            string[] lines = File.ReadAllLines(_filePath);

            foreach (string rawLine in lines)
            {
                string line = rawLine.Trim();

                // blank lines are not counted as bad lines
                if (line == "")
                    continue;

                Animal? animal = ParseLine(line);

                if (animal == null)
                    SkippedLines++;
                else
                    animals.Add(animal);
            }

            return animals;
        }

        // turns one line of the file into an Animal, gives back null if the line is bad
        private static Animal? ParseLine(string line)
        {
            string[] fields = line.Split('|');

            if (fields.Length != ExpectedFieldCount)
                return null;

            for (int i = 0; i < fields.Length; i++)
                fields[i] = fields[i].Trim();

            if (fields.Any(string.IsNullOrWhiteSpace))
                return null;

            // id should look like WR-1234
            if (!Regex.IsMatch(fields[0], @"^WR-[0-9]{4}$"))
                return null;

            if (!int.TryParse(fields[3], NumberStyles.Integer, CultureInfo.InvariantCulture, out int age) || age < 0 || age > 100)
                return null;

            if (!int.TryParse(fields[4], NumberStyles.Integer, CultureInfo.InvariantCulture, out int recoveryScore) || recoveryScore < 0 || recoveryScore > 100)
                return null;

            // status and housing are worked out from the score by the Animal class
            return new Animal(fields[0], fields[1], fields[2], age, recoveryScore);
        }

        // replaces the line with the same id by the new details of the animal
        public bool UpdateAnimal(Animal animal)
        {
            if (!File.Exists(_filePath))
                return false;

            string[] lines = File.ReadAllLines(_filePath);
            bool animalUpdated = false;

            for (int i = 0; i < lines.Length; i++)
            {
                int separatorPosition = lines[i].IndexOf('|');

                if (separatorPosition < 0)
                    continue;

                string currentId = lines[i].Substring(0, separatorPosition).Trim();

                if (currentId.Equals(animal.Id, StringComparison.OrdinalIgnoreCase))
                {
                    lines[i] = animal.ToFileString();
                    animalUpdated = true;
                    break;
                }
            }

            if (animalUpdated)
                File.WriteAllLines(_filePath, lines);

            return animalUpdated;
        }

        // deletes the line with this id from the file
        public bool DeleteAnimal(string recordId)
        {
            if (string.IsNullOrWhiteSpace(recordId) || !File.Exists(_filePath))
                return false;

            string[] lines = File.ReadAllLines(_filePath);
            List<string> remainingLines = new List<string>();
            bool animalDeleted = false;

            foreach (string line in lines)
            {
                int separatorPosition = line.IndexOf('|');

                if (separatorPosition >= 0 && !animalDeleted)
                {
                    string currentId = line.Substring(0, separatorPosition);

                    if (currentId.Trim().Equals(recordId, StringComparison.OrdinalIgnoreCase))
                    {
                        animalDeleted = true;
                        continue;
                    }
                }

                remainingLines.Add(line);
            }

            if (animalDeleted)
                File.WriteAllLines(_filePath, remainingLines);

            return animalDeleted;
        }

        // looks for the file in the exe folder and the folders above it
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