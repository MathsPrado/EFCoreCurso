using EFCore.Domain;
using EFCORE.WEBAPI_E.Model;
using EFCORE_WEBAPI_E.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace EFCore.Repo
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroiBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadeSecretas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HeroApp;Data Source=DESKTOP-IITO3NE\\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(Entity =>
            {
                Entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            }
             );
        }
    }
}
