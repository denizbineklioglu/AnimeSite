using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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

        [HttpPost]
        public IActionResult Index(string kategori, string year)
        {

            Context c = new Context();
            var result = c.AnimeCategories                            
                            .Include(categories => categories.Category)
                            .Include(animes => animes.Anime)
                            .Select(x => new { x.Anime.AnimeName, x.Anime.Rating }).ToList();
            return View(result);
        }
    }
}
