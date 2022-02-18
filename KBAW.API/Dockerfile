FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["KBAW.API/KBAW.API.csproj", "KBAW.API/"]
RUN dotnet restore "KBAW.API/KBAW.API.csproj"
COPY . .
WORKDIR "/src/KBAW.API"
RUN dotnet build "KBAW.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KBAW.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KBAW.API.dll"]
