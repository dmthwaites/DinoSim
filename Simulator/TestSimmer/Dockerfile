FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TestSimmer/TestSimmer.csproj", "TestSimmer/"]
RUN dotnet restore "TestSimmer/TestSimmer.csproj"
COPY . .
WORKDIR "/src/TestSimmer"
RUN dotnet build "TestSimmer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestSimmer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestSimmer.dll"]
