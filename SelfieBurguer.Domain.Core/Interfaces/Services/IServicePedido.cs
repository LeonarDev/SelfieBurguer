using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Core.Interfaces.Services
{
    public interface IServicePedido : IServiceBase<Pedido>
    {
        IEnumerable<Pedido> Listar();
    }
}
