using AutoMapper;
using SelfieBurguer.Application.Interfaces;
using SelfieBurguer.DataTransfer.Cliente;
using SelfieBurguer.DataTransfer.Pedido;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;
using SelfieBurguer.Domain.Enums;

namespace SelfieBurguer.Application
{
    public class ApplicationServicePedido : IApplicationServicePedido
    {
        private readonly IServicePedido _servicePedido;
        private readonly IMapper _mapper;

        public ApplicationServicePedido(IServicePedido servicePedido, IMapper mapper)
        {
            _servicePedido = servicePedido;
            _mapper = mapper;
        }

        public void Add(PedidoRequest request)
        {
            Pedido pedido = _servicePedido.Instanciar(request);

            _servicePedido.Add(pedido);
            
            _servicePedido.AdicionarProdutos(pedido, request.ProdutosIds);
        }

        public void AlterarStatus(int id, PedidoRequest request)
        {
            _servicePedido.AlterarStatus(id, request);
        }

        public PedidoResponse RecuperarPorId(int id)
        {
            Pedido pedido = _servicePedido.RecuperarPorId(id);
            return _mapper.Map<PedidoResponse>(pedido);
        }

        public IEnumerable<PedidoResponse> Listar()
        {
            IEnumerable<Pedido> pedidos = _servicePedido.Listar();
            return _mapper.Map<IEnumerable<PedidoResponse>>(pedidos);
        }

        //public void Add(PedidoRequest request)
        //{
        //    Pedido pedido = _servicePedido.Instantiate(request);

        //    _servicePedido.Add(pedido);
        //}

        //public void Update(int id, PedidoRequest request)
        //{
        //    Pedido pedido = _servicePedido.RecuperarPorId(id);

        //    pedido.SetNome(request.Nome);
        //    pedido.SetDescricao(request.Descricao);
        //    pedido.SetObservacao(request.Observacao);
        //    pedido.SetValor(request.Valor);
        //    pedido.SetCategoria(request.CategoriaId);

        //    _servicePedido.Update(pedido);
        //}

        //public void Delete(int id)
        //{
        //    Pedido pedido = _servicePedido.RecuperarPorId(id);
        //    _servicePedido.Delete(pedido);
        //}

        //public PedidoResponse RecuperarPorId(int id)
        //{
        //    Pedido pedido = _servicePedido.RecuperarPorId(id);
        //    return _mapper.Map<PedidoResponse>(pedido);
        //}

        //public IEnumerable<PedidoResponse> RecuperarPorCategoria(string categoria)
        //{
        //    IEnumerable<Pedido> pedidos = _servicePedido.RecuperarPorCategoria(categoria);
        //    return _mapper.Map<IEnumerable<PedidoResponse>>(pedidos);

        //}
    }
}