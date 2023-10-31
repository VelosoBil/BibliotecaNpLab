using BibliotecaNpLab.Data;
using BibliotecaNpLab.Repositorios;
using BibliotecaNpLab.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaNpLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<BibliotecaDbContex>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                );

            builder.Services.AddCors(options => {
                options.AddPolicy(name: "policynplb",
                    policy =>
                    {
                        policy.WithOrigins("https://localhost:7059")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });
            
            builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            builder.Services.AddScoped<ILivrosRepositorio, LivrosRepositorio>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("policynplb");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}