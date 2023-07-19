namespace SelfieBurguer.Application.Dtos.Usuario
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool Ativo { get; set; }
        public string TipoUsuario { get; set; }
    }
}
