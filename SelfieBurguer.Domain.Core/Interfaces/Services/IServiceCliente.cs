using SelfieBurguer.DataTransfer.Cliente;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Core.Interfaces.Services
{
    public interface IServiceCliente : IServiceBase<Cliente>
    {
        Cliente GetByEmail(string email);
    }
}