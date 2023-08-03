using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryCliente : IRepositoryBase<Cliente>
    {
        Cliente GetByCpf(string cpf);
    }
}
