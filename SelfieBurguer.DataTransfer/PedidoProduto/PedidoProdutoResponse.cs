using SelfieBurguer.DataTransfer.Produto;

namespace SelfieBurguer.DataTransfer.Pedido
{
    public class PedidoProdutoResponse
    {
        public int Id { get; set; }
        public ProdutoResponse Produto { get; set; }
    }
}
