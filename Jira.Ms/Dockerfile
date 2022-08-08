#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Jira.Ms/Jira.Ms.csproj", "Jira.Ms/"]
RUN dotnet restore "Jira.Ms/Jira.Ms.csproj"
COPY . .
WORKDIR "/src/Jira.Ms"
RUN dotnet build "Jira.Ms.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Jira.Ms.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Jira.Ms.dll"]