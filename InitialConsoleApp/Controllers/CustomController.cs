using Microsoft.AspNetCore.Mvc;

namespace InitialConsoleApp.Controllers
{
    [ApiController]
    [Route("api/custom")]
    public class CustomController: ControllerBase
    {
        [HttpGet]
        public ActionResult Index()
        {
            return Ok("Custom Controller Get request fetched");
        }
    }
}
