﻿namespace BibliotecaNpLab.Models
{
    public class Usuario
    {
        public  int numerosocio { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string celular { get; set; }
        public string generosfav { get; set; }
        public string autoresfav { get; set; }
    }
}
