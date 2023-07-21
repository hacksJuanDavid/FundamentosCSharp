FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MyFirstAPP/MyFirstAPP.csproj", "MyFirstAPP/"]
RUN dotnet restore "MyFirstAPP/MyFirstAPP.csproj"
COPY . .
WORKDIR "/src/MyFirstAPP"
RUN dotnet build "MyFirstAPP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyFirstAPP.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyFirstAPP.dll"]
