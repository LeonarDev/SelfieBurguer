using System.ComponentModel.DataAnnotations.Schema;

namespace SelfieBurguer.Domain.Entities
{
    [Table("Categoria")]
    public class Categoria
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }

        public Categoria(string nome)
        {
            SetNome(nome);
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }
    }
}