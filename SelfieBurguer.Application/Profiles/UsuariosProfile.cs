using AutoMapper;
using SelfieBurguer.DataTransfer.Usuario;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class UsuariosProfile : Profile
    {
        public UsuariosProfile()
        {
            CreateMap<Usuario, UsuarioResponse>();

        }
    }
}