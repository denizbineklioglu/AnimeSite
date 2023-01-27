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
    public class AnimeCategoryManager : IAnimeCategoryService
    {
        IAnimeCategoryDal _animeCategoryDal;
        public AnimeCategoryManager(IAnimeCategoryDal animeCategoryDal)
        {
            _animeCategoryDal = animeCategoryDal;
        }

        public void TAdd(AnimeCategory t)
        {
            _animeCategoryDal.Insert(t);
        }

        public void TDelete(AnimeCategory t)
        {
            _animeCategoryDal.Delete(t);
        }

        public List<AnimeCategoryModel> TGetAnimeByCategory()
        {
            return _animeCategoryDal.GetCategoryByAnime();
        }

        public AnimeCategory TGetById(int id)
        {
           return _animeCategoryDal.GetById(id);
        }

        public List<AnimeCategory> TGetList()
        {
            return _animeCategoryDal.GetList();
        }

        public void TUpdate(AnimeCategory t)
        {
            _animeCategoryDal.Update(t);
        }
    }
}
