using EntityLayer;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAnimeDal:IGenericDal<Anime>
    {
        List<AnimeCategoryModel> GetAnimeCategories(Expression<Func<AnimeCategory, bool>> filter=null);
        List<AnimeCommentModel> GetAnimeComments(Expression<Func<AnimeComment, bool>> filter = null);
    }
}
