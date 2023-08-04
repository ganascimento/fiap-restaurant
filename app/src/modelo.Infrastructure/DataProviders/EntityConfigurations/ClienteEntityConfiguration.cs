using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using modelo.Domain.Entities;

namespace modelo.Infrastructure.DataProviders.EntityConfigurations
{
    public class ClienteEntityConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .ToTable("tb_Cliente")
                .HasKey(p => new { p.Id });

            builder.Property(p => p.Nome)
               .HasColumnType("varchar(200)");

            builder.Property(p => p.Cpf)
               .HasColumnType("varchar(11)");
        }
    }
}
