using SelfieBurguer.DataTransfer.Produto;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoRequest request);

        void Update(int id, ProdutoRequest request);

        void Delete(int id);

        IEnumerable<ProdutoResponse> RecuperarTodos();

        ProdutoResponse RecuperarPorId(int id);
        IEnumerable<ProdutoResponse> RecuperarPorCategoria(string categoria);
    }
}