using System.Collections.Generic;
using System.Threading.Tasks;
using modelo.Application.Models.PagamentoModel;
using modelo.Domain.Gateways.External;

namespace modelo.Application.UseCases.PagamentoUseCase
{
    public class PutPagamentoUseCaseAsync : IUseCaseAsync<PagamentoPutRequest>
    {
        private readonly IPagamentoGateway _pagamentoGateway;

        public PutPagamentoUseCaseAsync(IPagamentoGateway pagamentoGateway)
        {
            _pagamentoGateway = pagamentoGateway;
        }

        public async Task ExecuteAsync(PagamentoPutRequest request)
        {
            var pagamento = await _pagamentoGateway.GetAsync(request.Id);
            if (pagamento == null)
                throw new KeyNotFoundException("Pagamento não encontrado");
            if (pagamento.Status != Domain.Enums.StatusPagamento.Pendente)
                throw new KeyNotFoundException("Status já informado");

            pagamento.SetStatus(request.Status);
            await _pagamentoGateway.UpdateAsync(pagamento);
        }
    }
}