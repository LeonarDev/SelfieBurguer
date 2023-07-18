using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Entities;
using SelfieBurguer.Infrastructure.Data;
using SelfieBurguer.Infrastructure.Data.Repositories;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
    {
        private readonly SqlContext _sqlContext;

        public RepositoryUsuario(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}