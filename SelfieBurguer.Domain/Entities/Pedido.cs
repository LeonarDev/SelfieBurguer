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

        //public double ValorTotal { get; protected set; }

        //public Pedido(Cliente cliente, IEnumerable<Produto> produtos)
        //{
        //    SetDataCriacao(DateTime.Now);
        //    SetStatus(StatusEnum.Pagamento_Pendente);
        //    SetProdutos(produtos);
        //    SetValorTotal();
        //}

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

        public void SetCliente(Cliente cliente)
        {
            Cliente = cliente;
        }

        //public void SetProdutos(IEnumerable<Produto> produtos)
        //{
        //    foreach (Produto produto in produtos)
        //        Produtos.Add(produto);
        //}

        //public void SetValorTotal()
        //{
        //    ValorTotal = Produtos.Sum(produto => produto.Valor);
        //}
    }
}