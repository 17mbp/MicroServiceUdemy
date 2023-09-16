#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ApiGateways/Shopping.Agregator/Shopping.Agregator.csproj", "ApiGateways/Shopping.Agregator/"]
RUN dotnet restore "ApiGateways/Shopping.Agregator/Shopping.Agregator.csproj"
COPY . .
WORKDIR "/src/ApiGateways/Shopping.Agregator"
RUN dotnet build "Shopping.Agregator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Shopping.Agregator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shopping.Agregator.dll"]
