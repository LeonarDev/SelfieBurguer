using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace SelfieBurguer.Domain.Entities
{
    [Table("Cliente")]
    public class Cliente
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Sobrenome { get; protected set; }
        public string Email { get; protected set; }
        public string Cpf { get; protected set; }
        public bool Ativo { get; protected set; }
        public DateTime DataCadastro { get; protected set; }
        public IEnumerable<Pedido> Pedidos { get; protected set; } = new List<Pedido>();

        public Cliente(string nome, string sobrenome, string email, string cpf)
        {
            SetNome(nome);
            SetSobrenome(sobrenome);
            SetEmail(email);
            SetCpf(cpf);
            SetAtivo(true);
            SetDataCadastro(DateTime.Now);
        }

        public void SetNome(string nome)
        {
            if (nome.Trim().Length < 3)
                throw new Exception("O nome deve conter ao menos 3 caracteres");

            Nome = nome;
        }

        public void SetSobrenome(string sobrenome)
        {
            if (sobrenome.Trim().Length < 3)
                throw new Exception("O sobrenome deve conter ao menos 3 caracteres");

            Sobrenome = sobrenome;
        }

        public void SetEmail(string email)
        {
            Regex emailValidation = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = emailValidation.Match(email);

            if (!match.Success)
                throw new Exception("O email digitado não é válido");

            Email = email;
        }

        public void SetCpf(string cpf)
        {
            if (cpf.Trim().Length != 11)
                throw new Exception("O Cpf é inválido");

            Cpf = cpf;
        }

        public void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }

        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }
    }
}