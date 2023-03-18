---
title: "Digital Ocean Spaces"
seoTitle: "Digital Ocean Spaces with Dotnet"
seoDescription: "Digital ocean, Dotnet"
datePublished: Fri Feb 24 2023 03:43:34 GMT+0000 (Coordinated Universal Time)
cuid: clehzno5h000009ii5qtgd0w9
slug: digital-ocean-spaces
cover: https://cdn.hashnode.com/res/hashnode/image/stock/unsplash/tjX_sniNzgQ/upload/ac2cfda375a6af427e0af3d1811777a7.jpeg
tags: digitalocean

---

Digital Ocean is one of the simplest cloud providers compared to AWS, GCP, and Azure. They offer the best prices but have just enough service to build highly scalable applications. So for anyone starting a cloud journey, I highly suggest doing it with Digital Ocean.

So go ahead and use Digital Ocean and learn cloud computing. Here's [a $200 free credit](https://m.do.co/c/6b0b56965a1e) for doing so.

# Digital Ocean Spaces

Digital Ocean spaces are S3-compatible object storage. For most of my side hustle projects, I use Digital Ocean because it provides 250 GB of storage for $5 (400 rs) per month and free CDN on top of it.

In this blog, I will explain how to set up Digital Ocean spaces with CDN enabled and use the Dotnet AWS SDK to upload a file and download the same.

# Spaces Setup

Start by signing up for Digital Ocean using the [$200 free credit](https://m.do.co/c/6b0b56965a1e). Once you are into creative projects,

> A project is a way to organize the resources used in the cloud. It is also a nice way to experiment with multiple resources and clean up once it is done

You will be presented with the following screen

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1674542586117/bc48c291-c47b-4c42-9197-657d80cd440a.png align="center")

Once the project is created select Spaces from the Left-side menu, You should be seeing a similar screen

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1674545036633/73fdf697-1532-4cad-85f5-9745b4fad989.png align="center")

You can click on the create button at the top to create new spaces

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1674547977292/047010ca-b7c2-44a8-b322-666efb5c1fdd.png align="center")

Select the nearby data center, enable the CDN (at no additional cost), and give it a unique name. Then click on "Create Bucket."

You can always use the UI to upload the files, but we will take a turn and use the AWS SDK to upload and download the file in an upcoming blog post