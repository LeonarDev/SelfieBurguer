using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Services
{
    public class ServiceCompra : ServiceBase<Compra>, IServiceCompra
    {
        private readonly IRepositoryCompra _repositoryCompra;

        public ServiceCompra(IRepositoryCompra repositoryCompra) : base(repositoryCompra)
        {
            _repositoryCompra = repositoryCompra;
        }
    }
}
