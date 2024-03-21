FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
USER root
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore
RUN dotnet workload update
RUN dotnet tool install --global dotnet-ef
RUN export PATH="$PATH:/root/.dotnet/tools"
RUN dotnet ef migrations add InitialCreate
RUN dotnet ef database update

COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
USER root
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet" , "BookManagementAPI.dll" ]
