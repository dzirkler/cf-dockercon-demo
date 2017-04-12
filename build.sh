rm -fr ./DZirkler.Demo.Webservice/bin/out
dotnet restore ./DZirkler.Demo.Webservice
dotnet publish -c Release -o ./bin/out ./DZirkler.Demo.Webservice/DZirkler.Demo.Webservice.csproj
