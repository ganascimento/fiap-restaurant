using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using modelo.Application.Models.PedidoModel;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases.PedidoUseCase
{
    public class GetHistoricoClienteUseCaseAsync : IUseCaseIEnumerableAsync<IEnumerable<HistoricoClienteResponse>>
    {
        private readonly IPedidoGateway _gateway;
        private readonly IMapper _mapper;

        public GetHistoricoClienteUseCaseAsync(IPedidoGateway gateway, IMapper mapper)
        {
            _gateway = gateway;
            _mapper = mapper;
        }

        public async Task<IEnumerable<HistoricoClienteResponse>> ExecuteAsync()
        {
            var result = await _gateway.GetPedidosDetalhados();
            return _mapper.Map<IEnumerable<HistoricoClienteResponse>>(result);
        }
    }
}