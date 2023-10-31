using BibliotecaNpLab.Enums;

namespace BibliotecaNpLab.Models
{
    public class LivrosModel
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string genero { get; set; }
        public string biografia { get; set; }
        public string editora { get; set; }
        public StatusLivros status { get; set; }
    }
}
