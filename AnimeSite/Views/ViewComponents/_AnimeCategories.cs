using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Views.ViewComponents
{
    public class _AnimeCategories:ViewComponent
    {
        private readonly IAnimeService _animeService;
        public _AnimeCategories(IAnimeService animeService)
        {
            _animeService = animeService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var result = _animeService.GetAnimeCategory(id);
            return View(result);
        }
    }
}
