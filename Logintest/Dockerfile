#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Logintest/Logintest.csproj", "Logintest/"]
RUN dotnet restore "Logintest/Logintest.csproj"
COPY . .
WORKDIR "/src/Logintest"
RUN dotnet build "Logintest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Logintest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Logintest.dll"]