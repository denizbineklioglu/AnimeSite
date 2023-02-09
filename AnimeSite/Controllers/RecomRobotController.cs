using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Controllers
{
    [AllowAnonymous]
    public class RecomRobotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
