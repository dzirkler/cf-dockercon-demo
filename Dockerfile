FROM microsoft/aspnetcore:1.1.1

COPY ./DZirkler.Demo.Webservice/bin/out /app
WORKDIR /app 

EXPOSE 80

ENTRYPOINT ["dotnet", "/app/DZirkler.Demo.Webservice.dll"]
