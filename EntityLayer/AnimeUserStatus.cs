using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AnimeUserStatus
    {
        public int ID { get; set; }
        public AppUser AppUser { get; set; }
        public int AnimeID { get; set; }
        public Anime Anime { get; set; }
        public int AnimeStatusId { get; set; }
        public AnimeStatus AnimeStatus { get; set; }
    }
}
