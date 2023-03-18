---
title: "Acorn - Bringing Kubernetes to Developers"
seoTitle: "Acorn -Making Kubernetes Easy for Developers"
datePublished: Sat Mar 18 2023 04:12:07 GMT+0000 (Coordinated Universal Time)
cuid: clfdgd4eh000509kz8i7q6l9q
slug: acorn-bringing-kubernetes-to-developers
ogImage: https://cdn.hashnode.com/res/hashnode/image/upload/v1678951165073/0b5c50ac-5c50-46eb-9db3-2d8ff341cb42.jpeg
tags: docker, kubernetes, containers

---

When I initially learned about Kubernetes, I was amazed by its capabilities for developers. I believed I could build my own cloud, but as I got farther into it, I discovered how difficult it is to solve all the challenges and that sometimes there are hundreds of ways to do the same thing.

I need a solution to deploy my application to the cloud, possibly several clouds or edges. Kubernetes can do it, but its complexity scares me.

Well, enter Acorn. Acorn removed the complexity by providing a sane default and requiring me to run the application consistently from my laptop across the cloud.

This blog will demonstrate how Acorn simplifies Kubernetes and gives a uniform way to build, package, and run apps on any Kubernetes runtime.

# Introduction

Let us compare and contrast how to deploy an application using Kubernetes and Acorn to better understand Acorn.

Before you can deploy and make a simple application available for use, you need to know about pods, deployment, and services.

Acorn takes advantage of all of them, but hides the details from developers by hiding behind abstractions.

Here we go to see the difference.

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1678945573850/c088f594-e525-4f17-9d9e-c38fd1fb597a.png align="center")

That's only the beginning; returning to my dream, I should be able to execute the application on my local machine, in the cloud, or anywhere Kubernetes is running.

Awesome, Kubernetes allows you to run the application on any Kubernetes, but there is no standard way to package, store, and run the application. Well, I am aware of Helm, but Helm is simply another Yaml Soup with bells and whistles.

Hence, let us begin by installing Acorn to see how it facilitates application deployment.

# Install

You can install the acorn and Acorn CLI in windows using a package manager called Scoop

```bash
scoop install acorn
```

You can read about other platforms on this [page](https://docs.acorn.io/installation/installing). This command installs Acorn on your local cluster, and it can do it on any cluster too.

![](https://www.acorn.io/wp-content/uploads/2023/03/logo-graphic_03.06.23.png align="left")

You can run the acorn using `acorn run -n numbers .` But what If I want to distribute the application so that It can run anywhere

# Build

You can build the application using the `acorn build -t` [`ghcr.io/user/number`](http://ghcr.io/user/web) `.` This should sound familiar to any docker command users.

It packages the files in the Open Container Interface project and marks them in the registry. In this scenario, I'm using the GitHub container registry (GHCR), but this can be done with any repository or local Docker as well.

# Push

Once you have built the application, You can push the application using

`acorn push ghcr.io/user/number`

This makes your application available to the world with a single command.

# Run

Now you can run the application `acorn run --name my-app` [`ghcr.io/user/number`](http://ghcr.io/user/web)

Conclusion:

If you've used Docker or Docker compose, you'll recognize this workflow. Acorn leverages simplicity to drive a huge change in Kubernetes, and you can learn more about it at [https://www.acorn.io/](https://www.acorn.io/). It is currently in version 0.6, and they have simplified a number of models that were previously difficult to achieve with Kubernetes. I am convinced that the project will be among the best in its field.

I'll be providing a step-by-step tutorial on operating a larger application using Acorn in the coming days, as well as deploying to other cloud providers. I'm going on a fun project. To discover more about my experiences, follow me or subscribe.

# References:

Learn Kubernetes in 30 days of Lunch - [https://www.manning.com/books/learn-kubernetes-in-a-month-of-lunches](https://www.manning.com/books/learn-kubernetes-in-a-month-of-lunches)

Kubernetes in production: [https://www.manning.com/liveprojectseries/kubernetes-in-production-ser](https://www.manning.com/liveprojectseries/kubernetes-in-production-ser)

The Docker I used in the blog post was from the Learn Kubernetes book, which I highly recommend anyone read. Also follow elton stoneman to learn more - [https://twitter.com/EltonStoneman](https://twitter.com/EltonStoneman)

Acorn Twitter : [https://twitter.com/acornlabs](https://twitter.com/acornlabs)

You can join their slack to discuss more about it : [https://acorn-users.slack.com/ssb/redirect](https://acorn-users.slack.com/ssb/redirect)