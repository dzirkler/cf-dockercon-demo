echo "New Data Line: $(date -R)" >> data.txt

NOW=$(date +'%Y-%m-%dT%H%M%S')
TAGNAME="dzirkler/cf-dockercon-demo-data:$NOW"

docker build -f ./Data.Dockerfile --tag $TAGNAME .
docker push $TAGNAME 
docker push "dzirkler/cf-dockercon-demo-data:latest"


