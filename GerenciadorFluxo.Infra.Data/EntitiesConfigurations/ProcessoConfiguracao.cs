using GerenciadorFluxo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorFluxo.Infra.Data.EntitiesConfigurations
{
    internal class ProcessoConfiguracao : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            builder.HasIndex(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.IdProcessoSuperior).HasColumnName("IdProcessoSuperior");
            builder.Property(p => p.IdFluxo).HasColumnName("IdFluxo");
            builder.Property(p => p.Nome).HasColumnType("varchar").HasMaxLength(50).HasColumnName("Nome");
            builder.Property(p => p.TipoProcesso).HasColumnType("tinyint ").HasColumnName("TipoProcesso");

            builder.HasMany(p => p.Anotacoes)
                .WithOne(a => a.Processo)
                .HasForeignKey(a => a.IdProcesso)
                .HasConstraintName("IdProcesso")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}