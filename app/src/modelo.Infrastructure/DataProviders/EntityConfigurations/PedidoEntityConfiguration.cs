using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using modelo.Domain.Entities;

namespace modelo.Infrastructure.DataProviders.EntityConfigurations
{
    public class PedidoEntityConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder
                .ToTable("tb_Pedido")
                .HasKey(p => new { p.Id });

            builder.Property(p => p.Id)
                .HasColumnType("varchar(36)");

            builder.Property(p => p.Senha)
                .HasColumnType("int");


            builder.Property(p => p.CategoriaId)
                .HasColumnName("CategoriaId")
                .HasColumnType("varchar(36)");

            builder.Property(p => p.ProdutoId)
                .HasColumnName("ProdutoId")
                 .HasColumnType("varchar(36)");


            builder.HasOne(p => p.Categoria).WithMany()
                .HasForeignKey(p => p.CategoriaId);

            builder.HasOne(p => p.Produto).WithMany()
               .HasForeignKey(p => p.ProdutoId);



        }
    }
}
