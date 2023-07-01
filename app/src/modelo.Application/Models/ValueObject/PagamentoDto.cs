using modelo.Domain.Enums;
using Newtonsoft.Json;

namespace modelo.Application.Models.ValueObject
{
    public class PagamentoDto
    {
        [JsonProperty("tipo")]
        public TipoPagamento Tipo { get; set; }
    }
}
