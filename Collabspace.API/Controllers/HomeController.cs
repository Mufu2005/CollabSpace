using Microsoft.AspNetCore.Mvc;

namespace CollabSpace.API.Controllers
{
    [ApiController]
    [Route("Home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get() => Ok("CollabSpace is alive!");

    }
}
