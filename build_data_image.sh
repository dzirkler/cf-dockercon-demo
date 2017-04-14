#!/bin/bash

echo "New Data Line: $(date -R)" >> data.txt

NOW=$(date +'%Y-%m-%dT%H%M%S')
TAGNAME="dzirkler/cf-dockercon-demo-data:$NOW"

docker build -f ./Data.Dockerfile --tag dzirkler/cf-dockercon-demo-data:latest .
docker push dzirkler/cf-dockercon-demo-data:latest

docker tag dzirkler/cf-dockercon-demo-data:latest $TAGNAME 
docker push $TAGNAME 




