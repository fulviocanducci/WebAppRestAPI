using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace WebAppRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    public class HomeController : ControllerBase
    {
        public HomeController() { }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetHome()
        {
            try
            {
                object data = new
                {
                    Date = DateTime.Now,
                    Guid = Guid.NewGuid()                    
                };
                return Ok(data);
            }
            catch (Exception)
            {
                throw;
            }            
        }
    }
}
