using BibliotecaNpLab.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaNpLab.Data.Map
{
    public class LivroMap : IEntityTypeConfiguration<LivrosModel>
    {
        public void Configure(EntityTypeBuilder<LivrosModel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.nomelivro).IsRequired().HasMaxLength(100);
            builder.Property(x => x.genero).IsRequired().HasMaxLength(40);
            builder.Property(x => x.autor).IsRequired().HasMaxLength(30);
            builder.Property(x => x.datalancamento).IsRequired().HasMaxLength(15);
            builder.Property(x => x.biografia).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.editora).IsRequired().HasMaxLength(50);
        }
    }
}