using Newtonsoft.Json;
using System;

namespace modelo.Application.Models.ProdutoModel
{
    public class ProdutoResponse
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Valor")]
        public decimal Valor { get; set; }

        [JsonProperty("CategoriaId")]
        public Guid? CategoriaId { get; set; }
    }
}
