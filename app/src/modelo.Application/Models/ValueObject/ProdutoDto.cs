using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Application.Models.ValueObject
{
    public class ProdutoDto
    {
        [JsonProperty("produtoId")]
        public Guid ProdutoId { get; set; }
    }
}
