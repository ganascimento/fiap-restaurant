using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Domain.ValueObjects
{
    public class PedidoDetalhadoDto
    {
        public int Senha { get; set; }
        public string CategoriaNome { get; set; }
        public string ProdutoNome { get; set; }
        public decimal Valor { get; set; }
    }
}
