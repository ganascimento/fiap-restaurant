using System;
using System.Threading.Tasks;
using modelo.Application.Models.PagamentoModel;
using modelo.Application.Utils;
using modelo.Domain.Gateways.External;

namespace modelo.Application.UseCases.PagamentoUseCase
{
    public class GetPagamentoUseCaseAsync : IUseCaseAsync<PagamentoGetRequest, Tuple<string, Guid>>
    {
        private readonly IPagamentoGateway _pagamentoGateway;

        public GetPagamentoUseCaseAsync(IPagamentoGateway pagamentoGateway)
        {
            _pagamentoGateway = pagamentoGateway;
        }

        public async Task<Tuple<string, Guid>> ExecuteAsync(PagamentoGetRequest request)
        {
            var pagamento = await _pagamentoGateway.GetByPedidoAsync(request.IdPedido);

            return new Tuple<string, Guid>(
                EnumUtil.GetDescriptionFromEnumValue(pagamento.Status),
                pagamento.Id
            );
        }
    }
}