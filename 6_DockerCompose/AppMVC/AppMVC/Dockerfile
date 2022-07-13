# 1- Definir uma imagem base.
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base

# 2- Definir informações para a imagem.
LABEL version="1.0.1" description="Aplicacao Asp .Net Core"

# 3- Definir a pasta de trabalho (/app)
WORKDIR /app

# 4- Copiar os arquivos da pasta dist para uma pasta no contêiner (/app)
COPY dist /app

# 5- Expor a porta do contêiner e definir em qual porta o servidor vai atender.
EXPOSE 80/tcp

# 6- Definir o local de entrada para aplicação (app.dll que está na pasta dist) .
ENTRYPOINT ["dotnet","AppMVC.dll"]