using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using modelo.Domain.Entities;

namespace modelo.Infrastructure.DataProviders.EntityConfigurations
{
    public class CategoriaEntityConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder
                .ToTable("tb_Categoria")
                .HasKey(p => new { p.Id });

            builder.Property(p => p.Id)
                .HasColumnType("varchar(36)");

            builder.Property(p => p.Nome)
               .HasColumnType("varchar(200)");

            builder.HasMany(p => p.Produtos)
                .WithOne(p => p.Categoria)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
