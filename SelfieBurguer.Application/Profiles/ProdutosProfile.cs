using AutoMapper;
using SelfieBurguer.DataTransfer.Produto;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class ProdutosProfile : Profile
    {
        public ProdutosProfile()
        {
            CreateMap<Produto, ProdutoResponse>();
        }
    }
}