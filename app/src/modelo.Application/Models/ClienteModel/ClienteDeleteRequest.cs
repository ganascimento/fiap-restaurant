using Newtonsoft.Json;
using System;

namespace modelo.Application.Models.ClienteModel
{
    public class ClienteDeleteRequest
    {
        public ClienteDeleteRequest()
        {
            Id = Guid.Empty;
        }

        [JsonProperty("Id")]
        public Guid Id { get; set; }
    }
}
