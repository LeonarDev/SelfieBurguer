using SelfieBurguer.DataTransfer.Pedido;

namespace SelfieBurguer.DataTransfer.Cliente
{
    public class ClienteResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public IEnumerable<PedidoResponse> Pedidos { get; set; }
    }
}