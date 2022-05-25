FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["AdminDashboard.DotNetCore/AdminDashboard.DotNetCore.csproj", "AdminDashboard.DotNetCore/"]
RUN dotnet restore "Adminashboard.DotNetCore.Free/AdminDashboard.DotNetCore.csproj"
COPY . .
WORKDIR "/src/AdminDashboard.DotNetCore"
RUN dotnet build "AdminDashboard.DotNetCore.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AdminDashboard.DotNetCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdminDashboard.DotNetCore.dll"]
