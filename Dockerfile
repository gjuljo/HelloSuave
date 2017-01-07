FROM fsharp:latest
RUN apt-get update && apt-get install -y unzip
RUN mkdir -p /app
WORKDIR /app
EXPOSE 8080
COPY deploy/*.zip /app/
RUN unzip *.zip && rm -f *.zip
CMD ["mono", "Hello.exe"]
