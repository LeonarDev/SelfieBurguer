namespace SelfieBurguer.DataTransfer.Usuario
{
    public class UsuarioResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public int TipoUsuario { get; set; }
    }
}
