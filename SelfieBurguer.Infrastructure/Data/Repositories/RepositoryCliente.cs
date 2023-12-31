﻿using Microsoft.EntityFrameworkCore;
using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Entities;
using SelfieBurguer.Infrastructure.Data;
using SelfieBurguer.Infrastructure.Data.Repositories;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _sqlContext;

        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public Cliente RecuperarPorCpf(string cpf)
        {
            return _sqlContext.Set<Cliente>()
                .Include(c => c.Pedidos)
                .FirstOrDefault(c => c.Cpf == cpf);
        }
    }
}