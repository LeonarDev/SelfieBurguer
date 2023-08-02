namespace SelfieBurguer.Domain.Entities
{
    public class PedidoProduto
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
