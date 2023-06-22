using Newtonsoft.Json;
using System;

namespace modelo.Application.Models.PedidoModel
{
    public class PedidoDeleteRequest
    {
        public PedidoDeleteRequest()
        {
            Id = Guid.Empty;
        }

        [JsonProperty("Id")]
        public Guid Id { get; set; }
    }
}
