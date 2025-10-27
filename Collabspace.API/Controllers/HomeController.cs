using Microsoft.AspNetCore.Mvc;

namespace CollabSpace.API.Controllers
{
    [ApiController]
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
        

    }
}
