using GerenciadorFluxo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorFluxo.Infra.Data.EntitiesConfigurations
{
    public class AnotacaoConfiguracao : IEntityTypeConfiguration<Anotacao>
    {
        public void Configure(EntityTypeBuilder<Anotacao> builder)
        {
            builder.HasIndex("Id");

            builder.Property(a => a.Id).HasColumnName("Id");
            builder.Property(a => a.IdProcesso).HasColumnName("IdProcesso");
            builder.Property(a => a.Descricao).HasColumnType("varchar").HasMaxLength(250).HasColumnName("Descricao");
        }
    }
}