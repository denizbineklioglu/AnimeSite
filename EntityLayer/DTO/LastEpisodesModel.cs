using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO
{
    public class LastEpisodesModel
    {
        public int EpisodeId { get; set; }
        public string AnimeName { get; set; }
        public string ImageUrl { get; set; }
        public string EpisodeName { get; set; }
        public DateTime EpisodeDate { get; set; }
        public int CommentCount { get; set; }

    }
}
