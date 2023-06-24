using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;
using modelo.Infrastructure.DataProviders.EntityConfigurations;
using modelo.Infrastructure.Seeds;

namespace modelo.Infrastructure.DataProviders
{
    public class DBContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Acompanhamento> Acompanhamento { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteEntityConfiguration());

            modelBuilder.ApplyConfiguration(new CategoriaEntityConfiguration());

            modelBuilder.ApplyConfiguration(new ProdutoEntityConfiguration());

            modelBuilder.ApplyConfiguration(new PedidoEntityConfiguration());

            modelBuilder.ApplyConfiguration(new AcompanhamentoEntityConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);

            ClienteSeed.Seed(modelBuilder);
            CategoriaSeed.Seed(modelBuilder);
            ProdutoSeed.Seed(modelBuilder);
        }
    }


}
