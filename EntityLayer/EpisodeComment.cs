using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EpisodeComment
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }

        public AppUser AppUser { get; set; }

        public int EpisodeId { get; set; }
        public Episode Episode { get; set; }

    }
}
