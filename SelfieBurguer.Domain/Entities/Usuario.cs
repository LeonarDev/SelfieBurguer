using SelfieBurguer.Domain.Enums;

namespace SelfieBurguer.Domain.Entities
{
    public class Usuario : Base
    {
        public virtual string Email { get; set; }
        public virtual string Senha { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Cpf { get; set; }
        public virtual bool Ativo { get; set; }
        public virtual TipoUsuarioEnum TipoUsuario { get; set; }

        public Usuario() {}

        public Usuario(int id, string email, string senha, string nome, string cpf, TipoUsuarioEnum tipoUsuario)
        {
            Id = id;
            Email = email;
            Senha = senha;
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
        }

        public virtual void SetEmail(string email) => Email = email;

        public virtual void SetSenha(string senha) => Senha = senha;

        public virtual void SetNome(string nome) => Nome = nome;

        public virtual void SetCpf(string cpf) => Cpf = cpf;

        public virtual void SetAtivo(bool ativo) => Ativo = ativo;

        public virtual void SetTipoUsuario(TipoUsuarioEnum tipoUsuario) => TipoUsuario = tipoUsuario;
    }
}
