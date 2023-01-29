using EntityLayer;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAnimeCommentService:IGenericService<AnimeComment>
    {
        List<AnimeCommentModel> TGetAnimeComments(int id);
    }
}
