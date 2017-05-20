FROM microsoft/dotnet:1.1.1-sdk AS sdk
WORKDIR /src
COPY . .
RUN /src/build.sh



FROM microsoft/aspnetcore:1.1.1 AS run
WORKDIR /app 
COPY --from=sdk /src/DZirkler.Demo.Webservice/bin/out .
CMD ["dotnet", "/app/DZirkler.Demo.Webservice.dll"]