using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Application.Models.ClienteModel;
using System.Collections.Generic;

namespace modelo.Application.UseCases.ClienteUseCase
{
    public class DeleteClienteUseCaseAsync : IUseCaseAsync<ClienteDeleteRequest>
    {
        private readonly IClienteGateway _clienteGateway;

        public DeleteClienteUseCaseAsync(IClienteGateway clienteGateway)
        {
            _clienteGateway = clienteGateway;
        }

        public async Task ExecuteAsync(ClienteDeleteRequest request)
        {
            var exists = await _clienteGateway.GetAsync(request.Id);
            if (exists == null)
                throw new KeyNotFoundException("Cliente não encontrado");

            await _clienteGateway.DeleteAsync(request.Id);
        }
    }
}
