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
        private readonly IEpisodeService _episodeService;
        public AnimeController(IAnimeService animeService, IEpisodeService episodeService)
        {
            _animeService = animeService;
            _episodeService = episodeService;
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

        public IActionResult AnimeWatching(int id)
        {
            ViewBag.i = id;
            var result = _episodeService.TGetAnimeEpisodesById(id);
            return View(result);
        }
    }
}
