using System.ComponentModel;

namespace SelfieBurguer.Domain.Enums
{
    public enum TipoUsuarioEnum
    {
        [Description("Proponente Sem Cadastro")]
        Proponente_Sem_Cadastro = 1,

        [Description("Cliente Cadastrado")]
        Cliente_Cadastrado = 2,

        [Description("Administrador")]
        Administrador = 3,
    }
}