using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-N2Q4B92;database=AnimeDB;integrated security=true;TrustServerCertificate=True;");
        }

        public DbSet<Anime> Animes { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
