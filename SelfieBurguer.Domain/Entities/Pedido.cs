using SelfieBurguer.Domain.Enums;

namespace SelfieBurguer.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public StatusEnum Status { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public IList<PedidoProduto> PedidoProdutos { get; set; } = new List<PedidoProduto>();
        public double ValorTotal
        {
            get
            {
                return PedidoProdutos.Sum(pedidoProduto => pedidoProduto.Produto.Valor);
            }
        }

        //public double ValorTotal { get; set; }

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