using System;
using modelo.Domain.Enums;
using Newtonsoft.Json;

namespace modelo.Application.Models.AcompanhamentoModel
{
    public class AcompanhamentoResponse
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("Senha")]
        public int Senha { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }
    }
}
