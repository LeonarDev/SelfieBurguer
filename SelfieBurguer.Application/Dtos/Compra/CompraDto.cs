namespace SelfieBurguer.Application.Dtos.Compra
{
    public class CompraDto
    {
        public int Id { get; set; }
        public int[] idsProdutos { get; set; }
        public double ValorTotal { get; set; }
    }
}
