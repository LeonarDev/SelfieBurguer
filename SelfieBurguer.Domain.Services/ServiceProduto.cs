using SelfieBurguer.DataTransfer.Produto;
using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }

        public Produto Instantiate(ProdutoRequest request)
        {
            Produto produto = new(request.Nome, request.Descricao, request.Observacao, request.Valor, request.CategoriaId);

            return produto;
        }

        public IEnumerable<Produto> GetByCategoria(string categoria)
        {
            return _repositoryProduto.GetByCategoria(categoria);
        }
    }
}