---
title: "Streamline Your Next.js App Deployment Process with Vercel"
seoTitle: "Optimize Next.js deployment on Vercel"
seoDescription: "Optimize Next.js deployment using Vercel's integration, auto-scaling, global CDN; deploy from local to production swiftly"
datePublished: Sun May 07 2023 03:38:04 GMT+0000 (Coordinated Universal Time)
cuid: clhcv5xeh000508mi9qw8djh3
slug: streamline-your-nextjs-app-deployment-process-with-vercel
cover: https://cdn.hashnode.com/res/hashnode/image/stock/unsplash/zBLtU0zbJcU/upload/e56ebf236747d16d0167bc46a3222720.jpeg
tags: nextjs

---

Streamline your Next.js app deployment process with Vercel, a platform that offers seamless integration, automatic scaling, and global CDN for top performance.

In this article, we'll walk you through the steps to deploy your Next.js app on Vercel, from running it locally to pushing it to GitHub and finally deploying it to Vercel.

> I adhere to the following professional practice to ensure accountability: upon initiating a project, I deploy it to Vercel and share the URL via Twitter, thereby announcing its development.
> 
> I highly recommend adopting a similar approach to build projects and develop them publicly.

Before we build the project and deploy it to Vercel, let's clarify one burning question.

# Why choose Vercel?

Vercel is ideal for Next.js projects due to seamless integration, automatic scaling, fast deployments, and a global CDN for top performance.

As you will see in the blog, it just takes a couple of minutes to go from local to production.

# Run Locally:

To run the Next.js application, simply execute "npm run dev" in the root of the folder.

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1683382747311/b8411415-55df-4a91-adc6-0ac91f0a1477.png align="center")

This simple command builds the application and runs it on localhost:3000. The next step is to push the code to GitHub.

# Push the code to GitHub.

You can create an empty repository on GitHub. Go to your GitHub and select a new repository.

![Screenshot of a GitHub dropdown menu showing options to create new items. The menu item "New repository" is outlined in dark orange.](https://docs.github.com/assets/cb-31554/images/help/repository/repo-create.png align="left")

Now create the repository without initializing any files.

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1683428583219/d5eca1db-e654-4737-9dce-b6b0b2def6c8.png align="center")

Once done, add the repo to your repository by following the instructions given by GitHub.

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1683428656569/e733abc7-de18-4863-9fc5-55a64afdebdb.png align="center")

Now's the time to deploy your application to Vercel.

# Deploy to Vercel

If you haven't signed in to Vercel yet, be sure to do so. It's the Apple of cloud providers, making application deployment easy and offering numerous features. Plus, they have a generous free tier.

> Be aware of the costs after the free tier, as it is definitely premium and has a price similar to Apple products.

After signing in, you'll be prompted to link your Github account. Go ahead and do so.

Now that you have done that, let's start by deploying the application. You only need to select the Github repo that needs to be deployed.

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1683429233863/f886e005-caa0-4530-a883-a69737bc15c5.png align="center")

In our case, select the Todo-Next, which is our github repo and deploy the same.

Once you import it, the application will be automatically deployed to Vercel, and a continuous delivery pipeline will be set up. This way, every time you check in code, it will be deployed to production.

congratulations! your application is deployed to production.

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1683429417354/4d2175a2-17b0-4d81-9e9a-69a76a1d38cf.png align="center")

Well, now that we have set up the application, we will begin with the Todo-Application.

In the upcoming blog post, we will implement login functionality using Clerk and create the UI using ShadCN. Be sure to subscribe to learn more about this series.