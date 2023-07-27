using AutoMapper;
using SelfieBurguer.Application.Interfaces;
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
            var cliente = _mapper.Map<Produto>(request);
            _serviceProduto.Add(cliente);
        }

        public void Update(ProdutoRequest request)
        {
            var cliente = _mapper.Map<Produto>(request);
            _serviceProduto.Update(cliente);
        }

        public void Delete(ProdutoRequest request)
        {
            var cliente = _mapper.Map<Produto>(request);
            _serviceProduto.Delete(cliente);
        }

        public IEnumerable<ProdutoResponse> GetAll()
        {
            IEnumerable<Produto> clientes = _serviceProduto.GetAll();
            return _mapper.Map<IEnumerable<ProdutoResponse>>(clientes);
        }

        public ProdutoResponse GetById(int id)
        {
            Produto cliente = _serviceProduto.GetById(id);
            return _mapper.Map<ProdutoResponse>(cliente);
        }
    }
}