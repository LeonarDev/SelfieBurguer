using SelfieBurguer.DataTransfer.Produto;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoRequest request);

        void Update(int id, ProdutoRequest request);

        void Delete(int id);

        IEnumerable<ProdutoResponse> GetAll();

        ProdutoResponse GetById(int id);
        IEnumerable<ProdutoResponse> GetByCategoria(string categoria);
    }
}