# inicio etapa de build 
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# cópia do projeto para o container
WORKDIR /src
COPY . .

# restauração das dependencias e build do projeto
WORKDIR "/src/modelo.API"
RUN dotnet restore "modelo.API.csproj" --disable-parallel
RUN dotnet publish "modelo.API.csproj" -c Release -o /app/publish --no-restore

# inicio da etapa de publicação 
FROM mcr.microsoft.com/dotnet/aspnet:6.0 

# copia a build pronta para o servidor web
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 5001
ENTRYPOINT ["dotnet", "modelo.API.dll"]