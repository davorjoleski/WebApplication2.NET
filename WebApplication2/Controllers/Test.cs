using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class Test : ControllerBase
    {

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<string>
        {
            "Davor",
            "Marko",
            "Elena"
        };

            return Ok(users);
        }

    }
}   
