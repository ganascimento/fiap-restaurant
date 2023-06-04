cd .\app\src\modelo.Infrastructure\
dotnet ef migrations add Initial -s ..\modelo.API\ -c DBContext
cd .\app\src\modelo.Infrastructure\
dotnet ef database update -s ..\modelo.API\ -c DBContext