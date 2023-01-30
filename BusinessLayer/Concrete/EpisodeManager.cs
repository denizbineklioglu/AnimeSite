using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EpisodeManager : IEpisodeService
    {
        IEpisodeDal _episodeDal;
        public EpisodeManager(IEpisodeDal episodeDal)
        {
            _episodeDal = episodeDal;
        }

        public void TAdd(Episode t)
        {
            _episodeDal.Insert(t);
        }

        public void TDelete(Episode t)
        {
            _episodeDal.Delete(t);
        }

        public List<AnimesDetailEpisode> TGetAnimeEpisodes(int id)
        {
            return _episodeDal.GetAnimeEpisodes(x=>x.AnimeID == id);
        }

        public AnimesDetailEpisode TGetAnimeEpisodesById(int id)
        {
            return _episodeDal.GetAnimeEpisodeById(x=>x.ID == id);
        }

        public Episode TGetById(int id)
        {
            return _episodeDal.GetById(id);
        }

        public List<Episode> TGetList()
        {
            return _episodeDal.GetList();
        }

        public void TUpdate(Episode t)
        {
            _episodeDal.Update(t);
        }
    }
}
