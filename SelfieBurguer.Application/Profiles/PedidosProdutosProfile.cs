using AutoMapper;
using SelfieBurguer.DataTransfer.Pedido;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class PedidosProdutosProfile : Profile
    {
        public PedidosProdutosProfile()
        {
            PedidoMap();
        }

        private void PedidoMap()
        {
            CreateMap<PedidoProduto, PedidoProdutoResponse>();
        }
    }
}