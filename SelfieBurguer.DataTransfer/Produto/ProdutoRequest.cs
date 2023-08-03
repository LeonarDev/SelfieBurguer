namespace SelfieBurguer.DataTransfer.Produto
{
    public class ProdutoRequest
    {
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Observacao { get; set; }
        public double Valor { get; set; }
        public int CategoriaId { get; set; }
    }
}
