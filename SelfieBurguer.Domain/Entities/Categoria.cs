namespace SelfieBurguer.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

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
