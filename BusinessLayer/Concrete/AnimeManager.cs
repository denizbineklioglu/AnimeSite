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
    public class AnimeManager : IAnimeService
    {
        IAnimeDal _animeDal;
        public AnimeManager(IAnimeDal animeDal)
        {
            _animeDal = animeDal;
        }

        public List<AnimeCategoryModel> GetAnimeCategory(int id)
        {
            return _animeDal.GetAnimeCategories(x => x.AnimeID == id);
        }

        public void TAdd(Anime t)
        {
            _animeDal.Insert(t);
        }

        public void TDelete(Anime t)
        {
            _animeDal.Delete(t);
        }

        public Anime TGetById(int id)
        {
            return _animeDal.GetById(id);   
        }

        public List<Anime> TGetList()
        {
            return _animeDal.GetList();
        }

        public void TUpdate(Anime t)
        {
            _animeDal.Update(t);
        }
    }
}
