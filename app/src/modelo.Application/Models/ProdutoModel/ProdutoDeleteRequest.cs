using Newtonsoft.Json;
using System;

namespace modelo.Application.Models.ProdutoModel
{
    public class ProdutoDeleteRequest
    {
        public ProdutoDeleteRequest()
        {
            Id = Guid.Empty;
        }

        [JsonProperty("Id")]
        public Guid Id { get; set; }
    }
}
