namespace SelfieBurguer.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        IEnumerable<TEntity> RecuperarTodos();
        TEntity RecuperarPorId(int id);
    }
}
