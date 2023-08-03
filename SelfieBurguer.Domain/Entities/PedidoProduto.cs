using System.ComponentModel.DataAnnotations.Schema;

namespace SelfieBurguer.Domain.Entities
{
    [Table("PedidoProduto")]
    public class PedidoProduto
    {
        public int Id { get; protected set; }
        public int PedidoId { get; protected set; }
        public Pedido Pedido { get; protected set; }
        public int ProdutoId { get; protected set; }
        public Produto Produto { get; protected set; }
    }
}