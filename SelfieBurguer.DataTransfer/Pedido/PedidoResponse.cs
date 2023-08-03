using SelfieBurguer.DataTransfer.Cliente;

namespace SelfieBurguer.DataTransfer.Pedido
{
    public class PedidoResponse
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public int Status { get; set; }
        public ClienteResponse Cliente { get; set; }

        public IList<PedidoProdutoResponse> PedidoProdutos { get; set; }
        public double ValorTotal { get; set; }
    }
}
