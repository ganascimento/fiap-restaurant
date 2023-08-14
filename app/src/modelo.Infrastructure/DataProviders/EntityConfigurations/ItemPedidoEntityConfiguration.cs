using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using modelo.Domain.Entities;

namespace modelo.Infrastructure.DataProviders.EntityConfigurations
{
    public class ItemPedidoEntityConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder
                .ToTable("tb_ItemPedido")
                .HasKey(p => new { p.Id });

            builder.Property(p => p.Observacao)
                .HasColumnName("Observacao")
                .HasMaxLength(500)
                .IsRequired(false);

            builder.HasOne(p => p.Pedido)
                .WithMany(p => p.ItensPedido)
                .HasForeignKey(p => p.PedidoId);

            builder.HasOne(p => p.Produto)
                .WithMany(p => p.ItensPedido)
                .HasForeignKey(p => p.ProdutoId);
        }
    }
}