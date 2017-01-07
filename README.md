# HelloSuave
A simple Hello World example in F# using Suave.io
This project uses Paket as dependency manager and FAKE as build automation system.
The web application listens at 8080 and there is a simple example.http file to use with the
REST Client plug-in for Visual Studio Code.

## Using Docker
I also provided a Dockerfile to run the code in a Docker container and a simple docker-compose.yml
file to simplify it's usage.

### RUNNING DOCKER MANUALLY
```
docker build -t gjuljo/hellosuave .
docker run -it --rm -p 9999:8080 gjuljo/hellosuave
```

### USING DOCKER COMPOSE USING THE LOCAL VOLUME 
```
docker-compose up -d local
docker-compose down -v
```
```
docker-compose stop local
docker-compose rm -v -f local
```

### USING DOCKER COMPOSE USING THE IMAGE
```
docker-compose up -d app
docker-compose down -v
```
```
docker-compose stop app
docker-compose rm -v -f app
```

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

