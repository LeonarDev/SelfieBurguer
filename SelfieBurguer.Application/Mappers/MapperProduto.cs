using SelfieBurguer.Application.Dtos.Produto;
using SelfieBurguer.Application.Interfaces.Mappers;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            // Alterar ProdutoDto para seu respectivo ProdutoRequest que será recebido via post
            var Produto = new Produto()
            {
                Id = produtoDto.Id,
                Descricao = produtoDto.Descricao,
                Disponivel = produtoDto.Disponivel,
                Imagem = produtoDto.Imagem,
                Nome = produtoDto.Nome,
                Observacao = produtoDto.Observacao,
                Preco = produtoDto.Preco
            };

            return Produto;
        }

        public IEnumerable<ProdutoDto> MapperEntitiesListToDtosList(IEnumerable<Produto> produtos)
        {
            throw new NotImplementedException();
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
