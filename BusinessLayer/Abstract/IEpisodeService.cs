using EntityLayer;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEpisodeService:IGenericService<Episode>
    {
        List<AnimesDetailEpisode> TGetAnimeEpisodes(int id);

        AnimesDetailEpisode TGetAnimeEpisodesById(int id);

        List<LastEpisodesModel> TGetLastEpisodesByAnime();
    }
}
