using SelfieBurguer.DataTransfer.Pedido;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Core.Interfaces.Services
{
    public interface IServicePedido : IServiceBase<Pedido>
    {
        void AdicionarProdutos(Pedido pedido, int[]? produtosIds);
        void AlterarStatus(int id, PedidoRequest request);
        Pedido Instanciar(PedidoRequest request);
        IEnumerable<Pedido> Listar();
    }
}
