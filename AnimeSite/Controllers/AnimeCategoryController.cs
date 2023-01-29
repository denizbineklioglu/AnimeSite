using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Controllers
{
    [AllowAnonymous]
    public class AnimeCategoryController : Controller
    {
        AnimeCategoryManager manager = new AnimeCategoryManager(new EfAnimeCategoryDal());
        public IActionResult GetAnimeByCategory(int id)
        {
            var values = manager.TGetAnimeByCategory(id);
            return View(values);
        }
    }
}
