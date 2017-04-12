FROM microsoft/dotnet:1.1.1-sdk

COPY . /src
WORKDIR /src 

CMD ["bash", "-c", "./runtests.sh"]
