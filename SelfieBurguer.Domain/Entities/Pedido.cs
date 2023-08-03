using SelfieBurguer.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfieBurguer.Domain.Entities
{
    [Table("Pedido")]
    public class Pedido
    {
        public int Id { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
        public DateTime? DataFinalizacao { get; protected set; }
        public StatusEnum Status { get; protected set; }
        public int ClienteId { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public IList<PedidoProduto> PedidoProdutos { get; protected set; } = new List<PedidoProduto>();
        public double ValorTotal
        {
            get
            {
                return PedidoProdutos.Sum(pedidoProduto => pedidoProduto.Produto.Valor);
            }
        }

        public Pedido(int clienteId)
        {
            SetCliente(clienteId);
            SetDataCriacao(DateTime.Now);
            SetStatus(StatusEnum.Pagamento_Pendente);
        }

        public void SetDataCriacao(DateTime dataCriacao)
        {
            DataCriacao = dataCriacao;
        }

        public void SetDataFinalizacao(DateTime dataFinalizacao)
        {
            DataFinalizacao = dataFinalizacao;
        }

        public void SetStatus(StatusEnum status)
        {
            Status = status;
        }

        public void SetCliente(int clienteId)
        {
            ClienteId = clienteId;
        }

        public void SetPedidoProdutos(PedidoProduto pedidoProduto)
        {
            PedidoProdutos.Add(pedidoProduto);
        }
    }
}