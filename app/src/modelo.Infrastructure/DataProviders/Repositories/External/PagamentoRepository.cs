using modelo.Domain.Enums;
using modelo.Domain.Gateways.External;

namespace modelo.Infrastructure.DataProviders.Repositories.External
{
    internal class PagamentoRepository : IPagamentoGateway
    {
        public bool ValidatePaiment(TipoPagamento tipo)
        {
            switch (tipo)
            {
                case TipoPagamento.Cartao:
                    return false;
                case TipoPagamento.Pix:
                    return true;
                default: return false;
            }
        }
    }
}
