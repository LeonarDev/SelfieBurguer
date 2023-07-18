namespace SelfieBurguer.Domain.Entities
{
    public class Cliente : Base
    {
        public virtual Usuario Usuario { get; set; }

        protected Cliente() { }

        public Cliente(Usuario usuario)
        {
            SetUsuario(usuario);
        }

        public virtual void SetUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }
    }
}
