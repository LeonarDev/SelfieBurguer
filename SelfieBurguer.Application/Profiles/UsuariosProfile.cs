using AutoMapper;
using SelfieBurguer.DataTransfer.Usuario;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class UsuariosProfile : Profile
    {
        public UsuariosProfile()
        {
            UsuarioMap();
        }

        private void UsuarioMap()
        {
            CreateMap<Usuario, UsuarioResponse>();
            CreateMap<IEnumerable<Usuario>, IEnumerable<UsuarioResponse>>();
        }
    }
}