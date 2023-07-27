using SelfieBurguer.DataTransfer.Usuario;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceUsuario
    {
        void Add(UsuarioRequest obj);
        void Update(UsuarioRequest obj);
        void Delete(UsuarioRequest obj);
        IEnumerable<UsuarioResponse> GetAll();
        UsuarioResponse GetById(int id);
    }
}