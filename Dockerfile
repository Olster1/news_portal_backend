# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build

WORKDIR /app

# Copy project files and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the source and build the app
COPY . ./
RUN dotnet publish news-portal.csproj -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview AS runtime

WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/publish .

# Expose the default port (adjust if needed)
EXPOSE 8080

# Start the application
ENTRYPOINT ["dotnet", "news-portal.dll"]