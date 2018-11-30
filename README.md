# vidibr
crud em .net core, vscode, sql express e sistema operacional linux mint 19 (tara)

1- Para rodar a aplicação, basta editar o arquivo appsettings.json com uma string de conexão válida, a minha está configurada para rodar em localhost (sql local), inserindo apenas um usuário sql válido e uma senha válida já funcionará.

2- Após isso rode o comando "dotnet ef database update" no terminal (ou no prompt de comando do windows) para que a base e as tabelas sejam criadas.

3- Agora é só rodar o comando "dotnet run" no terminal (ou no prompt de comando do windows) para rodar a aplicação web

obs: a aplicação rodará parecida com esse link http://localhost:5000, para acessar o crud, insira o endereço /cliente no final, exemplo (http://localhost:5000/cliente).

É necessário ter o dotnet core instalado na máquina, segue o link para download... https://dotnet.microsoft.com/download.

