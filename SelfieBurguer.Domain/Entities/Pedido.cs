using SelfieBurguer.Domain.Enums;

namespace SelfieBurguer.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public StatusEnum Status { get; set; }
        public Cliente Cliente { get; set; }
        public Compra Compra { get; set; }

        public Pedido(DateTime dataCriacao, StatusEnum status, Cliente cliente, Compra compra)
        {
            SetDataCriacao(dataCriacao);
            SetStatus(status);
            SetCliente(cliente);
            SetCompra(compra);
        }

        public void SetDataCriacao(DateTime dataCriacao)
        {
            DataCriacao = dataCriacao;
        }

        public void SetDataFinalizacao(DateTime dataFinalizacao)
        {
            DataFinalizacao = dataFinalizacao;
        }

        public void SetStatus(StatusEnum status)
        {
            Status = status;
        }

        public void SetCliente(Cliente cliente)
        {
            Cliente = cliente;
        }

        public void SetCompra(Compra compra)
        {
            Compra = compra;
        }
    }
}