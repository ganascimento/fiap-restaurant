using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Domain.Entities;
using modelo.Application.Models.ClienteModel;

namespace modelo.Application.UseCases.ClienteUseCase
{
    public class PostClienteUseCaseAsync : IUseCaseAsync<ClientePostRequest>
    {
        private readonly IClienteGateway _clienteGateway;
        private readonly IMapper _mapper;
        private readonly ICognitoGateway _cognitoGateway;

        public PostClienteUseCaseAsync(IClienteGateway clienteGateway, IMapper mapper, ICognitoGateway cognitoGateway)
        {
            _clienteGateway = clienteGateway;
            _mapper = mapper;
            _cognitoGateway = cognitoGateway;
        }

        public async Task ExecuteAsync(ClientePostRequest request)
        {
            var insert = _mapper.Map<ClientePostRequest, Cliente>(request);
            var checkCliente = await _clienteGateway.GetByCPFAsync(insert.Cpf);
            insert.CheckClienteAlreadyExists(checkCliente);

            var userId = await _cognitoGateway.CreateUser(insert);
            insert.UserId = userId;

            await _clienteGateway.InsertAsync(insert);
        }
    }
}
