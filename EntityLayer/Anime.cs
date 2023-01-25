using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Anime
    {
        [Key]
        public int AnimeID { get; set; }
        public string Name { get; set; }
        public string JapanName { get; set; }
        public string Description { get; set; }
        public string Type{ get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Studio { get; set; }
        public DateTime AnimeStartDate { get; set; }
        public double Rating { get; set; }
        public string Duration{ get; set; }
        public bool Status { get; set; }

        public List<AnimeCategory> AnimeCategories { get; set; }
        public List<Episode> Episodes { get; set; }
        public List<AnimeUserStatus> AnimeUserStatuses { get; set; }
        public List<AnimeComment> AnimeComments { get; set; }
        public List<AnimeVote> AnimeVotes { get; set; }
        public List<AnimeFavorite> AnimeFavorites { get; set; }
    }
}
