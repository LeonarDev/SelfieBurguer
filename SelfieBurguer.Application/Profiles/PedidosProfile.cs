using AutoMapper;
using SelfieBurguer.DataTransfer.Pedido;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class PedidosProfile : Profile
    {
        public PedidosProfile()
        {
            //PedidoMap();
            CreateMap<Pedido, PedidoResponse>();
        }

        private void PedidoMap()
        {
            CreateMap<Pedido, PedidoResponse>();
            //CreateMap<IEnumerable<Pedido>, IEnumerable<PedidoResponse>>();
        }
    }
}