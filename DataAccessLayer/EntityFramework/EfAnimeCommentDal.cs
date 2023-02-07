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
    public class EfAnimeCommentDal:GenericRepository<AnimeComment> , IAnimeCommentDal
    {
        public int GetAnimeCommentNumber(Expression<Func<AnimeComment, bool>> filter = null)
        {
            using (var context = new Context())
            {
                var result = from c in filter is null ? context.AnimeComments : context.AnimeComments.Where(filter)
                             join d in context.Users
                             on c.AppUserId equals d.Id
                             select c;
                             
                return result.Count();
            }
        }

        public List<AnimeCommentModel> GetAnimeComments(Expression<Func<AnimeComment, bool>> filter = null)
        {
            using (var context = new Context())
            {
                var result = from c in filter is null ? context.AnimeComments : context.AnimeComments.Where(filter)
                             join d in context.Users
                             on c.AppUserId equals d.Id
                             select new AnimeCommentModel
                             {
                                 UserName = d.UserName,
                                 Title = c.Title,
                                 Content = c.Content,
                                 CommentDate = c.CommentDate
                             };
                return result.ToList();
            }
        }
    }
}
