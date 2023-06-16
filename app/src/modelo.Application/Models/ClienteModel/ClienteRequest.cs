using Microsoft.AspNetCore.Mvc;

namespace modelo.Application.Models.ClienteModel
{
    public class ClienteRequest
    {
        public ClienteRequest()
        {
            Cpf = string.Empty;
        }

        [FromQuery(Name = "Cpf")]
        public string Cpf { get; set; }
    }
}
