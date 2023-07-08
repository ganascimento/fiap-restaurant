# FIAP-RESTAURANT
---
## Inicializando o projeto
---
### Docker
Inicie os containers acessando a raiz do projeto, e rodando o comando
```PowerShell
docker compose up -d --build
```
---
### Migrations
É preciso que tenha instalado o dotnet-ef para seja possível rodar as migrations.
Para a instalação utilize: 
(para mais informações sobre [Intalação dotnet-ef](https://learn.microsoft.com/en-us/ef/core/cli/dotnet#installing-the-tools))
```PowerShell
dotnet tool install --global dotnet-ef
```


Com os containers em execução, acesse o diretório de Infraestrutura do projeto:
```PowerShell
cd .\app\src\modelo.Infrastructure\
```

Para executar as migrations utilize o comando: 
```PowerShell
dotnet ef database update -s ..\modelo.API\ -c DBContext
```
---
### Utilização dos endpoints

Os endpoints disponíveis podem ser acessados via [swager](http://localhost:5001/swagger/index.html)

Também temos uma [collection do Postman](/postman/fiap-restaurant.postman_collection.json)

<br>

---
## Desenvolvimento
---
### Migrations

Para criar uma nova migration quando tiver alguma modificação no banco:
```PowerShell
cd .\app\src\modelo.Infrastructure\
```
Gerar a migration
```PowerShell
dotnet ef migrations add <NomeDaMigration> -s ..\modelo.API\ -c DBContext
```
Efetivar a alteração no banco de dados
```PowerShell
dotnet ef database update -s ..\modelo.API\ -c DBContext
```