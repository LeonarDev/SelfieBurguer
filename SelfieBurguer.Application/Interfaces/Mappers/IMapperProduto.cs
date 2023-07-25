using SelfieBurguer.Application.Dtos.Produto;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperEntitiesListToDtosList(IEnumerable<Produto> produtos);

        ProdutoDto MapperEntityToDto(Produto produto);
    }
}