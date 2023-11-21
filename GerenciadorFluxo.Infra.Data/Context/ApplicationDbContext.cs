using GerenciadorFluxo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorFluxo.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Fluxo> Fluxos { get; set; }

        public DbSet<Processo> Processos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}