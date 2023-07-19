using SelfieBurguer.Application.Dtos.Cliente;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto obj);
        void Update(ClienteDto obj);
        void Delete(ClienteDto obj);
        IEnumerable<ClienteDto> GetAll();
        ClienteDto GetById(int id);
    }
}
