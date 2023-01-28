using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Controllers
{
    [AllowAnonymous]
    public class AnimeController : Controller
    {
        AnimeManager manager = new AnimeManager(new EfAnimeDal());
        public IActionResult AnimeList()
        {
            var values = manager.TGetList();
            return View(values);
        }

        public IActionResult AnimeDetail(int id)
        {
            ViewBag.i = id;
            var values = manager.TGetById(id);
            return View(values);
        }
    }
}
