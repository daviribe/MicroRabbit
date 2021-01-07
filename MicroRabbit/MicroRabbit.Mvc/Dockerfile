#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 5005
EXPOSE 5006

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["MicroRabbit.Mvc/MicroRabbit.Mvc.csproj", "MicroRabbit.Mvc/"]
RUN dotnet restore "MicroRabbit.Mvc/MicroRabbit.Mvc.csproj"
COPY . .
WORKDIR "/src/MicroRabbit.Mvc"
RUN dotnet build "MicroRabbit.Mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroRabbit.Mvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroRabbit.Mvc.dll"]