#!/bin/bash 

dotnet restore ./DZirkler.Demo.Webservice.Tests
dotnet test ./DZirkler.Demo.Webservice.Tests/DZirkler.Demo.Webservice.Tests.csproj
