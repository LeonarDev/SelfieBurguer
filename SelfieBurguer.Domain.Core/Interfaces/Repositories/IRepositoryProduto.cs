using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryProduto : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> GetByCategoria(string categoria);
    }
}
