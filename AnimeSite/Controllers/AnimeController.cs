using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Controllers
{
    [AllowAnonymous]
    public class AnimeController : Controller
    {
        private readonly IAnimeService _animeService;
        public AnimeController(IAnimeService animeService)
        {
            _animeService = animeService;
        }

        public IActionResult AnimeList(string? p)
        {
            var values = _animeService.TGetList();
            if (!string.IsNullOrEmpty(p))
            {
                values = _animeService.GetList(p);
            }
            return View(values);
        }

        public IActionResult AnimeDetail(int id)
        {
            ViewBag.i = id;
            var values = _animeService.TGetById(id);
            return View(values);
        }
    }
}
