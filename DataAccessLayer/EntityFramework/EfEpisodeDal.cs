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
        public AnimesDetailEpisode GetAnimeEpisodeById(Expression<Func<Episode, bool>> filter)
        {
            using (var context = new Context())
            {
                var result = from a in context.Episodes.Where(filter)
                             join b in context.Animes
                             on a.AnimeID equals b.AnimeID
                             select new AnimesDetailEpisode
                             {
                                 Id = a.ID,
                                 AnimeName = b.AnimeName,
                                 EpisodeName = a.Name,
                                 Source = a.Source,
                                 AnimeId = a.AnimeID
                             };
                return result.First();
            }
        }

        public List<AnimesDetailEpisode> GetAnimeEpisodes(Expression<Func<Episode, bool>> filter)
        {
            using (var context = new Context())
            {
                var result = from a in context.Episodes.Where(filter)
                             join b in context.Animes
                             on a.AnimeID equals b.AnimeID
                             select new AnimesDetailEpisode
                             {
                                 Id = a.ID,
                                 EpisodeName = a.Name,
                                 AnimeName = b.AnimeName,
                                 Source = a.Source
                             };

                return result.ToList();
            }
        }

        public List<LastEpisodesModel> GetLastEpisodesByAnime()
        {
            using (var context = new Context())
            {
                var result = from a in context.Episodes
                             join b in context.Animes
                             on a.AnimeID equals b.AnimeID
                             orderby a.EpisodeDate descending
                             select new LastEpisodesModel
                             {
                                 EpisodeId = a.ID,
                                 AnimeName = b.AnimeName,
                                 EpisodeName = a.Name,
                                 EpisodeDate = a.EpisodeDate,
                                 ImageUrl = b.Image1
                             };
                return result.Take(3).ToList();
            }
        }
    }
}
