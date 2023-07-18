using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Entities;
using SelfieBurguer.Infrastructure.Data;
using SelfieBurguer.Infrastructure.Data.Repositories;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryCompra : RepositoryBase<Compra>, IRepositoryCompra
    {
        private readonly SqlContext _sqlContext;

        public RepositoryCompra(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}