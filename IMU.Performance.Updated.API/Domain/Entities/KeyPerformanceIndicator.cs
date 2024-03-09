namespace IMU.Performance.Updated.API.Domain.Entities
{
    public class KeyPerformanceIndicator : BaseEntity
    {
        public string Description { get; private set; } = null!;

        public int Weighting { get; set; }

        public int? MidtermScore { get; private set; }

        public int? MidtermWeightedScore { get; private set; }
        public int? FinalScore { get; private set; }

        public int? FinalWeightedScore { get; private set; }

        public long KeyPerformanceAreaId { get; private set; }

        public KeyPerformanceArea KeyPerformanceArea { get; private set; } = null!;

        private KeyPerformanceIndicator()
        {
            
        }
    }

    
}
