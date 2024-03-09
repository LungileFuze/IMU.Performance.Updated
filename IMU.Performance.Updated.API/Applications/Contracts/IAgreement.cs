using IMU.Performance.Updated.API.DTO;

namespace IMU.Performance.Updated.API.Applications.Contracts
{
    public interface IAgreement
    {
        Task<IEnumerable<AgreementDTO>> GetAgreements();
        Task CreateAgreement(AgreementDTO agreementDTO, CancellationToken cancellationToken);

        Task AddKpa(KeyPerformanceAreaDTO keyPerformanceAreaDTO, CancellationToken cancellationToken = default);
    }
}
