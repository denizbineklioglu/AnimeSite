using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Views.ViewComponents
{
    public class _AnimeCategories:ViewComponent
    {
        AnimeManager manager = new AnimeManager(new EfAnimeDal());
        public IViewComponentResult Invoke(int id)
        {
            var result = manager.GetAnimeCategory(id);
            return View(result);
        }
    }
}
