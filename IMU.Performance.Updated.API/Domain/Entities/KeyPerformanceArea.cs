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
        public KeyPerformanceArea(long agreementId,string description, int weighting, string? managerComment, string? moderatorComment)
        {
            AgreementId = agreementId;
            Description = description;
            Weighting = weighting;
            ManagerComment = managerComment;
            ModeratorComment = moderatorComment;
            DateCreated = DateTime.Now;
          
        }

        private KeyPerformanceArea()
        {
            
        }
    }
}
