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

            builder.Property(p => p.Nome).HasColumnType("varchar").HasMaxLength(50).HasColumnName("Nome");
            builder.Property(p => p.TipoProcesso).HasColumnType("tinyint ").HasColumnName("TipoProcesso");

            builder.HasMany(p => p.SubProcessos)
                .WithOne(sb => sb.ProcessoSuperior)
                .HasForeignKey(x => x.IdProcessoSuperior)
                .HasConstraintName("IdProcessoSuperior");
        }
    }
}