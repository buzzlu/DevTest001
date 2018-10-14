FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 51511
EXPOSE 44393

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Src/Web/Cylon.Web/Cylon.Web.csproj", "Src/Web/Cylon.Web/"]
RUN dotnet restore "Src/Web/Cylon.Web/Cylon.Web.csproj"
COPY . .
WORKDIR "/src/Src/Web/Cylon.Web"
RUN dotnet build "Cylon.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Cylon.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Cylon.Web.dll"]