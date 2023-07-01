using modelo.Domain.Entities.Enums;
using Newtonsoft.Json;
using System;

namespace modelo.Application.Models.AcompanhamentoModel
{
    public class AcompanhamentoPutRequest
    {
        public AcompanhamentoPutRequest()
        {
            Status Status;
        }

        [JsonIgnore]
        public Guid Id { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }
    }
}
