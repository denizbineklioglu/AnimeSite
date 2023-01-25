using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AnimeFavorite
    {
        public int ID { get; set; }
        public AppUser AppUser { get; set; }

        public int AnimeId { get; set; }
        public Anime Anime { get; set; }
    }
}
