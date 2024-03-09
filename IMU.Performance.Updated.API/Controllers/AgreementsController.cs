using IMU.Performance.Updated.API.Applications.Contracts;
using IMU.Performance.Updated.API.Domain.Entities;
using IMU.Performance.Updated.API.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IMU.Performance.Updated.API.Controllers
{
    [Route("(agreements)")]
    public class AgreementsController : ApiBaseController
    {

        private readonly IAgreement _agreement;

        public AgreementsController(IAgreement agreement)
        {
            _agreement = agreement;
        }
        //[HttpPost]
        //[ProducesResponseType(200)]
        //public async Task<ActionResult> CreateAgreement(AgreementDTO agreement, CancellationToken cancellationToken)
        //{
        //    await _agreement.CreateAgreement(agreement, _cancellationTokenSource.Token);
        //    return Ok();
        //}
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AgreementDTO>>> GetAgreements()
        {
           IEnumerable<AgreementDTO> agreements = await _agreement.GetAgreements();
            return Ok(agreements);
        }
        [HttpPost]
        public async Task<ActionResult> CreateAgreement(AgreementDTO agreementDto)
        {
            if (agreementDto == null) return BadRequest();
            await _agreement.CreateAgreement(agreementDto, _cancellationTokenSource.Token);
            return Ok();
        }
        //[HttpPut("{agreementId:long}")]
        //public async Task<ActionResult> SendForApproval(long agreementId)
        //{
        //    Agreement? agreement = await _performanceDbContext.Agreements.FirstOrDefaultAsync(a => a.Id == agreementId);
        //    if(agreement == null) return NotFound();
        //    agreement.SendForApproval();
        //    await _performanceDbContext.SaveChangesAsync(_cancellationTokenSource.Token);
        //    return Ok();
        //}
    }
}
