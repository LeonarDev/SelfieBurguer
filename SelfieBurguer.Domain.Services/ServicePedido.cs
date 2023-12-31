﻿using SelfieBurguer.DataTransfer.Pedido;
using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;
using SelfieBurguer.Domain.Enums;

namespace SelfieBurguer.Domain.Services
{
    public class ServicePedido : ServiceBase<Pedido>, IServicePedido
    {
        private readonly IRepositoryPedido _repositoryPedido;
        private readonly IRepositoryProduto _repositoryProduto;

        public ServicePedido(
            IRepositoryPedido repositoryPedido,
            IRepositoryProduto repositoryProduto) : base(repositoryPedido)
        {
            _repositoryPedido = repositoryPedido;
            _repositoryProduto = repositoryProduto;
        }

        public void AdicionarProdutos(Pedido pedido, int[]? produtosIds)
        {
            if (produtosIds != null && produtosIds.Any())
            {
                foreach (int id in produtosIds)
                {
                    Produto produto = _repositoryProduto.RecuperarPorId(id);

                    PedidoProduto pedidoProduto = new(pedido.Id, produto.Id);

                    pedido.SetPedidoProdutos(pedidoProduto);
                }
            }
        }

        public void AlterarStatus(int id, PedidoRequest request)
        {
            Pedido pedido = _repositoryPedido.RecuperarPorId(id);

            if (request.Status != null)
            {
                StatusEnum status = (StatusEnum)request.Status;

                pedido.SetStatus(status);

                if (status == StatusEnum.Pronto || status == StatusEnum.Finalizado)
                {
                    pedido.SetDataFinalizacao(DateTime.Now);
                }
            }
        }

        public Pedido Instanciar(PedidoRequest request)
        {
            Pedido pedido = new(request.ClienteId);

            return pedido;
        }

        public IEnumerable<Pedido> Listar()
        {
            return _repositoryPedido.Listar();
        }
    }
}