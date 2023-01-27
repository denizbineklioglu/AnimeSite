using EntityLayer;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAnimeCategoryDal:IGenericDal<AnimeCategory>
    {
        List<AnimeCategoryModel> GetCategoryByAnime(Expression<Func<AnimeCategory, bool>> filter = null);
    }
}
