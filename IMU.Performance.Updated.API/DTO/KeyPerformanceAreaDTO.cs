namespace IMU.Performance.Updated.API.DTO
{
    public class KeyPerformanceAreaDTO
    {
        public long Id { get; set; }
        public string Description { get; set; } = null!;
        public int Weighting { get; set; }
        public string? ManagerComment { get; set; } 
        public string? ModeratorComment { get; set; }

        public long AgreementId { get;  set; }
    }
}
