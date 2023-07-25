using SelfieBurguer.Application.Dtos.Produto;
using SelfieBurguer.Application.Interfaces;
using SelfieBurguer.Application.Interfaces.Mappers;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapperProduto _mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            _serviceProduto = serviceProduto;
            _mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDto produtoDto)
        {
            Produto produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Add(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            Produto produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Update(produto);
        }

        public void Delete(ProdutoDto produtoDto)
        {
            Produto produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Delete(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            IEnumerable<Produto> produtos = _serviceProduto.GetAll();
            IEnumerable<ProdutoDto> produtosDto = _mapperProduto.MapperEntitiesListToDtosList(produtos);

            return produtosDto;
        }

        public ProdutoDto GetById(int id)
        {
            Produto produto = _serviceProduto.GetById(id);
            ProdutoDto produtoDto = _mapperProduto.MapperEntityToDto(produto);

            return produtoDto;
        }
    }
}