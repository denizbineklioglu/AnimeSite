using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Controllers
{
    [AllowAnonymous]
    public class EpisodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
