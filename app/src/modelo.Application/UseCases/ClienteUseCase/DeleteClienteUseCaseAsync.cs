using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Application.Models.ClienteModel;

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
            await _clienteGateway.DeleteAsync(request.Id);
        }
    }
}
