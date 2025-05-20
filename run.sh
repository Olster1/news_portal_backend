docker run -it --rm \
  -v ${PWD}:/app \
  -w /app \
  -p 5001:5000 \
  mcr.microsoft.com/dotnet/sdk:9.0-preview \
  dotnet run --urls=http://0.0.0.0:5000