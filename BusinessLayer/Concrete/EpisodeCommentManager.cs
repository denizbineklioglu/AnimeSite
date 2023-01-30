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
    public class EpisodeCommentManager : IEpisodeCommentService
    {
        IEpisodeCommentDal _episodeCommentDal;
        public EpisodeCommentManager(IEpisodeCommentDal episodeCommentDal)
        {
            _episodeCommentDal = episodeCommentDal;
        }

        public void TAdd(EpisodeComment t)
        {
            _episodeCommentDal.Insert(t);
        }

        public void TDelete(EpisodeComment t)
        {
            _episodeCommentDal.Insert(t);
        }

        public EpisodeComment TGetById(int id)
        {
            return _episodeCommentDal.GetById(id);  
        }

        public List<EpisodeComment> TGetList()
        {
            return _episodeCommentDal.GetList();
        }

        public List<EpisodeCommentModel> TGetList(int id)
        {
            return _episodeCommentDal.GetEpisodeComments(x=>x.EpisodeId == id);
        }

        public void TUpdate(EpisodeComment t)
        {
            _episodeCommentDal.Update(t);
        }
    }
}
