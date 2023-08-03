using SelfieBurguer.DataTransfer.Pedido;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServicePedido
    {
        void Add(PedidoRequest request);
        void AlterarStatus(int id, PedidoRequest request);
        IEnumerable<PedidoResponse> Listar();
        PedidoResponse GetById(int id);
    }
}