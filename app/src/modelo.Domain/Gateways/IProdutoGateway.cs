using modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace modelo.Domain.Gateways
{
    public interface IProdutoGateway : IRepositoryGateway<Produto, Guid>
    {
        Task<IEnumerable<Produto>> GetProdutoByCategoriaIdAsync(Guid CategoriaId);
    }
}
