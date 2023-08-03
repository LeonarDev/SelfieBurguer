using AutoMapper;
using SelfieBurguer.DataTransfer.Pedido;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class PedidosProfile : Profile
    {
        public PedidosProfile()
        {
            CreateMap<Pedido, PedidoResponse>();

            //CreateMap<Pedido, PedidoResponse>()
            //    .ForMember(dest => dest.PedidoProdutos, opt => opt.Ignore()); // Ignorar a propriedade PedidoProdutos
        }
    }
}