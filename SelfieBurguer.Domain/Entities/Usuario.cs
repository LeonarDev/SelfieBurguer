using SelfieBurguer.Domain.Enums;

namespace SelfieBurguer.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }

        public Usuario(string email, string senha, TipoUsuarioEnum tipoUsuario)
        {
            Email = email;
            Senha = senha;
            TipoUsuario = tipoUsuario;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public void SetSenha(string senha)
        {
            Senha = senha;
        }

        public void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }

        public void SetTipoUsuario(TipoUsuarioEnum tipoUsuario)
        {
            TipoUsuario = tipoUsuario;
        }
    }
}