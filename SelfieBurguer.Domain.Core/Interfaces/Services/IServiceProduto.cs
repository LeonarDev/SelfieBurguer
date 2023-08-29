using SelfieBurguer.DataTransfer.Produto;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Core.Interfaces.Services
{
    public interface IServiceProduto : IServiceBase<Produto>
    {
        IEnumerable<Produto> RecuperarPorCategoria(string categoria);
        Produto Instantiate(ProdutoRequest request);
    }
}
