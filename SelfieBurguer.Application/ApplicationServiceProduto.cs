using AutoMapper;
using SelfieBurguer.Application.Interfaces;
using SelfieBurguer.DataTransfer.Cliente;
using SelfieBurguer.DataTransfer.Produto;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapper _mapper;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapper mapper)
        {
            _serviceProduto = serviceProduto;
            _mapper = mapper;
        }

        public void Add(ProdutoRequest request)
        {
            Produto produto = _serviceProduto.Instantiate(request);

            _serviceProduto.Add(produto);
        }

        public void Update(int id, ProdutoRequest request)
        {
            Produto produto = _serviceProduto.RecuperarPorId(id);

            produto.SetNome(request.Nome);
            produto.SetDescricao(request.Descricao);
            produto.SetObservacao(request.Observacao);
            produto.SetValor(request.Valor);
            produto.SetCategoria(request.CategoriaId);

            _serviceProduto.Update(produto);
        }

        public void Delete(int id)
        {
            Produto produto = _serviceProduto.RecuperarPorId(id);
            _serviceProduto.Delete(produto);
        }

        public IEnumerable<ProdutoResponse> RecuperarTodos()
        {
            IEnumerable<Produto> produtos = _serviceProduto.RecuperarTodos();
            return _mapper.Map<IEnumerable<ProdutoResponse>>(produtos);
        }

        public ProdutoResponse RecuperarPorId(int id)
        {
            Produto produto = _serviceProduto.RecuperarPorId(id);
            return _mapper.Map<ProdutoResponse>(produto);
        }

        public IEnumerable<ProdutoResponse> RecuperarPorCategoria(string categoria)
        {
            IEnumerable<Produto> produtos = _serviceProduto.RecuperarPorCategoria(categoria);
            return _mapper.Map<IEnumerable<ProdutoResponse>>(produtos);

        }
    }
}