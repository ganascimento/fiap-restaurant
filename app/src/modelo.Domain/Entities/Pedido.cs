using modelo.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Domain.Entities
{
    public class Pedido : Entity<Guid>    
    {
        public int Senha { get; set; }

        public Guid CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        public Guid ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }



    }
}
