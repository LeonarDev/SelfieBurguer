using SelfieBurguer.DataTransfer.Cliente;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        ClienteResponse Add(ClienteRequest obj);

        void Update(int id, ClienteRequest obj);

        void Delete(int id);

        IEnumerable<ClienteResponse> RecuperarTodos();

        ClienteResponse RecuperarPorId(int id);

        ClienteResponse RecuperarPorCpf(string email);
    }
}