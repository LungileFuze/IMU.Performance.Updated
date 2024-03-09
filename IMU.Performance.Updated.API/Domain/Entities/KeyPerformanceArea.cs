using IMU.Performance.Updated.API.Domain.Exceptions;

namespace IMU.Performance.Updated.API.Domain.Entities
{
    public class KeyPerformanceArea: BaseEntity
    {
        public string Description { get; private set; } = null!;
        public int Weighting { get; set; }
        public string? ManagerComment { get; set; } //Question mark means nullable (not mandatory)
        public string? ModeratorComment { get; set; }

        //References (foreign key Id)
        public long AgreementId { get; private set; }
        public List<KeyPerformanceIndicator> KeyPerformanceIndicators { get; private set; } = new();
        //Agreement table as a foreign key
        public Agreement Agreement { get; private set; } = null!;
        public KeyPerformanceArea(long agreementId,string description, int weighting)
        {
            if (weighting > 90 || weighting < 1) throw new DataValidationException("The weighting should be between 1 and 90 inclusive");
            AgreementId = agreementId;
            Description = description;
            Weighting = weighting;
            DateCreated = DateTime.Now;
          
        }

        private KeyPerformanceArea()
        {
            
        }
    }
}
