using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AnimeVote
    {
        public int ID { get; set; }
        public AppUser AppUser { get; set; }

        public int AnimeID { get; set; }
        public Anime Anime { get; set; }

    }
}
