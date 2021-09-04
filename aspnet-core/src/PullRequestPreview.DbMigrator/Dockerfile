FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/PullRequestPreview.DbMigrator/PullRequestPreview.DbMigrator.csproj", "src/PullRequestPreview.DbMigrator/"]
COPY ["src/PullRequestPreview.Application.Contracts/PullRequestPreview.Application.Contracts.csproj", "src/PullRequestPreview.Application.Contracts/"]
COPY ["src/PullRequestPreview.Domain.Shared/PullRequestPreview.Domain.Shared.csproj", "src/PullRequestPreview.Domain.Shared/"]
COPY ["src/PullRequestPreview.EntityFrameworkCore/PullRequestPreview.EntityFrameworkCore.csproj", "src/PullRequestPreview.EntityFrameworkCore/"]
COPY ["src/PullRequestPreview.Domain/PullRequestPreview.Domain.csproj", "src/PullRequestPreview.Domain/"]
RUN dotnet restore "src/PullRequestPreview.DbMigrator/PullRequestPreview.DbMigrator.csproj"
COPY . .
WORKDIR "/src/src/PullRequestPreview.DbMigrator"
RUN dotnet build "PullRequestPreview.DbMigrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PullRequestPreview.DbMigrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PullRequestPreview.DbMigrator.dll"]