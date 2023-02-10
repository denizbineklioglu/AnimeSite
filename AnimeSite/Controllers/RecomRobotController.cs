using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimeSite.Controllers
{
    [AllowAnonymous]
    public class RecomRobotController : Controller
    {
        private readonly ICategoryService _categoryService;
        public RecomRobotController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
    
        public IActionResult Index()
        {
            List<SelectListItem> categories = (from x in _categoryService.TGetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString(),                
                                               }
                                               ).ToList();
            ViewBag.categoryValue = categories;
            return View();
        }
    }
}
