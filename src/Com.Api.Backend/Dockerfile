FROM microsoft/aspnetcore:2.0.6-stretch AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Com.Api.sln ./
COPY Com.Api.Backend/Com.Api.Backend.csproj Com.Api.Backend/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/Com.Api.Backend
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Com.Api.Backend.dll"]
