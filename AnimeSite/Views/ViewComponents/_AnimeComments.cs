using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Views.ViewComponents
{
    public class _AnimeComments:ViewComponent
    {
        private readonly IAnimeCommentService _animeCommentService;
        public _AnimeComments(IAnimeCommentService animeCommentService)
        {
            _animeCommentService = animeCommentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var result = _animeCommentService.TGetAnimeComments(id);
            return View(result);
        }
    }
}
