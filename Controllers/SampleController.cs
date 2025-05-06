using LaunchDarkly.NetCore.Demo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LaunchDarkly.NetCore.Demo.Controllers
{
    [Route("api/show-message")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ISampleService _sampleService;

        public SampleController(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMessage()
        {
            var message = await _sampleService.GetMessageAsync();
            return Ok(new { message });
        }
    }
}
