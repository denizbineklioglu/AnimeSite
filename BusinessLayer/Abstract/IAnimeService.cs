using EntityLayer;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAnimeService:IGenericService<Anime>
    {
        List<AnimeCategoryModel> GetAnimeCategory(int id);
        List<Anime> GetList(string? p);
        List<AnimeCommentModel> TGetAnimeComments(int id);
    }
}
