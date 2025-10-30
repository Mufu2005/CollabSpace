using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CollabSpace.API.Controllers
{
    [Route("CollabSpace")]
    
    public class HomeController : Controller
    {
        private string Username { get; set; }

        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("Dashboard")]
        public async Task<IActionResult> Dashboard()
        {
            var token = Request.Cookies["AuthToken"];
            if (token != null)
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(token);

                Username = jwtToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                ViewBag.Username = Username;
            }
            return View();
        }



        

    }
}
