using modelo.Application.Models.ValueObject;
using modelo.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace modelo.Application.Models.PedidoModel
{
    public class PedidoPostRequest
    {
        [JsonProperty("pedido")]
        public List<PedidoDto> Pedido { get; set; }
    
    }
}
