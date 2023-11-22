FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GerenciadorFluxo.API/GerenciadorFluxo.API.csproj", "GerenciadorFluxo.API/"]
COPY ["GerenciadorFluxo.Application/GerenciadorFluxo.Application.csproj", "GerenciadorFluxo.Application/"]
COPY ["GerenciadorFluxo.Domain/GerenciadorFluxo.Domain.csproj", "GerenciadorFluxo.Domain/"]
COPY ["GerenciadorFluxo.Infra.IoC/GerenciadorFluxo.Infra.IoC.csproj", "GerenciadorFluxo.Infra.IoC/"]
COPY ["GerenciadorFluxo.Infra.Data/GerenciadorFluxo.Infra.Data.csproj", "GerenciadorFluxo.Infra.Data/"]
RUN dotnet restore "GerenciadorFluxo.API/GerenciadorFluxo.API.csproj"
COPY . .
WORKDIR "/src/GerenciadorFluxo.API"
RUN dotnet build "GerenciadorFluxo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GerenciadorFluxo.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GerenciadorFluxo.API.dll"]