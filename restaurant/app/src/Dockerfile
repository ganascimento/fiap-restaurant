#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /source

COPY . .
RUN dotnet restore "./modelo.API/modelo.API.csproj" --disable-parallel
RUN dotnet publish "modelo.API/modelo.API.csproj" -c Release -o /app --no-restore


FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "modelo.API.dll"]