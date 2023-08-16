FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SelfieBurguer.API/SelfieBurguer.API.csproj", "SelfieBurguer.API/"]
COPY ["SelfieBurguer.Infrastructure/SelfieBurguer.Infrastructure.csproj", "SelfieBurguer.Infrastructure/"]
COPY ["SelfieBurguer.Application/SelfieBurguer.Application.csproj", "SelfieBurguer.Application/"]
COPY ["SelfieBurguer.Domain.Core/SelfieBurguer.Domain.Core.csproj", "SelfieBurguer.Domain.Core/"]
COPY ["SelfieBurguer.DataTransfer/SelfieBurguer.DataTransfer.csproj", "SelfieBurguer.DataTransfer/"]
COPY ["SelfieBurguer.Domain/SelfieBurguer.Domain.csproj", "SelfieBurguer.Domain/"]
COPY ["SelfieBurguer.Domain.Services/SelfieBurguer.Domain.Services.csproj", "SelfieBurguer.Domain.Services/"]
RUN dotnet restore "SelfieBurguer.API/SelfieBurguer.API.csproj"
COPY . .
WORKDIR "/src/SelfieBurguer.API"
RUN dotnet build "SelfieBurguer.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SelfieBurguer.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

COPY cert.pem /usr/local/share/ca-certificates/
RUN update-ca-certificates

ENTRYPOINT ["dotnet", "SelfieBurguer.API.dll"]