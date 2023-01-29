using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Views.ViewComponents
{
    public class _AnimeComments:ViewComponent
    {
        AnimeCommentManager manager = new AnimeCommentManager(new EfAnimeCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var result = manager.TGetAnimeComments(id);
            return View(result);
        }
    }
}
