using AutoMapper;
using SelfieBurguer.DataTransfer.Cliente;
using SelfieBurguer.DataTransfer.Pedido;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class ClientesProfile : Profile
    {
        public ClientesProfile()
        {
            //ClienteMap();
            CreateMap<Cliente, ClienteResponse>();
            //CreateMap<IEnumerable<Cliente>, IEnumerable<ClienteResponse>>();

            CreateMap<Pedido, PedidoResponse>();
            //CreateMap<IEnumerable<Pedido>, IEnumerable<PedidoResponse>>();
        }

        //private void ClienteMap()
        //{
        //    CreateMap<Cliente, ClienteResponse>();
        //    CreateMap<IEnumerable<Cliente>, IEnumerable<ClienteResponse>>();
        //}
    }
}