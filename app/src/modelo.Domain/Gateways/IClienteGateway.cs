using modelo.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace modelo.Domain.Gateways
{
    public interface IClienteGateway : IRepositoryGateway<Cliente, Guid>
    {
        Task<Cliente> GetByCPFAsync(string CPF);
    }
}
