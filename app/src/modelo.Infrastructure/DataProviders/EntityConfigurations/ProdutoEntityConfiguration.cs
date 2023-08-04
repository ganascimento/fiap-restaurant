using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using modelo.Domain.Entities;

namespace modelo.Infrastructure.DataProviders.EntityConfigurations
{
    public class ProdutoEntityConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder
                .ToTable("tb_Produto")
                .HasKey(p => new { p.Id });

            builder.Property(p => p.Nome)
               .HasColumnType("varchar(200)");

            builder.Property(p => p.Valor)
              .HasColumnType("decimal(19,2)");

            builder.HasOne(p => p.Categoria)
                .WithMany(p => p.Produtos);

            builder.HasMany(p => p.ItensPedido)
                .WithOne(p => p.Produto)
                .HasForeignKey(p => p.ProdutoId);
        }
    }
}
