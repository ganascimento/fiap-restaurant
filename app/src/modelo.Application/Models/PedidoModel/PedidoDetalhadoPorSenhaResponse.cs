using modelo.Domain.Entities;
using modelo.Domain.ValueObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace modelo.Application.Models.PedidoModel
{
    public class PedidoDetalhadoPorSenhaResponse
    {
      
        [JsonProperty("Pedido")]
        public List<PedidoDetalhadoDto> Pedido { get; set; }

        [JsonProperty("ValorTotal")]
        public decimal ValorTotal { get; set; }
    }
}
