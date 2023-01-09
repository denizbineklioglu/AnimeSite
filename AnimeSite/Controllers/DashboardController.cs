using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
