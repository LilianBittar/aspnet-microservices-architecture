FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/OcelotApiGw/OcelotApiGw.csproj", "src/OcelotApiGw/"]
RUN dotnet restore "src/OcelotApiGw/OcelotApiGw.csproj"
COPY . .
WORKDIR "/src/src/OcelotApiGw/"
RUN dotnet build "OcelotApiGw.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "OcelotApiGw.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OcelotApiGw.dll"]