FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ipsen5_data_hound/ipsen5_data_hound.csproj", "ipsen5_data_hound/"]
RUN dotnet restore "ipsen5_data_hound/ipsen5_data_hound.csproj"
COPY . .
WORKDIR "/src/ipsen5_data_hound"
RUN dotnet build "ipsen5_data_hound.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "ipsen5_data_hound.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ipsen5_data_hound.dll"]
