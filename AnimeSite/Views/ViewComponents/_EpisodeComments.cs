using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Views.ViewComponents
{
    public class _EpisodeComments:ViewComponent
    {
        private readonly IEpisodeCommentService _episodeCommentService;
        public _EpisodeComments(IEpisodeCommentService episodeCommentService)
        {
            _episodeCommentService = episodeCommentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _episodeCommentService.TGetList(id);
            return View(values);
        }
    }
}
