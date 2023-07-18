using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Services
{
    public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
    {
        private readonly IRepositoryUsuario _repositoryUsuario;

        public ServiceUsuario(IRepositoryUsuario repositoryUsuario) : base(repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }
    }
}
