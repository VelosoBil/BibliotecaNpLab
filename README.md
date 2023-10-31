# BibliotecaNpLab
API criado do zero na opção Api web do net core.
Faça o clone do git antes de começar a instalar as dependencias feito isso instalar as dependencias citadas abaixo.
Versões utilizada Visual studio 2022, sql server 2022, entity framework 6.0.0, entity sql server 6.0.0,entity design 6.0.0, entity tools 6.0.0.
Para construir a API do Backend foi utilizado Entity Framework, banco de dados sql server, Migrations, Swagger para testar os EndPoints.
Altere a connectionstring no arquivo appsettings alterando o nome do seu banco, usuario e senha do sql server.
Acesse menu exibir=>outras janelas e escolha a opção Console do gerenciador de pacotes vai abrir um console na parte inferior da IDE digite o seguinte comando:
Add-Migration Livros -Context BibliotecaDbContex de enter se tudo estiver correto ele vai criar as migrations do banco de dados.
Em seguida o comando para criar as tabelas : Update-Database -Context BibliotecaDbContex e de enter pronto seu back esta pronto para ser consumido pelo front.
Alterar politica de segurança para o host que for utilizar so é permitido back e front no mesmo host no arquivo program.cs.

