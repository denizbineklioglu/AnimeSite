using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO
{
    public class AnimeCommentModel
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
