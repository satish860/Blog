---
title: "What I Use - My Tech Stack"
seoTitle: "My Tech Stack"
seoDescription: "Dotnet developers tech stack"
datePublished: Sat Mar 11 2023 03:30:39 GMT+0000 (Coordinated Universal Time)
cuid: clf3estwo00m1annv8yy3cerc
slug: what-i-use-my-tech-stack
tags: digitalocean, csharp, dotnetcore, nextjs

---

This was one of the trends on Twitter, and I have learned about a lot of tech stacks related to others. So here is my tech stack and the resources to learn about it.

# UI

I am a backend developer, but I try to keep up with the JavaScript framework to an extent, which is one of the most interesting spaces. So my go to framework is

[NextJS](https://nextjs.org/), [ChakraUI](https://chakra-ui.com/), and [React Query](https://react-query-v3.tanstack.com/): NextJS allows me to structure the Reactjs application cleaner, and ChakraUI brings lots of sensible defaults for CSS. Making an API call and making the state work in the UI is a big challenge, and so far React query has done well on that.

To learn about this stack and build application, You can learn from here

%[https://youtu.be/rCm5RVYKWVg] 

I am trying React Native but am not there yet.

# API

I use Asp.net Core and Asp.net at work. So I often search for a different language or framework to work on my side project.

[Fast Endpoints](https://fast-endpoints.com/): A sleek alternative to Asp.net core It was built on top of Minimal API and provides the fastest alternative.

[HotChoclate](https://chillicream.com/docs/hotchocolate/v13): Hot Chocolate is an open-source GraphQL server for the [Microsoft .NET platform](https://dotnet.microsoft.com/) that is compliant with the newest [GraphQL October 2021 spec + Drafts](https://spec.graphql.org/).

I am learning GraphQL and am really interested in the way you can structure your API. It's a standard that has been around for ten years, but I'm seeing it used more in the JavaScript space than in dotnet. However, dotnet will undoubtedly adopt it as well.

To learn more on GraphQL

%[https://youtu.be/HuN94qNwQmM] 

# Queue/Broker

I have worked with MSMQ, RabbitMQ, Kafka, and Zeromq. To put it simply, I love working in this particular domain of technology.

[Nats.io](https://nats.io/), my current faviourite. NATS is straightforward to learn and can cover scenarios other technologies cannot or are difficult to achieve. Nats can reliably queue and act like Log (Kafka). Nats has built a Key value database on Top of Jetstream engine but the most interesting project is Object store which essential to transmit large files and store for processing.

# Storage

[Digital Ocean Spaces](https://www.digitalocean.com/) and [StorJ](https://www.storj.io/) is my go too tools for Backing large amount of my personal data.

Recently I moved my Google Drive and photos to reduce the space in google. I liked both of them.

# Database

I use Postgres/SQL server in work. Personally I like Postgres but as document database so I use a library to convert Postgres to Document called [marten](https://martendb.io/).

# Edge Computing

I'd like to learn more about edge computing in particular. Languages have cut latency down to the level of microseconds. We can brag about how fast we are in any language.

Nevertheless, if the user is in India and the server is in the US, your code can rarely fix the latency. Hence Google, Amazon, and Netflix maintain caching and compute instances worldwide to serve users' requests close to where they are. What if we did it ourselves? Learning about edge computing is interesting here.

I like [Cloudflare workers](https://workers.cloudflare.com/) and [Fastly Edge](https://www.fastly.com/edge-cloud-network/) but both of them use Javacript and WASI

There is a blog post by **Lee Robinson - VP of Developer Experience Vercel which provides a landscape of tools available to learn** [https://leerob.io/blog/backend](https://leerob.io/blog/backend).

Oh, I forgot about [Vercel](https://vercel.com/) . Edge middleware and functions

I try to stick to this default as much as possible so I can churn out my ideas faster.

If you want to learn more about this technology, you can subscribe to my blog.