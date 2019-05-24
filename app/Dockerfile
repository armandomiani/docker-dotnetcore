FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

RUN mkdir -p /scripts
COPY src/. /app/
COPY build/*.sh /scripts/

RUN chmod +x /scripts/*.sh
RUN /scripts/build.sh

CMD [ "scripts/start.sh" ]