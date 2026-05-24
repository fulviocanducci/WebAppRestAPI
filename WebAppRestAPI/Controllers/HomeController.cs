using Microsoft.AspNetCore.Mvc;

namespace WebAppRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public HomeController() { }

        [HttpGet]
        public IActionResult GetHome()
        {
            object data = new
            {
                Date = DateTime.Now,
            };
            return Ok(data);
        }
    }
}
