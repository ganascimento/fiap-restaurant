using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Application.Models.ValueObject
{
    public class PedidoDto
    {
        [JsonProperty("categoriaId")]
        public Guid CategoriaId { get; set; }

        [JsonProperty("produto")]
        public List<ProdutoDto> Produto { get; set; }

    }
}
