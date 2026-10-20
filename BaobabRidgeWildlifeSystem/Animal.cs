namespace BaobabRidgeWildlifeSystem
{
    public class Animal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int RecoveryScore { get; set; }

        // read-only, worked out from the recovery score (shows as grid columns)
        public string Status { get { return AnimalClassifier.Classify(RecoveryScore).Status; } }
        public string HousingUnit { get { return AnimalClassifier.Classify(RecoveryScore).HousingUnit; } }

        // makes a new animal
        public Animal(string id, string name, string species, int age, int recoveryScore)
        {
            Id = id;
            Name = name;
            Species = species;
            Age = age;
            RecoveryScore = recoveryScore;
        }

        // gets the status (boundaries live in AnimalClassifier)
        public string GetStatus()
        {
            return AnimalClassifier.Classify(RecoveryScore).Status;
        }

        // gets the housing unit for the recovery score
        public string GetHousingUnit()
        {
            return AnimalClassifier.Classify(RecoveryScore).HousingUnit;
        }

        // format data for text file
        public string ToFileString()
        {
            var (status, housingUnit) = AnimalClassifier.Classify(RecoveryScore);
            return $"{Id}|{Name}|{Species}|{Age}|{RecoveryScore}|{status}|{housingUnit}";
        }
    }
}