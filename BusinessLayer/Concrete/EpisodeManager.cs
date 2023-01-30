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
            throw new NotImplementedException();
        }

        public void TDelete(Episode t)
        {
            throw new NotImplementedException();
        }

        public List<AnimesDetailEpsiode> TGetAnimeEpisodes(int id)
        {
            return _episodeDal.GetAnimeEpisodes(x=>x.AnimeID == id);
        }

        public Episode TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Episode> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Episode t)
        {
            throw new NotImplementedException();
        }
    }
}
