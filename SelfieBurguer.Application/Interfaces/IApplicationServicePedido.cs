using SelfieBurguer.Application.Dtos.Pedido;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServicePedido
    {
        void Add(PedidoDto obj);
        void Update(PedidoDto obj);
        void Delete(PedidoDto obj);
        IEnumerable<PedidoDto> GetAll();
        PedidoDto GetById(int id);
    }
}
