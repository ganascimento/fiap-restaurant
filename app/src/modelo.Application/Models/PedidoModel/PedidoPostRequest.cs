using modelo.Application.Models.ValueObject;
using modelo.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace modelo.Application.Models.PedidoModel
{
    public class PedidoPostRequest
    {
        [JsonProperty("produto")]
        public List<ProdutoDto> Produtos { get; set; }

        [JsonProperty("Pagamento")]
        public PagamentoDto Pagamento { get; set; }

    }
}
