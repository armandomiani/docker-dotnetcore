## .NET Core API + Ngnix + Docker

#### Tests

.... include some CI testing here.

#### Overview

Bootstrap API for running a .NET Core application on an Nginx Container. Nothing else. 

#### Development 

*For building:*

On Powershell:
```.\app\build\compile.ps1```

On Linux:
```.\app\build\compile.sh```


*For running*
On Powershell:
```.\app\build\start.ps1```

On Linux:
```.\app\build\start.sh```

#### Docker

Running the Local API Container:
```
docker build -t armandomiani/docker-dotnetcore app/
docker run -it -p 6700:80 armandomiani/docker-dotnetcore:latest
```


#### Docker Hub

Running from Docker Hub
```
docker run -it -p 6700:80 armandomiani/docker-dotnetcore:latest
```
