namespace BibliotecaNpLab.Models
{
    public class LivrosModel
    {
        public int id { get; set; }
        public string nomelivro { get; set; }
        public string genero { get; set; }
        public string autor { get; set; }
        public DateTime datalancamento { get; set; }
        public string biografia { get; set; }
        public string editora { get; set; }

    }
}
