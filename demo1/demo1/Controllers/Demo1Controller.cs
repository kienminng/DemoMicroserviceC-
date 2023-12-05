using Microsoft.AspNetCore.Mvc;

namespace demo1.Controllers
{
    [ApiController]
    [Route("/demo1/[Controller]/[action]")]
    public class Demo1Controller : ControllerBase
    {
        [HttpGet]
        public string First()
        {
            return "Demo1 - calling ";
        }
    }
}
