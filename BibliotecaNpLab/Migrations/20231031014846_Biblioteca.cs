using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaNpLab.Migrations
{
    public partial class Biblioteca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    biografia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    editora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numerosocio = table.Column<int>(type: "int", maxLength: 500, nullable: false),
                    login = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    senha = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    confirmasenha = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    endereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cep = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    uf = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    celular = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    generosfav = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    autoresfav = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    func = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
