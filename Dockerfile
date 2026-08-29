# Use official Microsoft .NET SDK image to build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["BluelineWebsite.csproj", "."]
RUN dotnet restore "BluelineWebsite.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "BluelineWebsite.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BluelineWebsite.csproj" -c Release -o /app/publish

# Use official ASP.NET runtime image to run
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BluelineWebsite.dll"]