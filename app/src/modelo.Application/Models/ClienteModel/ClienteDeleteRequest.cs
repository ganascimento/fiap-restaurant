using Microsoft.AspNetCore.Mvc;
using System;

namespace modelo.Application.Models.ClienteModel
{
    public class ClienteDeleteRequest
    {
        public ClienteDeleteRequest()
        {
            Id = Guid.Empty;
        }

        [FromRoute]
        public Guid Id { get; set; }
    }
}
