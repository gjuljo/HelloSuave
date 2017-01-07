RUNNING DOCKER MANUALLY
docker build -t gjuljo/hellosuave .
docker run -it --rm -p 9999:8080 gjuljo/hellosuave

USING DOCKER COMPOSE USING THE LOCAL VOLUME 
docker-compose up -d local
docker-compose down -v

docker-compose stop local
docker-compose rm -v -f local

USING DOCKER COMPOSE USING THE IMAGE
docker-compose up -d app
docker-compose down -v

docker-compose stop app
docker-compose rm -v -f app
