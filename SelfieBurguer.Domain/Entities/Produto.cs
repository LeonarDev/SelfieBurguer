namespace SelfieBurguer.Domain.Entities
{
    public class Produto : Base
    {
        public virtual string? Nome { get; set; }
        public virtual string? Descricao { get; set; }
        public virtual string? Observacao { get; set; }
        public virtual double Preco { get; set; }
        public virtual bool Disponivel { get; set; }
        public virtual byte[] Imagem { get; set; }
        public virtual Categoria Categoria { get; set; }

        protected Produto() { }

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

        public virtual void SetNome(string nome) => Nome = nome;

        public virtual void SetDescricao(string descricao) => Descricao = descricao;

        public virtual void SetObservacao(string observacao) => Observacao = observacao;

        public virtual void SetPreco(double preco) => Preco = preco;

        public virtual void SetDisponivel(bool disponivel) => Disponivel = disponivel;

        public virtual void SetImagem(byte[] imagem) => Imagem = imagem;

        public virtual void SetCategoria(Categoria categoria) => Categoria = categoria;
    }
}
