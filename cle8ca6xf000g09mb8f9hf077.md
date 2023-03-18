---
title: "Performance - Latency and Throughput"
seoTitle: "Latency and Throughput"
seoDescription: "Performance,Latency,Throughput"
datePublished: Fri Feb 17 2023 09:39:19 GMT+0000 (Coordinated Universal Time)
cuid: cle8ca6xf000g09mb8f9hf077
slug: performance-latency-and-throughput
tags: performance, computer-science, dotnet, dotnetcore

---

Performance improvement is one of the Key areas in computer science and in a series of smaller posts I will like to explain the various terms used and methods available to improve the performance of the system

In this blog post, let's talk about latency and throughput.

## Latency:

Let's say you need to get to work. That's with your car. If it takes you an hour to go to work, your latency will be one hour. You care about how soon you can get to work, so you'll judge the system's performance by this criteria.

![](https://drek4537l1klr.cloudfront.net/bobrov/v-10/Figures/01image005.png align="left")

> Latency is a measurement of how long your program takes to run a task.

One way to improve the performance of the system is by reducing the time taken to run the program.

Example:

1. What would happen if pictures were sent from a server in the United States to someone in India? You could require more time than that. CDNs quicken their pace (CDN). We place Hops close to the end user to cut down on latency.
    
2. Improving the latency of a system means tweaking a function or piece of code to make it run faster.
    

## Throughput

We can use the same program to accomplish the same thing, but this time with a thousand people instead of one. We can use the bus instead of the car

![](https://drek4537l1klr.cloudfront.net/bobrov/v-10/Figures/01image006.png align="left")

> Throughput is a measurement of how many tasks a system can handle over the same time

By making the best use of CPU parts like cores, threads, and processes, throughput can be greatly increased.

Example:

1. Using the computers' I/O thread to avoid having to wait for calls. We can use the time we would have spent waiting for external calls to finish running other processes.
    

So, in short, if you want the system to work better, you need to make the code run faster: Latency Adding more tasks that the system can handle at once: Throughput