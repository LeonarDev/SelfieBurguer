namespace SelfieBurguer.Application.Dtos.Pedido
{
    public class PedidoDto
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataFim { get; set; }
        public string Status { get; set; }
        public string NomeCliente { get; set; }
        public int IdCompra { get; set; }
    }
}
