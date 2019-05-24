FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

# arrange contents
RUN mkdir -p /scripts
COPY src/. /app/
COPY build/*.sh /scripts/

# grant execution on scripts
RUN chmod +x /scripts/*.sh

# compile the api 
RUN dotnet publish -c Release -o /dist .


FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app

# get the binaries from the build stage
COPY --from=build-env /dist .

# start the api using Kestrel
ENTRYPOINT ["dotnet", "api.dll"]