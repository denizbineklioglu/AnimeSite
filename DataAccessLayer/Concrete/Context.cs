using EntityLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-N2Q4B92;database=AnimeDB;integrated security=true;TrustServerCertificate=True;");
        }


        public DbSet<Anime> Animes { get; set; }
        public DbSet<AnimeCategory> AnimeCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Episode> Episodes { get; set; }        
        public DbSet<AnimeComment> AnimeComments  { get; set; }   
        public DbSet<EpisodeComment> EpisodeComments  { get; set; }   
        public DbSet<AnimeFavorite> AnimeFavorites  { get; set; }   
        public DbSet<AnimeVote> AnimeVotes  { get; set; }   
        public DbSet<AnimeStatus> AnimeStatuses  { get; set; }   
        public DbSet<AnimeUserStatus> AnimeUserStatuses  { get; set; }   
        

    }
}
