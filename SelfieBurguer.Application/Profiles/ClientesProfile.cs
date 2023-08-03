using AutoMapper;
using SelfieBurguer.DataTransfer.Cliente;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class ClientesProfile : Profile
    {
        public ClientesProfile()
        {
            CreateMap<Cliente, ClienteResponse>().PreserveReferences(); ;
        }
    }
}