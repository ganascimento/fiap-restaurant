using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using modelo.Application.Models.ClienteModel;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases.ClienteUseCase
{
    public class GetClienteByCPFUseCaseAsync : IUseCaseAsync<ClienteRequest, ClienteResponse>
    {
        private readonly IClienteGateway clienteGateway;
        private readonly IMapper mapper;


        public GetClienteByCPFUseCaseAsync(IClienteGateway clienteGateway, IMapper mapper)
        {
            this.clienteGateway = clienteGateway;
            this.mapper = mapper;

        }

        public async Task<ClienteResponse> ExecuteAsync(ClienteRequest request)
        {
            var result = clienteGateway.GetByCPF(request.CPF);

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
