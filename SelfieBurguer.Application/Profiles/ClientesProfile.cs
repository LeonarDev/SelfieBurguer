using AutoMapper;
using SelfieBurguer.DataTransfer.Cliente;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class ClientesProfile : Profile
    {
        public ClientesProfile()
        {
            ClienteMap();
        }

        private void ClienteMap()
        {
            CreateMap<Cliente, ClienteResponse>();
            CreateMap<IEnumerable<Cliente>, IEnumerable<ClienteResponse>>();
        }
    }
}