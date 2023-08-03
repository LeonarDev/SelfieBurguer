namespace SelfieBurguer.DataTransfer.Pedido
{
    public class PedidoRequest
    {
        public int ClienteId { get; set; }
        public int[]? ProdutosIds { get; set; }
        public int? Status { get; set; }
    }
}
