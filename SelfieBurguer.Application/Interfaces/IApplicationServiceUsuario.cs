using SelfieBurguer.Application.Dtos.Usuario;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceUsuario
    {
        void Add(UsuarioDto obj);
        void Update(UsuarioDto obj);
        void Delete(UsuarioDto obj);
        IEnumerable<UsuarioDto> GetAll();
        UsuarioDto GetById(int id);
    }
}
