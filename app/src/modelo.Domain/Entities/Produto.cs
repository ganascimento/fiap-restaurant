using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Domain.Entities
{
    public class Produto : Entity<Guid>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Guid? CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
