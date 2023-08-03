using System.ComponentModel.DataAnnotations.Schema;

namespace SelfieBurguer.Domain.Entities
{
    [Table("Produto")]
    public class Produto
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public string? Descricao { get; protected set; }
        public string? Observacao { get; protected set; }
        public double Valor { get; protected set; }
        public bool Disponivel { get; protected set; }
        public byte[]? Imagem { get; protected set; }
        public int CategoriaId { get; protected set; }
        public Categoria Categoria { get; protected set; }

        public Produto()
        { }

        public Produto(string nome, string descricao, string observacao, double valor, int categoriaId)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetObservacao(observacao);
            SetValor(valor);
            SetDisponivel(true);
            SetCategoria(categoriaId);
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void SetObservacao(string observacao)
        {
            Observacao = observacao;
        }

        public void SetValor(double valor)
        {
            Valor = valor;
        }

        public void SetDisponivel(bool disponivel)
        {
            Disponivel = disponivel;
        }

        public void SetImagem(byte[] imagem)
        {
            Imagem = imagem;
        }

        public void SetCategoria(int categoriaId)
        {
            CategoriaId = categoriaId;
        }
    }
}