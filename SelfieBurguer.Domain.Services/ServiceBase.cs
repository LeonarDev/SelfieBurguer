using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Core.Interfaces.Services;

namespace SelfieBurguer.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public IEnumerable<TEntity> RecuperarTodos()
        {
            return _repository.RecuperarTodos();
        }

        public TEntity RecuperarPorId(int id)
        {
            return _repository.RecuperarPorId(id);
        }

        public void Delete(TEntity obj)
        {
            _repository.Delete(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
    }
}