---
title: "Fast Endpoints - An Alternative to Asp.net core"
seoTitle: "FastEndpoints"
seoDescription: "MVC has become the de facto web development tool for DotNet application development. As part of DotNet 6, Microsoft has acquired a minimal API, which gives"
datePublished: Mon Jan 23 2023 02:01:40 GMT+0000 (Coordinated Universal Time)
cuid: cld85xcyb000209mq48rc4i4y
slug: fast-endpoints-an-alternative-to-aspnet-core
canonical: https://fast-endpoints.com/docs/get-started
cover: https://cdn.hashnode.com/res/hashnode/image/stock/unsplash/npxXWgQ33ZQ/upload/a4c07f0b49608fff5fecc6e05dd04748.jpeg
tags: csharp, aspnet-core, dotnetcore

---

MVC has become the de facto web development tool for DotNet application development. As part of DotNet 6, Microsoft has acquired a minimal API, which gives an alternative to the full-featured framework.

Minimal APIs are great in terms of performance and how easy they are to build, but when we need to build complex APIs, we use a full framework instead.

The problem with this plan is that we have to give up performance to build the features we need.

What if I could use the same library to get the best performance and do complicated things? This is when the Fast endpoint comes in.

Performance is on par with minimal APIs. It's faster, uses less memory, and does around [**35k more requests per second**](https://fast-endpoints.com/benchmarks) than an MVC Controller in our benchmarks.

## Getting started with FastEndpoints

Fast endpoints nudge you toward the [**REPR Design Pattern (Request-Endpoint-Response)**](https://deviq.com/design-patterns/repr-design-pattern) for convenient and maintainable endpoint creation with virtually no boilerplate.

Let's start by creating an empty project. You can do this in Visual Studio, but for the blog, I am using the command line for the same thing.

```bash
dotnet new web -n MyWebApp
cd MyWebApp
dotnet add package FastEndpoints
```

Open the project in your favourite editor and change the startup.cs

```csharp
global using FastEndpoints;

var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints();

var app = builder.Build();
app.UseAuthorization();
app.UseFastEndpoints();
app.Run();
```

Now we have added Fastendpoints to the application.

As I told you, the framework uses the REPR—Request endpoint and response pattern to serve an HTTP request. Lets add the classes for request/endpoint and response

Request:

```csharp
public class MyRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}
```

Response:

```csharp
public class MyResponse
{
    public string FullName { get; set; }
    public bool IsOver18 { get; set; }
}
```

Add an Endpoint class.

```csharp
public class MyEndpoint : Endpoint<MyRequest>
{
    public override void Configure()
    {
        Post("/api/user/create");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MyRequest req, 
                                            CancellationToken ct)
    {
        var response = new MyResponse()
        {
            FullName = req.FirstName + " " + req.LastName,
            IsOver18 = req.Age > 18
        };
        await SendAsync(response);
    }
}
```

Now run your app and send a **POST** request to the **/api/user/create** endpoint using a REST client such as [**Postman**](https://www.postman.com/) or [**Insomnia**](https://insomnia.rest/) with the following request body:

```json
{
	"FirstName": "marlon",
	"LastName": "brando",
	"Age": 40
}
```

You should then get a response back such as this:

```json
{
	"FullName": "marlon brando",
	"IsOver18": true
}
```

That's all there is to it.

I want to give a simple introduction to start my blog so most of the introduction is taken from the official documentation but it is just a way to spread the word about the framework