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
    public class EfEpisodeCommentDal : GenericRepository<EpisodeComment>, IEpisodeCommentDal
    {
        public List<EpisodeCommentModel> GetEpisodeComments(Expression<Func<EpisodeComment, bool>> filter = null)
        {
            using (var context = new Context())
            {
                var result = from c in filter is null ? context.EpisodeComments : context.EpisodeComments.Where(filter)
                             join d in context.Users
                             on c.AppUserId equals d.Id
                             select new EpisodeCommentModel
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
