using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Services
{
    public class ServicePedido : ServiceBase<Pedido>, IServicePedido
    {
        private readonly IRepositoryPedido _repositoryPedido;

        public ServicePedido(IRepositoryPedido repositoryPedido) : base(repositoryPedido)
        {
            _repositoryPedido = repositoryPedido;
        }
    }
}
