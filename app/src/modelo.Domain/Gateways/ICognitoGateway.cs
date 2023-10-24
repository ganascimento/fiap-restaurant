using System.Threading.Tasks;
using modelo.Domain.Entities;

namespace modelo.Domain.Gateways
{
    public interface ICognitoGateway
    {
        Task<string> CreateUser(Cliente cliente);
    }
}