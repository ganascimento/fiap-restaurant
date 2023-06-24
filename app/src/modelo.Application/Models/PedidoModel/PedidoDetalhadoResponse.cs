using modelo.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace modelo.Application.Models.PedidoModel
{
    public class PedidoDetalhadoResponse
    {
      
        [JsonProperty("Senha")]
        public int Senha { get; set; }

        [JsonProperty("Categoria")]
        public string CategoriaNome { get; set; }

        [JsonProperty("Produto")]
        public string ProdutoNome { get; set; }

        [JsonProperty("Valor")]
        public decimal Valor { get; set; }
    }
}
