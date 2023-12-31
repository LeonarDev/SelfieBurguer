﻿using Microsoft.EntityFrameworkCore;
using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Entities;
using SelfieBurguer.Infrastructure.Data;
using SelfieBurguer.Infrastructure.Data.Repositories;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryPedido : RepositoryBase<Pedido>, IRepositoryPedido
    {
        private readonly SqlContext _sqlContext;

        public RepositoryPedido(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public IEnumerable<Pedido> Listar()
        {
            return _sqlContext.Set<Pedido>()
                .Include(p => p.PedidoProdutos)
                .ThenInclude(pp => pp.Produto).ToList();
        }
    }
}