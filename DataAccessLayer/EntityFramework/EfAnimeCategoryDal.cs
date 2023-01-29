using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer;
using EntityLayer.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAnimeCategoryDal : GenericRepository<AnimeCategory>, IAnimeCategoryDal
    {
        public List<CategoryByAnimeModel> GetAnimeByCategory(Expression<Func<AnimeCategory, bool>> filter = null)
        {
            using (var context = new Context())
            {
                var result = from a in filter is null ? context.AnimeCategories : context.AnimeCategories.Where(filter)
                             join b in context.Categories
                             on a.CategoryID equals b.CategoryID
                             join c in context.Animes
                             on a.AnimeID equals c.AnimeID
                             select new CategoryByAnimeModel
                             {
                                 AnimeId = c.AnimeID,
                                 AnimeName = c.AnimeName,
                                 ImageUrl = c.Image1
                             };
                return result.ToList();
            }
        }

        public List<AnimeCategoryModel> GetCategoryByAnime(Expression<Func<AnimeCategory, bool>> filter = null)
        {
            using (var context = new Context())
            {
                var result = from p in filter is null ? context.AnimeCategories : context.AnimeCategories.Where(filter)
                             join d in context.Categories on p.CategoryID equals d.CategoryID
                             select new AnimeCategoryModel
                             {
                                 CategoryName = d.CategoryName                               
                             };
                
                return result.ToList();
            }
        }
    }
}
