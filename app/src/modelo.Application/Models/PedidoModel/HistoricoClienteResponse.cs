using System.Collections.Generic;
using Newtonsoft.Json;

namespace modelo.Application.Models.PedidoModel
{
    public class HistoricoClienteResponse
    {
        [JsonProperty("Senha")]
        public int Senha { get; set; }

        [JsonProperty("Total")]
        public decimal Total { get; set; }

        [JsonProperty("ItensPedido")]
        public List<HistoricoClienteProdutoUseCaseResponse> ItensPedido { get; set; }
    }

    public class HistoricoClienteProdutoUseCaseResponse
    {
        [JsonProperty("NomeProduto")]
        public string NomeProduto { get; set; }

        [JsonProperty("NomeCategoria")]
        public string NomeCategoria { get; set; }

        [JsonProperty("Valor")]
        public decimal Valor { get; set; }

        [JsonProperty("Observacao")]
        public string Observacao { get; set; }
    }
}