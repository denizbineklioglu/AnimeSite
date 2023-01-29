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
    public class AnimeCommentManager : IAnimeCommentService
    {

        IAnimeCommentDal _animeCommentDal;
        public AnimeCommentManager(IAnimeCommentDal animeCommentDal)
        {
            _animeCommentDal = animeCommentDal;
        }

        public void TAdd(AnimeComment t)
        {
            _animeCommentDal.Insert(t);
        }

        public void TDelete(AnimeComment t)
        {
            _animeCommentDal.Delete(t);
        }

        public List<AnimeCommentModel> TGetAnimeComments(int id)
        {
            return _animeCommentDal.GetAnimeComments(x=>x.AnimeID == id);
        }

        public AnimeComment TGetById(int id)
        {
            return _animeCommentDal.GetById(id);
        }

        public List<AnimeComment> TGetList()
        {
            return _animeCommentDal.GetList();
        }

        public void TUpdate(AnimeComment t)
        {
            _animeCommentDal.Update(t);
        }
    }
}
