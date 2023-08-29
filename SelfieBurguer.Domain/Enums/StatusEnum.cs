using System.ComponentModel;

namespace SelfieBurguer.Domain.Enums
{
    public enum StatusEnum
    {
        [Description("Pagamento Pendente")]
        Pagamento_Pendente = 1,

        [Description("Processando Pagamento")]
        Processando_Pagamento = 2,

        [Description("Recebido")]
        Recebido = 3,

        [Description("Em Preparação")]
        Em_Preparacao = 4,

        [Description("Pronto")]
        Pronto = 5,

        [Description("Finalizado")]
        Finalizado = 6,

        [Description("Cancelado")]
        Cancelado = 7,
    }
}