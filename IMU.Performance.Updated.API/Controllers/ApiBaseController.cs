using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMU.Performance.Updated.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBaseController : ControllerBase
    {
        protected readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
    }
}
