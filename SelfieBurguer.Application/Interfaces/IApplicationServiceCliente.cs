using SelfieBurguer.DataTransfer.Cliente;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteRequest obj);
        void Update(int id, ClienteRequest obj);
        void Delete(int id);
        IEnumerable<ClienteResponse> GetAll();
        ClienteResponse GetById(int id);
        ClienteResponse GetByEmail(string email);
    }
}
