using modelo.Domain.Enums;

namespace modelo.Domain.Gateways.External
{
    public interface IPagamentoGateway
    {
        bool ValidatePaiment(TipoPagamento tipo);
    }
}
