FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

RUN mkdir -p /scripts
COPY src/. /app/
COPY build/*.sh /scripts/

RUN chmod +x /scripts/*.sh

RUN dotnet publish -c Release -o /dist .


FROM microsoft/aspnetcore
WORKDIR /app
COPY --from=build-env /dist .
ENTRYPOINT ["dotnet", "api.dll"]