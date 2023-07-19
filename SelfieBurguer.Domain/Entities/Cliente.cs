namespace SelfieBurguer.Domain.Entities
{
    public class Cliente : Base
    {
        public Usuario Usuario { get; set; }

        public Cliente() { }

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
