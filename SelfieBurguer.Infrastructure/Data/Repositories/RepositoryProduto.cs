using Microsoft.EntityFrameworkCore;
using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Entities;
using SelfieBurguer.Infrastructure.Data;
using SelfieBurguer.Infrastructure.Data.Repositories;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext _sqlContext;

        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public IEnumerable<Produto> RecuperarPorCategoria(string categoria)
        {
            return _sqlContext.Set<Produto>()
                .Where(c => c.Categoria.Nome.ToUpper() == categoria.ToUpper())
                .Include(p => p.Categoria);
        }
    }
}