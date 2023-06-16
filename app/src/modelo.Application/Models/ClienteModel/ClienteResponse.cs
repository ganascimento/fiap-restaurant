using Newtonsoft.Json;
using System;

namespace modelo.Application.Models.ClienteModel
{
    public class ClienteResponse
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Cpf")]
        public string Cpf { get; set; }
    }
}
