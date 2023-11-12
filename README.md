# BibliotecaNpLab
#API criado do zero na opção Api web do net core.
#Faça o clone do git antes de começar a instalar as dependências feito isso instalar as dependências citadas abaixo.
#Versões utilizada Visual studio 2022, sql server 2022, entity framework 6.0, entity sql server 6.0,entity design 6.0.0, entity tools 6.0.
#Para construir a API do Backend foi utilizado Entity Framework, banco de dados sql server, Migrations, Swagger para testar os EndPoints.
#Altere a connectionstring no arquivo appsettings alterando o nome do seu banco, usuário e senha do sql server.
#Acesse menu exibir=>outras janelas e escolha a opção Console do gerenciador de pacotes vai abrir um console na parte inferior da IDE digite o seguinte comando:
#Add-Migration Livros -Context BibliotecaDbContex de enter se tudo estiver correto ele vai criar as migrations do banco de dados.
#Em seguida o comando para criar as tabelas : Update-Database -Context BibliotecaDbContex e de enter pronto seu back esta pronto para ser consumido pelo front.
#Alterar politica de segurança para o host que for utilizar só é permitido back e front no mesmo host, no arquivo program.cs apenas um exemplo de como injetar politica de segurança no sistema.
#Api pronta dúvidas estou a disposição de como foi montado toda a web api usando netcore 6.0 foi organizado ao maximo para que os devs entendam com facilidade o fluxo
