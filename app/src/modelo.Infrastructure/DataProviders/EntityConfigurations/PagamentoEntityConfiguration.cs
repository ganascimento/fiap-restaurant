using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using modelo.Domain.Entities;

namespace modelo.Infrastructure.DataProviders.EntityConfigurations
{
    public class PagamentoEntityConfiguration : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder
                .ToTable("tb_Pagamento")
                .HasKey(p => new { p.Id });

            builder.Property(p => p.Status)
                .HasColumnType("int")
                .IsRequired(true)
                .HasConversion<int>();

            builder.Property(p => p.TipoPagamento)
                .HasColumnType("int")
                .IsRequired(true)
                .HasConversion<int>();

            builder.HasOne(p => p.Pedido)
                .WithOne(p => p.Pagamento)
                .HasForeignKey<Pagamento>(p => p.PedidoId);
        }
    }
}