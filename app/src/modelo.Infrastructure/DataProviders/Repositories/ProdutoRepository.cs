using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Infrastructure.DataProviders.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto,Guid>, IProdutoGateway
    {
        private readonly DBContext dBContext;
        public ProdutoRepository(DBContext dbContext) : base(dbContext){
        this.dBContext = dbContext;
        }

        public IEnumerable<Produto> GetProdutoByCategoriaId(Guid CategoriaId)
        {
            var data = dBContext.Produto.AsQueryable();

            var result = data.Where(x => x.CategoriaId.Equals(CategoriaId)).ToList();
            if (result != null)
                return result;

            return null;
        }
    }
}
