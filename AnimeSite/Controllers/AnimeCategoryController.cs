using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Controllers
{
    [AllowAnonymous]
    public class AnimeCategoryController : Controller
    {
        private readonly IAnimeCategoryService _animeCategoryService;
        public AnimeCategoryController(IAnimeCategoryService animeCategoryService)
        {
            _animeCategoryService = animeCategoryService;
        }

        public IActionResult GetAnimeByCategory(int id)
        {
            var values = _animeCategoryService.TGetAnimeByCategory(id);
            return View(values);
        }
    }
}
