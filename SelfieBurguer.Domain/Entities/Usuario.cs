using SelfieBurguer.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfieBurguer.Domain.Entities
{
    [Table("Usuario")]
    public class Usuario
    {
        public int Id { get; protected set; }
        public string Email { get; protected set; }
        public string Senha { get; protected set; }
        public bool Ativo { get; protected set; }
        public TipoUsuarioEnum TipoUsuario { get; protected set; }

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