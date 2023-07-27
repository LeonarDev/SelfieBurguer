using SelfieBurguer.DataTransfer.Pedido;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServicePedido
    {
        void Add(PedidoRequest obj);
        void Update(PedidoRequest obj);
        void Delete(PedidoRequest obj);
        IEnumerable<PedidoResponse> GetAll();
        PedidoResponse GetById(int id);
    }
}