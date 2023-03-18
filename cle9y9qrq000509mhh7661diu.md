---
title: "Asynchronous TCP/IP - Part 1"
seoTitle: "Asynchronous TCP/IP using C#"
seoDescription: "Asynchronus C# TCP/IP"
datePublished: Sat Feb 18 2023 12:42:35 GMT+0000 (Coordinated Universal Time)
cuid: cle9y9qrq000509mhh7661diu
slug: asynchronous-tcpip-part-1
cover: https://cdn.hashnode.com/res/hashnode/image/stock/unsplash/5JQAKBU0vG8/upload/765ec271a97b6c47842f8d0424877721.jpeg
tags: dotnet, dotnetcore, tcpip-model

---

This is going to be a series of blog posts to understand how to code our TCP Server and clients in C#

I started using Nats.io, which is a messaging platform and DotNet library called "Alternats." When I saw how well the library worked, I was surprised. I went through the code to see how it works. I was surprised to learn that optimizing the TCP client can improve the system's throughput and latency.

For the most part, zero-copy architecture has become the buzzword for most high-performance architecture. To put this in perspective, you can see the performance of AlterNATS here.

![image](https://user-images.githubusercontent.com/46207/164392256-46d09111-ec70-4cf3-b33d-38dc5d258455.png align="center")

Nats can consume five times as many messages as the original library on the optimized path. Impressive!!

It's well-written code; however, I had to teach myself TCP/IP to use the library. Throughout this series, I will be documenting my findings.

# TCP server

Sockets are the class in C# that abstracts any networking layer, and to make a TCP Server component, you need to do two things.

### Listen Stage

* You need to create a Socket that can be done using the following code
    
    ```csharp
    var listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    ```
    
    * All the TCP connection is stream based, so you send and receive a set of bytes to and from the system.
        
* Next, you need to Bind to the port or open a port for listening. That can be done using
    

```csharp
listenSocket.Bind(new IPEndPoint(IPAddress.Any, 33333));
listenSocket.Listen();
```

You need to understand the port ranges before choosing the ports.

> Ports with numbers 0–1023 are called system or well-known ports;  
> ports with numbers 1024-49151 are called user or registered ports,  
> ports with numbers 49152-65535 are called **dynamic, private or ephemeral ports**

You need a range between 1024-49151 for the programs

### Accept Stage

The third and most important step is to accept connections from the client. This code needs to run forever, so it's usually written in a loop.

```csharp
while (true) 
{
   var connectedSocket = await listenSocket.AcceptAsync();
    // Do processing after this.
}
```

The most important thing to remember When the server accepts the connection, a new child socket is opened. The listening socket is never interrupted, and the new child socket runs on a different thread.

# TCP view

If you run the above code in the console application, a server will be running on port 33333.

How can you verify the same? Tools like TCP View allow you to look at that. You can download the tool at [https://learn.microsoft.com/en-us/sysinternals/downloads/tcpview](https://learn.microsoft.com/en-us/sysinternals/downloads/tcpview)

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1676721954389/ebc10422-8fb2-4998-86a0-f119e690c556.png align="center")

# TCP Client

The TCP client is again a socket that is opened by the client to connect to the TCP server.

```csharp
 var _clientConnection = new Socket(AddressFamily.InterNetwork, 
                                    SocketType.Stream, 
                                     ProtocolType.Tcp);
 await _clientConnection.ConnectAsync("localhost", 33333);
```

The interesting thing about this is that the OS opens a new socket in the range of ephemeral ports 49152–65535. Again, you can look at the client using the TCP view, but this time with a different port.

The source code can be found here.[https://github.com/satish860/TcpChat](https://github.com/satish860/TcpChat)

Well, that's all I have learned in a day. I learned following the video series from Stephan Clearly

%[https://www.youtube.com/live/RJOdB5ly7jk?feature=share] 

I hope to learn more and write more about the same. I will keep coming back and updating the series of posts.