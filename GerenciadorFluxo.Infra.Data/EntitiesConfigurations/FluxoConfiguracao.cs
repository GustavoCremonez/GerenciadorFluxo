using GerenciadorFluxo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorFluxo.Infra.Data.EntitiesConfigurations
{
    public class FluxoConfiguracao : IEntityTypeConfiguration<Fluxo>
    {
        public void Configure(EntityTypeBuilder<Fluxo> builder)
        {
            builder.HasIndex(f => f.Id);

            builder.Property(f => f.Id).HasColumnName("Id");
            builder.Property(f => f.Nome).HasColumnType("varchar").HasMaxLength(50).HasColumnName("Nome");
            builder.Property(f => f.Descricao).HasColumnType("varchar").HasMaxLength(250).HasColumnName("Descricao");

            builder.HasMany(f => f.Processos)
                .WithOne(p => p.Fluxo)
                .HasForeignKey(p => p.Id)
                .HasConstraintName("IdFluxo")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}