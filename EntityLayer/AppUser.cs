using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AppUser:IdentityUser<int>
    {
        public string? ImageUrl { get; set; }

        public List<AnimeComment> AnimeComments { get; set; }
        public List<EpisodeComment> EpisodeComments { get; set; }
        public List<AnimeFavorite> AnimeFavorites { get; set; }
        public List<AnimeVote> AnimeVotes { get; set; }
        public List<AnimeUserStatus> AnimeUserStatues { get; set; }
    }
}
