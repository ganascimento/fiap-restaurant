using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using modelo.Domain.ValueObjects;

namespace modelo.Infrastructure.DataProviders.Repositories
{
    public class PedidoRepository : RepositoryBase<Pedido, Guid>, IPedidoGateway
    {
        private readonly DbSet<Pedido> _pedidoDbSet;
        private readonly DBContext _dbContext;


        public PedidoRepository(DBContext dbContext) : base(dbContext)
        {
            _pedidoDbSet = dbContext.Set<Pedido>();
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<PedidoDetalhadoDto>> GetPedidoBySenhaUseCaseAsync(int senha)
        {  
            var query = (
            from pedido in _dbContext.Pedido
            where pedido.Senha.Equals(senha)
            join produto in _dbContext.Produto on pedido.ProdutoId equals produto.Id
            join categoria in _dbContext.Categoria on pedido.CategoriaId equals categoria.Id

            select new PedidoDetalhadoDto
            {
                Id = pedido.Id,
                Senha = pedido.Senha,
                CategoriaNome = categoria.Nome,
                ProdutoNome = produto.Nome,
                Valor = produto.Valor
            }).ToListAsync();

            return query.Result.OrderBy(senha => senha.Senha);
        }

        public async Task<IEnumerable<PedidoDetalhadoDto>> GetPedidoDetalhado()
        {
            var query = (
            from pedido in _dbContext.Pedido
            join produto in _dbContext.Produto on pedido.ProdutoId equals produto.Id
            join categoria in _dbContext.Categoria on pedido.CategoriaId equals categoria.Id

            select new PedidoDetalhadoDto
            {
                Id = pedido.Id,
                Senha = pedido.Senha,
                CategoriaNome = categoria.Nome,
                ProdutoNome = produto.Nome,
                Valor = produto.Valor
            }).ToListAsync();

            return query.Result.OrderBy(senha=>senha.Senha);
            
        }

    }
}
