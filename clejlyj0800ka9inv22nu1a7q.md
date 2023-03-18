---
title: "Asynchronous TCP/IP - Part 2"
datePublished: Sat Feb 25 2023 06:55:38 GMT+0000 (Coordinated Universal Time)
cuid: clejlyj0800ka9inv22nu1a7q
slug: asynchronous-tcpip-part-2
cover: https://cdn.hashnode.com/res/hashnode/image/stock/unsplash/jLwVAUtLOAQ/upload/b8a26cf3bca68dfb9d19aeeda28ddb7b.jpeg
tags: dotnet, dotnetcore, tcp

---

In the last blog post in the series, we created a server and client using the TCP protocol. So to Recap the concepts quickly

TCP programming is **a way of connecting two nodes on a network to communicate with each other.**

TCP Server creates sockets and listens on a computer port. Using child sockets, it can accept connections.

The TCP client, like a server, creates the socket and connects to the server through it.

Now in this blog post, let's send and receive data. I will start by showing a working way and explaining the things that are wrong there, then slowly correcting the same.

## Sending Data from Client

On the open socket, you can only send the data using bytes \[\], and your server and client need to use the same encoding.

```csharp
  var message = Encoding.UTF8.GetBytes("Hello World!!");
  await _clientConnection.SendAsync(message, SocketFlags.None);
```

That's all the client has to do to send the data, and there's a lot wrong with this. Let's discuss this later in the post and corrective action too.

# Receiving data in the server

Now that we have sent the data from the client, we need to receive it on the server.

```csharp
 private static async Task ProcessSocket(Socket connectedSocket) {
   while (true) {
     var buffer = new byte[1024];
     var byterecieved = await connectedSocket.ReceiveAsync(buffer, SocketFlags.None);  // Receives the data
     if (byterecieved == 0) {
       break;
     }
     var message = Encoding.UTF8.GetString(buffer);
     Console.WriteLine($"Message received from client {message}");
   }
 }
```

Well, that's a lot of lines to skim, but the most important one is the ReceiveAsync method, which gets the async data and provides it in bytes.

We can use it to get the message back by converting it to a string.

## Bad code

The above code works, but it does not handle all the edge cases of the TCP protocol. Well, TCP programming is hard, and knowing how to handle buffer management is another hard piece to figure out.

The dotnet team faced a similar program and as part of the Kestral server design they release two open-source projects

* System.IO.Pipelines - This can help in handling the Buffer management
    
* Microsoft.AspNetCore.Connections.Abstractions - This helps in making common Handling of the edge cases in the connection
    

David Fowler (the Asp.net Core architect) has created a project in which he has compiled the best practices for building TCP clients and servers.

You can find the project here. [https://github.com/davidfowl/BedrockFramework](https://github.com/davidfowl/BedrockFramework)

In the coming weeks, we will discuss how to use the system. Io. Pipelines and Connections API to change the project to production quality.