namespace SelfieBurguer.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Observacao { get; set; }
        public double Preco { get; set; }
        public bool Disponivel { get; set; }
        public byte[] Imagem { get; set; }
        public Categoria Categoria { get; set; }

        public Produto() { }

        public Produto(
            string nome,
            string descricao,
            string observacao,
            double preco,
            byte[] imagem)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetObservacao(observacao);
            SetPreco(preco);
            SetDisponivel(false);
            SetImagem(imagem);
        }

        public Produto(
            string nome,
            string descricao,
            string observacao,
            double preco,
            byte[] imagem,
            Categoria categoria)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetObservacao(observacao);
            SetPreco(preco);
            SetDisponivel(false);
            SetImagem(imagem);
            SetCategoria(categoria);
        }

        public void SetNome(string nome) => Nome = nome;

        public void SetDescricao(string descricao) => Descricao = descricao;

        public void SetObservacao(string observacao) => Observacao = observacao;

        public void SetPreco(double preco) => Preco = preco;

        public void SetDisponivel(bool disponivel) => Disponivel = disponivel;

        public void SetImagem(byte[] imagem) => Imagem = imagem;

        public void SetCategoria(Categoria categoria) => Categoria = categoria;
    }
}
