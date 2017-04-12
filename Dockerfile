FROM microsoft/aspnetcore:1.1.1

COPY nginx.list /etc/apt/sources.list.d/nginx.list

RUN curl http://nginx.org/keys/nginx_signing.key | apt-key add - &&\
    apt-get update &&\
    apt-get install -y nginx

COPY nginx.conf /etc/nginx/nginx.conf

WORKDIR /app 
COPY ./DZirkler.Demo.Webservice/bin/out .
COPY ./startup.sh .

ENV ASPNETCORE_URLS http://+:3000

EXPOSE 80

CMD ["/bin/bash", "-c", "/app/startup.sh"]