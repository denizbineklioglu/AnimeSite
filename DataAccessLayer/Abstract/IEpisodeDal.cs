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
    public interface IEpisodeDal:IGenericDal<Episode>
    {
        List<AnimesDetailEpisode> GetAnimeEpisodes(Expression<Func<Episode,bool>> filter);

        AnimesDetailEpisode GetAnimeEpisodeById(Expression<Func<Episode, bool>> filter);

        List<LastEpisodesModel> GetLastEpisodesByAnime();

    }
}
