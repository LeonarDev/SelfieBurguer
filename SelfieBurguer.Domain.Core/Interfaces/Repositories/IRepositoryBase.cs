namespace SelfieBurguer.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        IEnumerable<TEntity> RecuperarTodos();
        TEntity RecuperarPorId(int id);
    }
}
