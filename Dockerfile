# Estágio 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copia o arquivo .csproj e restaura as dependências para aproveitar o cache
COPY *.csproj ./
RUN dotnet restore

# Copia o restante dos arquivos do projeto e faz o build
COPY . ./
RUN dotnet publish -c Release -o out

# Estágio 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "EcommerceBackendAPI.dll"]