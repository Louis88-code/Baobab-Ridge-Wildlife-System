namespace BaobabRidgeWildlifeSystem.Models
{
    public sealed class AnimalRecord
    {
        public string RecordId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public string HealthStatus { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }
}
