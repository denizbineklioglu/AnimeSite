using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAnimeDal : GenericRepository<Anime>, IAnimeDal
    {
        public List<AnimeCategoryModel> GetAnimeCategories(Expression<Func<AnimeCategory, bool>> filter=null)
        {
            using (var context = new Context())
            {
                var result = from c in filter is null ? context.AnimeCategories : context.AnimeCategories.Where(filter)
                             join d in context.Categories
                             on c.CategoryID equals d.CategoryID
                             join e in context.Animes
                             on c.AnimeID equals e.AnimeID
                             select new AnimeCategoryModel
                             {
                                 AnimeName = e.AnimeName,
                                 CategoryName = d.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
