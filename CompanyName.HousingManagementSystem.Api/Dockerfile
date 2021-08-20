#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY CompanyName.HousingManagementSystem.Api/CompanyName.HousingManagementSystem.Api.csproj CompanyName.HousingManagementSystem.Api/
COPY CompanyName.HousingManagementSystem.Application/CompanyName.HousingManagementSystem.Application.csproj CompanyName.HousingManagementSystem.Application/
COPY CompanyName.HousingManagementSystem.Domain/CompanyName.HousingManagementSystem.Domain.csproj CompanyName.HousingManagementSystem.Domain/
COPY CompanyName.HousingManagementSystem.Identity/CompanyName.HousingManagementSystem.Identity.csproj CompanyName.HousingManagementSystem.Identity/
COPY CompanyName.HousingManagementSystem.Infrastructure/CompanyName.HousingManagementSystem.Infrastructure.csproj CompanyName.HousingManagementSystem.Infrastructure/
COPY CompanyName.HousingManagementSystem.Persistence/CompanyName.HousingManagementSystem.Persistence.csproj CompanyName.HousingManagementSystem.Persistence/
RUN dotnet restore "CompanyName.HousingManagementSystem.Api/CompanyName.HousingManagementSystem.Api.csproj"
COPY . .
WORKDIR "/src/CompanyName.HousingManagementSystem.Api"
RUN dotnet build "CompanyName.HousingManagementSystem.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CompanyName.HousingManagementSystem.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CompanyName.HousingManagementSystem.Api.dll"]
