using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using modelo.Application.Models.PedidoModel;
using modelo.Domain.Gateways;
using modelo.Domain.Services;

namespace modelo.Application.UseCases.PedidoUseCase
{
    public class GetHistoricoClienteUseCaseAsync : IUseCaseIEnumerableAsync<IEnumerable<HistoricoClienteResponse>>
    {
        private readonly IPedidoGateway _gateway;
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public GetHistoricoClienteUseCaseAsync(
            IPedidoGateway gateway,
            IIdentityService identityService,
            IMapper mapper)
        {
            _gateway = gateway;
            _mapper = mapper;
            _identityService = identityService;
        }

        public async Task<IEnumerable<HistoricoClienteResponse>> ExecuteAsync()
        {
            var userId = _identityService.GetUserId();
            var result = await _gateway.GetHistoricoAsync(userId);

            return _mapper.Map<IEnumerable<HistoricoClienteResponse>>(result);
        }
    }
}