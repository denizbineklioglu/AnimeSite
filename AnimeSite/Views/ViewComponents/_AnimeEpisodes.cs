using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Views.ViewComponents
{
    public class _AnimeEpisodes:ViewComponent
    {
        private readonly IEpisodeService _episodeService;
        public _AnimeEpisodes(IEpisodeService episodeService)
        {
            _episodeService = episodeService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var result = _episodeService.TGetAnimeEpisodes(id);
            return View(result);
        }
    }
}
