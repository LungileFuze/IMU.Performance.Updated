namespace IMU.Performance.Updated.API.DTO
{
    public class AgreementDTO
    {
        public long Id { get; set; }

        public string FinancialYear { get; set; } = null!;

        public string ServiceNumber { get; set; } = null!;

        public string ManagerServiceNumber { get; set; } = null!;

        public int Status { get; set; }

        public List<KeyPerformanceAreaDTO> KeyPerformanceAreas { get; set; } = new();
    }
}
