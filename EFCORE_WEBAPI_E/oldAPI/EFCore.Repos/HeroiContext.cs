using EFCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCORE.WEBAPI_E.Data
{
    public class HeroiContext : DbContext
    {
        public HeroiContext(DbContextOptions<HeroiContext> options) : base(options) {}
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroiBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadeSecretas { get; set; }


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
