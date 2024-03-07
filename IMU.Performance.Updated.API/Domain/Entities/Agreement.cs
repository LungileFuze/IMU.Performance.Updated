using IMU.Performance.Updated.API.Domain.Enumeration;
using IMU.Performance.Updated.API.Domain.Exceptions;

namespace IMU.Performance.Updated.API.Domain.Entities
{
    public class Agreement : BaseEntity
    {
        public string FinancialYear { get; private set; } = null!; //null! (null ignore)

        public string ServiceNumber { get; private set; } = null!;

        public string ManagerServiceNumber { get; private set; } = null!;

        public AgreementStatus Status { get; private set; }

        public List<KeyPerformanceArea> KeyPerformanceAreas { get; private set; } = new();

        public Agreement(string financialYear, string serviceNumber, string managerServiceNumber)
        {
            FinancialYear = financialYear;
            ServiceNumber = serviceNumber;
            ManagerServiceNumber = managerServiceNumber;
            DateCreated = DateTime.Now;
            Status = AgreementStatus.Created;
        }

        private Agreement()
        {
            
        }

        //public void SendForApproval() =>Status = AgreementStatus.SentForApproval; Shortcut

        public void SendForApproval() 
        {
            if (Status == AgreementStatus.Approved) throw new InvalidActionException("Invalid status.");
            Status = AgreementStatus.SentForApproval;
        }
        public void Approve()
        {
            if (Status != AgreementStatus.SentForApproval) throw new InvalidActionException("Invalid status.");
            Status|= AgreementStatus.Approved;
        }

        public void Reject()
        {
            if (Status != AgreementStatus.SentForApproval) throw new InvalidActionException("Invalid status.");
            Status = AgreementStatus.Rejected;
        }
    }
}
