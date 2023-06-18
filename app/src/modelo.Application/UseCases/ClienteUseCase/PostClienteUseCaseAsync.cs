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

        public PostClienteUseCaseAsync(IClienteGateway clienteGateway, IMapper mapper)
        {
            _clienteGateway = clienteGateway;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(ClientePostRequest request)
        {
            var insert = _mapper.Map<ClientePostRequest, Cliente>(request);
            var checkCliente = await _clienteGateway.GetByCPFAsync(insert.Cpf);
            insert.CheckClienteAlreadyExists(checkCliente);

            await _clienteGateway.InsertAsync(insert);
        }
    }
}
