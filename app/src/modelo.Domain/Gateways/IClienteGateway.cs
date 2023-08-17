using modelo.Domain.Entities;
using modelo.Domain.ValueObjects;
using System;
using System.Threading.Tasks;

namespace modelo.Domain.Gateways
{
    public interface IClienteGateway : IRepositoryGateway<Cliente, Guid>
    {
        Task<Cliente> GetByCPFAsync(Cpf cpf);
    }
}
