﻿using System.ComponentModel;

namespace SelfieBurguer.Domain.Enums
{
    public enum StatusEnum
    {
        [Description("Pagamento Pendente")]
        Pagamento_Pendente = 1,

        [Description("Processando Pagamento")]
        Processando_Pagamento = 2,

        [Description("Preparando Pedido")]
        Preparando_Pedido = 3,

        [Description("Pedido Finalizado")]
        Pedido_Finalizado = 4,

        [Description("Pedido Entregue")]
        Pedido_Entregue = 5,
    }
}
