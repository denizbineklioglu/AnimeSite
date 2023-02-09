using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer;
using EntityLayer.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                var q = context.Episodes
                        .Include(x=>x.Anime)
                        .Include(x=>x.EpisodeComments)
                        .OrderByDescending(x=>x.EpisodeDate)
                        .Take(3)
                        .Select(x => new LastEpisodesModel()
                        {
                            EpisodeId = x.ID,
                            AnimeName = x.Anime.AnimeName,
                            EpisodeName = x.Name,
                            CommentCount = x.EpisodeComments.Count(),
                            EpisodeDate = x.EpisodeDate,
                            ImageUrl = x.Anime.Image1
                        });

                return q.ToList();
            }
        }
    }
}
