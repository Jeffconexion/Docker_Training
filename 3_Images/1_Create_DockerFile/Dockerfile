
# Define base image.
FROM debian:8
LABEL version="1.0" description="Debian/Nginx"

# three Commands to install nginx
RUN apt-get update && apt-get install -y nginx && apt-get clean

# The port that your application listens to.
EXPOSE 80

# path entry point to launch application
ENTRYPOINT [ "/usr/sbin/nginx" ]
# Commands I want to run here.
CMD [ "-g", "daemon off;" ]

#/usr/sbin/nginx -g daemon off;
