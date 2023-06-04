# FIAP-RESTAURANT

## Migration

Criar uma migration quando tiver alguma modificação no banco:

- cd .\app\src\modelo.Infrastructure\
- dotnet ef migrations add Initial -s ..\modelo.API\ -c DBContext

Efetivar alterações no banco:

- cd .\app\src\modelo.Infrastructure\
- dotnet ef database update -s ..\modelo.API\ -c DBContext
