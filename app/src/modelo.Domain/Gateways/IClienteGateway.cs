using modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Domain.Gateways
{
    public interface IClienteGateway : IRepositoryGateway<Cliente, Guid>
    {
       
        Cliente GetByNome(string nome);
    }
}
