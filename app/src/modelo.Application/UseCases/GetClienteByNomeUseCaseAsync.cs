using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using modelo.Application.Models;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases
{
    public class GetClienteByNomeUseCaseAsync : IUseCaseAsync<ClienteRequest, ClienteResponse>
    {
        private readonly IClienteGateway clienteGateway;
        private readonly IMapper mapper;


        public GetClienteByNomeUseCaseAsync(IClienteGateway clienteGateway, IMapper mapper)
        {
            this.clienteGateway = clienteGateway;
            this.mapper = mapper;

        }

        public  async Task<ClienteResponse> ExecuteAsync(ClienteRequest request)
        {
            var result =  clienteGateway.GetByNome(request.Nome);

            if (result == null)
                return null;

            return new ClienteResponse
            {
                Id = result.Id,
                CPF = result.CPF,
                Nome = result.Nome
            };
        }

       
    }
}
