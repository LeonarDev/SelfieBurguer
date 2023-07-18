namespace SelfieBurguer.Domain.Entities
{
    public class Categoria : Base
    {
        public virtual string Nome { get; set; }

        protected Categoria() { }

        public Categoria(string nome)
        {
            SetNome(nome);
        }

        public virtual void SetNome(string nome)
        {
            Nome = nome;
        }
    }
}
