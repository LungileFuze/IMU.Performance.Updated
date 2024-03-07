using IMU.Performance.Updated.API.DTO;

namespace IMU.Performance.Updated.API.Applications.Contracts
{
    public interface IAgreement
    {
        Task CreateAgreement(AgreementDTO agreementDTO, CancellationToken cancellationToken);
    }
}
