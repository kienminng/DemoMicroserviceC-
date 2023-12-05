using Microsoft.AspNetCore.Mvc;

namespace demo2.Controllers
{
    [ApiController]
    [Route("~/demo2/[controller]/[action]")]
    public class Demo2Controller : ControllerBase
    {
        [HttpGet]
        public string First()
        {
            return "demo2 - calling ";
        }
    }
}
