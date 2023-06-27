using AutoMapper;
using modelo.Application.Models.AcompanhamentoModel;
using modelo.Application.Models.ProdutoModel;
using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System.Threading.Tasks;

namespace modelo.Application.UseCases.AcompanhamentoUseCase
{
    public class PutAcompanhamentoUseCaseAsync : IUseCaseAsync<AcompanhamentoPutRequest>
    {
        private readonly IAcompanhamentoGateway _gateway;
        private readonly IMapper _mapper;

        public PutAcompanhamentoUseCaseAsync(IAcompanhamentoGateway gateway, IMapper mapper)
        {
            _gateway = gateway;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(AcompanhamentoPutRequest request)
        {
            var update = _mapper.Map<AcompanhamentoPutRequest, Acompanhamento>(request);
            await _gateway.UpdateAsync(update);
        }
    }
}
