FROM microsoft/aspnetcore:1.1.1

WORKDIR /app 

COPY ./DZirkler.Demo.Webservice/bin/out .

CMD ["dotnet", "/app/DZirkler.Demo.Webservice.dll"]