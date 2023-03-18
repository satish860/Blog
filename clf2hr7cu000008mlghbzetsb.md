---
title: "Running NATS as WebSocket Server"
seoTitle: "Nats as WebSocket server"
seoDescription: "NATS is a messaging platform that can connect multiple technologies together and comes to the browser as well."
datePublished: Fri Mar 10 2023 12:05:36 GMT+0000 (Coordinated Universal Time)
cuid: clf2hr7cu000008mlghbzetsb
slug: running-nats-as-websocket-server
tags: message-queue

---

NATS is a messaging platform that can connect multiple technologies together and comes to the browser as well.

Nats comes with WebSocket inbuilt, which can help in designing real-time systems easily. Yes, you don't need any external servers.

You can Start the Nats server with a single command, If you have installed in locally

```bash
nats-server
```

But if you can running in docker mode then you can use

```bash
docker run -d --name nats-main -p 4222:4222 -p 6222:6222 -p 8222:8222 nats
```

Nats server by default comes with WebSocket disabled, so we need to enable it, and as much as you can do it using a command, I prefer using a conf file.

```bash
websocket 
{
    port: 8080
    no_tls: true
}
```

This can be any file with a .conf extension. All we are saying is, "Run web sockets in Port 8080 with NoTLS.

Then change the command line or docker to use the config, below are the examples

### Command Line

```bash
nats-server -c .\nats-server.conf
```

Output will show the Web socket is enabled

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1678449356034/a087ca03-ea04-45b4-8b66-56a740740946.png align="center")

If you using docker then use the following command

```bash
docker run -d --name nats-main -p 4222:4222 -p 6222:6222 -p 8222:8222 nats -c .\nats-server.conf
```

In this blog post I covered a configuration which are for development, If you want to include security and cross cutting concerns then read about the full configuration here

%[https://docs.nats.io/running-a-nats-service/configuration/websocket/websocket_conf] 

Some troubleshooting areas:

* If you've set your browser to block non-secure connections, WS won't work. You'll need a certificate to make it work, which you'll need to change to WSS.