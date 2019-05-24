FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

RUN mkdir -p /scripts
COPY src/. /app/
COPY build/*.sh /scripts/

RUN chmod +x /scripts/*.sh
ENTRYPOINT [ "tail -f /dev/null" ]
# RUN dotnet publish -c Release -o dist/ /src


# FROM mcr.microsoft.com/dotnet/core/runtime:2.2
# WORKDIR /app
# COPY --from=build-env /app/dist .
# ENTRYPOINT ["dotnet", "api.dll"]