using IMU.Performance.Updated.API.Applications.Contracts;
using IMU.Performance.Updated.API.Domain.Entities;
using IMU.Performance.Updated.API.Domain.Exceptions;
using IMU.Performance.Updated.API.DTO;
using Microsoft.EntityFrameworkCore;

namespace IMU.Performance.Updated.API.Applications
{
    public class AgreementService : IAgreement
    {
        private readonly IPerformanceDbContext _context;
        public AgreementService(IPerformanceDbContext context)
        {

            _context = context;

        }
        public async Task<IEnumerable<AgreementDTO>> GetAgreements()
        {
            return await _context.Agreements.Select(a => new AgreementDTO
            {
                Id = a.Id,
                FinancialYear = a.FinancialYear,
                ManagerServiceNumber = a.ManagerServiceNumber,
                ServiceNumber = a.ServiceNumber,
                Status = (int)a.Status
            }).
            ToListAsync();
        }
        public async Task CreateAgreement(AgreementDTO agreementDTO, CancellationToken cancellationToken = default)
        {
            if(agreementDTO == null) throw new ArgumentNullException(nameof(agreementDTO));
            Agreement? agreement = await _context.Agreements.FirstOrDefaultAsync(a => a.ServiceNumber == agreementDTO.ServiceNumber && a.FinancialYear == agreementDTO.FinancialYear, cancellationToken);
            if (agreement != null) throw new InvalidActionException("Agreement already exist.");
            agreement = new Agreement(agreementDTO.FinancialYear, agreementDTO.ServiceNumber, agreementDTO.ManagerServiceNumber);
            _context.Agreements.Add(agreement);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
