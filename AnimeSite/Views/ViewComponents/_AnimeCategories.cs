using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Views.ViewComponents
{
    public class _AnimeCategories:ViewComponent
    {
        AnimeCategoryManager manager = new AnimeCategoryManager(new EfAnimeCategoryDal());
        public IViewComponentResult Invoke()
        {
            var result = manager.TGetAnimeByCategory();
            return View(result);
        }
    }
}
