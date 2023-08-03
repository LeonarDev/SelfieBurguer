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
            Produto produto = _serviceProduto.GetById(id);

            produto.SetNome(request.Nome);
            produto.SetDescricao(request.Descricao);
            produto.SetObservacao(request.Observacao);
            produto.SetValor(request.Valor);
            produto.SetCategoria(request.CategoriaId);

            _serviceProduto.Update(produto);
        }

        public void Delete(int id)
        {
            Produto produto = _serviceProduto.GetById(id);
            _serviceProduto.Delete(produto);
        }

        public IEnumerable<ProdutoResponse> GetAll()
        {
            IEnumerable<Produto> produtos = _serviceProduto.GetAll();
            return _mapper.Map<IEnumerable<ProdutoResponse>>(produtos);
        }

        public ProdutoResponse GetById(int id)
        {
            Produto produto = _serviceProduto.GetById(id);
            return _mapper.Map<ProdutoResponse>(produto);
        }

        public IEnumerable<ProdutoResponse> GetByCategoria(string categoria)
        {
            IEnumerable<Produto> produtos = _serviceProduto.GetByCategoria(categoria);
            return _mapper.Map<IEnumerable<ProdutoResponse>>(produtos);

        }
    }
}