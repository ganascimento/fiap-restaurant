using modelo.Domain.Enums;
using Newtonsoft.Json;

namespace modelo.Application.Models.AcompanhamentoModel
{
    public class AcompanhamentoResponse
    {
        [JsonProperty("Senha")]
        public int Senha { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }
    }
}
