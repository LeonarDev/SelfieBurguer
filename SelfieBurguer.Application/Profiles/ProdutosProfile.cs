using AutoMapper;
using SelfieBurguer.DataTransfer.Produto;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class ProdutosProfile : Profile
    {
        public ProdutosProfile()
        {
            ProdutoMap();
        }

        private void ProdutoMap()
        {
            CreateMap<Produto, ProdutoResponse>();
            CreateMap<IEnumerable<Produto>, IEnumerable<ProdutoResponse>>();
        }
    }
}