using APIRest.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace APIRest.Infraestrutura.Data
{
    public class AppDbContexto : DbContext
    {
        public AppDbContexto(DbContextOptions<AppDbContexto> options) : base(options) { }

        public DbSet<Carteirinha> Carteirinha { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContexto).Assembly);
        }
    }
}
