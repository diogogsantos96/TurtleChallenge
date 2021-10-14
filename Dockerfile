FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY Presentation.Console/Presentation.Console.csproj Presentation.Console/
COPY TestFiles/ Presentation.Console/TestFiles
RUN dotnet restore Presentation.Console/Presentation.Console.csproj
COPY . .
WORKDIR /src/Presentation.Console
RUN dotnet build Presentation.Console.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Presentation.Console.csproj -c Release -o /app
COPY TestFiles/ /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Presentation.Console.dll"]
CMD [ "gameSettings1", "moves1" ]