using System.ComponentModel;

namespace SelfieBurguer.Domain.Enums
{
    public enum TipoUsuarioEnum
    {
        [Description("Sem Cadastro")]
        Sem_Cadastro = 1,

        [Description("Cliente")]
        Cliente = 2,

        [Description("Administrador")]
        Administrador = 3,
    }
}