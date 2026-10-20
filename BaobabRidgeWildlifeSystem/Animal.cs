namespace BaobabRidgeWildlifeSystem
{
    public class Animal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int RecoveryScore { get; set; }

        public Animal(string id, string name, string species, int age, int recoveryScore)
        {
            Id = id;
            Name = name;
            Species = species;
            Age = age;
            RecoveryScore = recoveryScore;
        }

        // boundaries live in AnimalClassifier
        public string GetStatus() 
        {
            return AnimalClassifier.Classify(RecoveryScore).Status; 
        }

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
