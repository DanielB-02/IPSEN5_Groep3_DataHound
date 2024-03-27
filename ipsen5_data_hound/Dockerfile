FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ipsen5-data-hound/ipsen5-data-hound.csproj", "ipsen5-data-hound/"]
RUN dotnet restore "ipsen5-data-hound/ipsen5-data-hound.csproj"
COPY . .
WORKDIR "/src/ipsen5-data-hound"
RUN dotnet build "ipsen5-data-hound.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "ipsen5-data-hound.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ipsen5-data-hound.dll"]
