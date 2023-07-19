namespace SelfieBurguer.Application.Dtos.Produto
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Observacao { get; set; }
        public double Preco { get; set; }
        public bool Disponivel { get; set; }
        public byte[] Imagem { get; set; }
        public int IdCategoria { get; set; }
    }
}
