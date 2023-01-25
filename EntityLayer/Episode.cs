using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Episode
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }

        public int AnimeID { get; set; }
        public Anime Anime { get; set; }

        public List<EpisodeComment> EpisodeComments { get; set; }
    }
}
