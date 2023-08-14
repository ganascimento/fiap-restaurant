using System.ComponentModel;

namespace modelo.Domain.Enums
{
    public enum StatusPagamento : short
    {
        [Description("Pendente")]
        Pendente,

        [Description("Reprovado")]
        Reprovado,

        [Description("Aprovado")]
        Aprovado
    }
}