using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modelo.Application.Models.ClienteModel
{
    public class ClienteRequest
    {
        public ClienteRequest()
        {
            CPF = string.Empty;
        }

        [FromQuery(Name = "CPF")]
        public string CPF { get; set; }

    }
}
