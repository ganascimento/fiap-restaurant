using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;


namespace modelo.Infrastructure.DataProviders.EntityConfigurations
{
    internal class AcompanhamentoEntityConfiguration : IEntityTypeConfiguration<Acompanhamento>
    {
        public void Configure(EntityTypeBuilder<Acompanhamento> builder)
        {
            builder
                .ToTable("tb_Acompanhamento")
                .HasKey(p => new { p.Id });

            builder.Property(p => p.Id)
                .HasColumnType("varchar(36)");

            builder.Property(p => p.Senha)
                .HasColumnType("int");

            builder.Property(p => p.Status)
                .HasColumnType("int");
        }
    }
}
