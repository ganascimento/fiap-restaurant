using modelo.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace modelo.Application.Models.PedidoModel
{
    public class PedidoResponse
    {
        [JsonProperty("CategoriaId")]
        public string CategoriaId { get; set; }

        [JsonProperty("ProdutoId")]
        public Guid ProdutoId { get; set; }
    }
}
