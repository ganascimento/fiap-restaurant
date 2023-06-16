using System.Threading.Tasks;
using AutoMapper;
using modelo.Application.Models.ClienteModel;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases.ClienteUseCase
{
    public class GetClienteByCPFUseCaseAsync : IUseCaseAsync<ClienteRequest, ClienteResponse>
    {
        private readonly IClienteGateway _clienteGateway;
        private readonly IMapper _mapper;

        public GetClienteByCPFUseCaseAsync(IClienteGateway clienteGateway, IMapper mapper)
        {
            _clienteGateway = clienteGateway;
            _mapper = mapper;
        }

        public async Task<ClienteResponse> ExecuteAsync(ClienteRequest request)
        {
            var result = await _clienteGateway.GetByCPFAsync(request.Cpf);

            if (result == null)
                return null;

            return new ClienteResponse
            {
                Id = result.Id,
                Cpf = result.Cpf,
                Nome = result.Nome
            };
        }
    }
}
