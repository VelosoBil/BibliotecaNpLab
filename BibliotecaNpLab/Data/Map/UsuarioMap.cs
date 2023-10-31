using BibliotecaNpLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaNpLab.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.endereco).IsRequired().HasMaxLength(100);
            builder.Property(x => x.bairro).IsRequired().HasMaxLength(100);
            builder.Property(x => x.cep).IsRequired().HasMaxLength(30);
            builder.Property(x => x.cidade).IsRequired().HasMaxLength(100);
            builder.Property(x => x.uf).IsRequired().HasMaxLength(2);
            builder.Property(x => x.celular).IsRequired().HasMaxLength(14);
            builder.Property(x => x.numerosocio).IsRequired().HasMaxLength(500);
            builder.Property(x => x.login).IsRequired().HasMaxLength(10);
            builder.Property(x => x.senha).IsRequired().HasMaxLength(20);
            builder.Property(x => x.confirmasenha).IsRequired().HasMaxLength(20);
            builder.Property(x => x.generosfav).IsRequired().HasMaxLength(100);
            builder.Property(x => x.autoresfav).IsRequired().HasMaxLength(100);
            builder.Property(x => x.func).IsRequired();
        }
    }
}
