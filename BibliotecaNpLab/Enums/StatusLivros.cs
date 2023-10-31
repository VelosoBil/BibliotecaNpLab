using System.ComponentModel;

namespace BibliotecaNpLab.Enums
{
    public enum StatusLivros
    {
        [Description("Disponivel")]
        Disponivel = 1,

        [Description("Emprestado")]
        Emprestado = 2,

        [Description("Devolvido")]
        Devolvido = 3
    }
}
