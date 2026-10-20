namespace BaobabRidgeWildlifeSystem
{
    // one line of animals.txt:
    // Id|Name|Species|Age|RecoveryScore|Status|HousingUnit
    public sealed class AnimalRecord
    {
        public string RecordId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; } = string.Empty;
        public string HousingUnit { get; set; } = string.Empty;
    }
}