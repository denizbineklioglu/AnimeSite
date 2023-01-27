using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeSite.Views.ViewComponents
{
    public class _CategoryList:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = cm.TGetList();
            return View(values);
        }
    }
}
