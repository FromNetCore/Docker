using Microsoft.AspNetCore.Mvc;

namespace Docker.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet("test")]
        public string GetHello() => "Hello World";
    }
}
