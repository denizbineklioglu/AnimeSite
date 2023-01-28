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
        public IActionResult AnimeList(string? p)
        {
            var values = manager.TGetList();
            if (!string.IsNullOrEmpty(p))
            {
                values = manager.GetList(p);
            }
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
