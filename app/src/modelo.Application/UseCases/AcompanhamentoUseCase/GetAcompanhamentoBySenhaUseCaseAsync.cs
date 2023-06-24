using System;
using System.Threading.Tasks;
using modelo.Domain.Gateways;
using modelo.Application.Models.AcompanhamentoModel;
using modelo.Domain.Enums;

namespace modelo.Application.UseCases.AcompanhamentoUseCase
{
    public class GetAcompanhamentoBySenhaUseCaseAsync : IUseCaseAsync<AcompanhamentoRequest, AcompanhamentoResponse>
    {
        private readonly IAcompanhamentoGateway _gateway;

        public GetAcompanhamentoBySenhaUseCaseAsync(IAcompanhamentoGateway gateway)
        {
            _gateway = gateway;
        }

        public async Task<AcompanhamentoResponse> ExecuteAsync(AcompanhamentoRequest request)
        {
            var result = await _gateway.GetBySenhaAsync(request.Senha);

            if (result == null)
                return null;

            return new AcompanhamentoResponse
            {
                Senha = result.Senha,
                Status = Status.GetById(result.Status)
            };
        }
    }
}
