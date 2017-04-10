FROM alpine:3.5

VOLUME /data_files

COPY ./data.txt /data_files/data.txt

CMD /bin/true