using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessingWithStartups.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopersController : ControllerBase
    {
        private IDeveloper developer;

        public DevelopersController(IDeveloper developer)
        {
            this.developer = developer;
        }

        [HttpGet]
        public ActionResult SayHello()
        {
            return Ok(developer.Do);
        }
    }
}