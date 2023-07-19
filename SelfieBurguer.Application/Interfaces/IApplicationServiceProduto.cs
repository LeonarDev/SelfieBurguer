using SelfieBurguer.Application.Dtos.Produto;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto obj);
        void Update(ProdutoDto obj);
        void Delete(ProdutoDto obj);
        IEnumerable<ProdutoDto> GetAll();
        ProdutoDto GetById(int id);
    }
}
