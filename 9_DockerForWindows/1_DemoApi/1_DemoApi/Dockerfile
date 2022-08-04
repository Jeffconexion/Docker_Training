#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["1_DemoApi/1_DemoApi.csproj", "1_DemoApi/"]
RUN dotnet restore "1_DemoApi/1_DemoApi.csproj"
COPY . .
WORKDIR "/src/1_DemoApi"
RUN dotnet build "1_DemoApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "1_DemoApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "1_DemoApi.dll"]