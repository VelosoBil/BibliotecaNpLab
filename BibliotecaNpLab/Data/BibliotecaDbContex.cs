using BibliotecaNpLab.Data.Map;
using BibliotecaNpLab.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaNpLab.Data
{
    public class BibliotecaDbContex: DbContext 
    { 

        public BibliotecaDbContex(DbContextOptions<BibliotecaDbContex> options)
            :base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<LivrosModel> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
