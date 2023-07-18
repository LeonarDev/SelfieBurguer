using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Services
{
    public class ServiceCategoria : ServiceBase<Categoria>, IServiceCategoria
    {
        private readonly IRepositoryCategoria _repositoryCategoria;

        public ServiceCategoria(IRepositoryCategoria repositoryCategoria) : base(repositoryCategoria)
        {
            _repositoryCategoria = repositoryCategoria;
        }
    }
}
