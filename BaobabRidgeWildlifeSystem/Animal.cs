namespace BaobabRidgeWildlifeSystem
{
    
    /// Represents an animal record in the Baobab Ridge Wildlife Rehabilitation Centre.
    
    public class Animal
    {
        public string ID { get; set; } = "";
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; } = "";
        public string HousingUnit { get; set; } = "";

        
        /// Calculates the animal's status and housing unit from its recovery score.
       
        public void CalculateClassification()
        {
            if (RecoveryScore <= 19)
            {
                Status = "Critical";
                HousingUnit = "Intensive Care Unit";
            }
            else if (RecoveryScore <= 39)
            {
                Status = "Serious";
                HousingUnit = "High-Dependency Ward";
            }
            else if (RecoveryScore <= 59)
            {
                Status = "Stable";
                HousingUnit = "Recovery Ward";
            }
            else if (RecoveryScore <= 79)
            {
                Status = "Recovering";
                HousingUnit = "Outdoor Enclosure";
            }
            else
            {
                Status = "Release-Ready";
                HousingUnit = "Pre-Release Camp";
            }
        }
    }
}
