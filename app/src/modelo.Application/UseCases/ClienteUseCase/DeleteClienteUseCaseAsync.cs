using System.Threading.Tasks;
using modelo.Domain.Gateways;
using modelo.Application.Models.ClienteModel;
using System.Collections.Generic;

namespace modelo.Application.UseCases.ClienteUseCase
{
    public class DeleteClienteUseCaseAsync : IUseCaseAsync<ClienteDeleteRequest>
    {
        private readonly IClienteGateway _clienteGateway;
        private readonly ICognitoGateway _cognitoGateway;

        public DeleteClienteUseCaseAsync(IClienteGateway clienteGateway, ICognitoGateway cognitoGateway)
        {
            _clienteGateway = clienteGateway;
            _cognitoGateway = cognitoGateway;
        }

        public async Task ExecuteAsync(ClienteDeleteRequest request)
        {
            var exists = await _clienteGateway.GetAsync(request.Id);
            if (exists == null)
                throw new KeyNotFoundException("Cliente não encontrado");

            await _cognitoGateway.DeleteUser(exists.UserId.ToString());
            await _clienteGateway.DeleteAsync(request.Id);
        }
    }
}
