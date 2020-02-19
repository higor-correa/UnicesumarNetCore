FROM mcr.microsoft.com/dotnet/core/aspnet:3.1.1-bionic AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1.101-bionic AS build
WORKDIR /src
COPY /src/unicesumar-canteen .

WORKDIR "/src/Hbsis.Ambev.Unicesumar.Canteen"
RUN dotnet build "Hbsis.Ambev.Unicesumar.Canteen.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hbsis.Ambev.Unicesumar.Canteen.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hbsis.Ambev.Unicesumar.Canteen.Api.dll"]