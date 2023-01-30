using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO
{
    public class AnimesDetailEpisode
    {
        public int Id { get; set; }
        public int AnimeId { get; set; }
        public string EpisodeName { get; set; }
        public string AnimeName { get; set; }
        public string Source { get; set; }
    }
}
