using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Domain.Entities;
using modelo.Application.Models.ClienteModel;

namespace modelo.Application.UseCases.ClienteUseCase
{
    public class PostClienteUseCaseAsync : IUseCaseAsync<ClientePostRequest>
    {
        private readonly IClienteGateway clienteGateway;
        private readonly IMapper mapper;


        public PostClienteUseCaseAsync(IClienteGateway clienteGateway, IMapper mapper)
        {
            this.clienteGateway = clienteGateway;
            this.mapper = mapper;

        }

        public async Task ExecuteAsync(ClientePostRequest request)
        {
            var insert = mapper.Map<ClientePostRequest, Cliente>(request);

            clienteGateway.Insert(insert);
        }
    }
}
