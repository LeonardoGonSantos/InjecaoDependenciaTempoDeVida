#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Injecao.Dependencia/Injecao.Dependencia.csproj", "Injecao.Dependencia/"]
RUN dotnet restore "Injecao.Dependencia/Injecao.Dependencia.csproj"
COPY . .
WORKDIR "/src/Injecao.Dependencia"
RUN dotnet build "Injecao.Dependencia.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Injecao.Dependencia.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Injecao.Dependencia.dll"]