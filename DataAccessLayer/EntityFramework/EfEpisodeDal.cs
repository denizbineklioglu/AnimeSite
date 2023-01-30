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
    public class EfEpisodeDal : GenericRepository<Episode>, IEpisodeDal
    {
        public List<AnimesDetailEpsiode> GetAnimeEpisodes(Expression<Func<Episode, bool>> filter)
        {
            using (var context = new Context())
            {
                var result = from a in context.Episodes.Where(filter)
                             join b in context.Animes
                             on a.AnimeID equals b.AnimeID
                             select new AnimesDetailEpsiode
                             {
                                 Id = a.ID,
                                 Name = a.Name
                             };

                return result.ToList();
            }
        }
    }
}
