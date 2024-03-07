using IMU.Performance.Updated.API.Applications.Contracts;
using IMU.Performance.Updated.API.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMU.Performance.Updated.API.Controllers
{
    [Route("[agreements]")]
    [ApiController]
    public class AgreementsController : ApiBaseController
    {

        private readonly IAgreement _agreement;

        public AgreementsController(IAgreement agreement)
        {
            _agreement = agreement;
        }
        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<ActionResult> CreateAgreement(AgreementDTO agreement, CancellationToken cancellationToken)
        {
            await _agreement.CreateAgreement(agreement, _cancellationTokenSource.Token);
            return Ok();
        }
    }
}
