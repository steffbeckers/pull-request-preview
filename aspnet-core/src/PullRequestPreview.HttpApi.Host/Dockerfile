FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/PullRequestPreview.HttpApi.Host/PullRequestPreview.HttpApi.Host.csproj", "src/PullRequestPreview.HttpApi.Host/"]
COPY ["src/PullRequestPreview.HttpApi/PullRequestPreview.HttpApi.csproj", "src/PullRequestPreview.HttpApi/"]
COPY ["src/PullRequestPreview.Application.Contracts/PullRequestPreview.Application.Contracts.csproj", "src/PullRequestPreview.Application.Contracts/"]
COPY ["src/PullRequestPreview.Domain.Shared/PullRequestPreview.Domain.Shared.csproj", "src/PullRequestPreview.Domain.Shared/"]
COPY ["src/PullRequestPreview.EntityFrameworkCore/PullRequestPreview.EntityFrameworkCore.csproj", "src/PullRequestPreview.EntityFrameworkCore/"]
COPY ["src/PullRequestPreview.Domain/PullRequestPreview.Domain.csproj", "src/PullRequestPreview.Domain/"]
COPY ["src/PullRequestPreview.Application/PullRequestPreview.Application.csproj", "src/PullRequestPreview.Application/"]
RUN dotnet restore "src/PullRequestPreview.HttpApi.Host/PullRequestPreview.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/PullRequestPreview.HttpApi.Host"
RUN dotnet build "PullRequestPreview.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PullRequestPreview.HttpApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PullRequestPreview.HttpApi.Host.dll"]
