using Microsoft.AspNetCore.Mvc;

namespace FirstStatelessAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstController : ControllerBase
    {
        [HttpGet]
        [Route("get")]
        public async Task Get()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}
