#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["MicroRabbit.Banking.Api/MicroRabbit.Banking.Api.csproj", "MicroRabbit.Banking.Api/"]
RUN dotnet restore "MicroRabbit.Banking.Api/MicroRabbit.Banking.Api.csproj"
COPY . .
WORKDIR "/src/MicroRabbit.Banking.Api"
RUN dotnet build "MicroRabbit.Banking.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroRabbit.Banking.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroRabbit.Banking.Api.dll"]