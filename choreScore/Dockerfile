FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app
EXPOSE 80/tcp

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["chore_score.csproj", "./"]
RUN dotnet restore "chore_score.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "chore_score.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "chore_score.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "chore_score.dll"]
