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

            builder.Property(f => f.Nome).HasColumnType("varchar").HasMaxLength(50).HasColumnName("Nome");
            builder.Property(f => f.Descricao).HasColumnType("varchar").HasMaxLength(250).HasColumnName("Descricao");

            builder.HasMany(f => f.Processos)
                .WithOne(p => p.Fluxo)
                .HasForeignKey(p => p.IdFluxo)
                .HasConstraintName("IdFluxo")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new(1, "Fluxo de vendas", "Fluxo destinado para o controle dos processos de vendas"),
                    new(2, "Fluxo de people", "Fluxo destinado para o controle dos processos de people")
                );
        }
    }
}