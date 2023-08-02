using SelfieBurguer.DataTransfer.Categoria;

namespace SelfieBurguer.DataTransfer.Produto
{
    public class ProdutoResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Observacao { get; set; }
        public double Valor { get; set; }
        public bool Disponivel { get; set; }
        public byte[] Imagem { get; set; }
        public CategoriaResponse Categoria { get; set; }
    }
}
