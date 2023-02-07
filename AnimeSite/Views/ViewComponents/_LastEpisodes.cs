using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Views.ViewComponents
{
    public class _LastEpisodes:ViewComponent
    {
        private readonly IEpisodeService _episodeService;
        public _LastEpisodes(IEpisodeService episodeService)
        {
            _episodeService = episodeService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _episodeService.TGetLastEpisodesByAnime();
            return View(result);
        }
    }
}
