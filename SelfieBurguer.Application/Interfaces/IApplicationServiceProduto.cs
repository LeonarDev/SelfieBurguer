using SelfieBurguer.DataTransfer.Produto;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoRequest obj);
        void Update(ProdutoRequest obj);
        void Delete(ProdutoRequest obj);
        IEnumerable<ProdutoResponse> GetAll();
        ProdutoResponse GetById(int id);
    }
}