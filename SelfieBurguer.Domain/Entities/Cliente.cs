using System.Text.RegularExpressions;

namespace SelfieBurguer.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public IList<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public Cliente(string nome, string sobrenome, string email)
        {
            SetNome(nome);
            SetSobrenome(sobrenome);
            SetEmail(email);
            SetAtivo(true);
            SetDataCadastro(DateTime.Now);
        }

        public void SetNome(string nome)
        {
            if (nome.Trim().Length < 4) throw new Exception("O nome deve conter ao menos 3 caracteres");

            Nome = nome;
        }

        public void SetSobrenome(string sobrenome)
        {
            if (sobrenome.Trim().Length < 6) throw new Exception("O sobrenome deve conter ao menos 5 caracteres");

            Sobrenome = sobrenome;
        }

        public void SetEmail(string email)
        {
            Regex emailValidation = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = emailValidation.Match(email);

            if (!match.Success) throw new Exception("O email digitado não é válido");

            Email = email;
        }

        public void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }

        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }

        public void SetPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }
    }
}