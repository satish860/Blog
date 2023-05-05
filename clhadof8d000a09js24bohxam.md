---
title: "Mastering NextJS 13: Two-Minute Tutorials for Modern Web Developers"
seoTitle: "NextJS 13 Mastery: Quick Modern Web Dev Tutorials"
seoDescription: "Master NextJS 13 through two-minute tutorials, from beginner to advanced. Boost performance, SEO, and loading times. Subscribe now!"
datePublished: Fri May 05 2023 09:53:01 GMT+0000 (Coordinated Universal Time)
cuid: clhadof8d000a09js24bohxam
slug: mastering-nextjs-13-two-minute-tutorials-for-modern-web-developers
cover: https://cdn.hashnode.com/res/hashnode/image/stock/unsplash/rxpThOwuVgE/upload/3569e9f837e46e322fc24dc469403849.jpeg
ogImage: https://cdn.hashnode.com/res/hashnode/image/upload/v1683280358948/c52ce0fc-89c2-4c67-aa9e-6f57e480d770.jpeg
tags: javascript, nextjs

---

Next.js is an open-source web development framework based on React. It offers server-side rendering (SSR), automatic code splitting, static site generation (SSG), built-in TypeScript support, and easy deployment. These features contribute to its popularity for building modern web applications with improved performance, better SEO, and faster loading times.

I personally use Next.js for most of my side projects and thoroughly enjoy the development experience. Therefore, I am offering a crash course.

This series will consist of two-minute reads designed to help you learn the features of NextJS 13, from beginner to advanced levels.

Subscribe to this blog to follow along and learn more about the series.

# Getting started

Next.js simply requires Node.js installation, as it relies on Node.js for its build tools. Prior knowledge of Node.js is not necessary to follow along, as I will guide you through the process step by step, allowing you to gain experience along the way.

You can install Node.js from the following link: [https://nodejs.org/en](https://nodejs.org/en)

The most basic way to get started is to open a command prompt and run the following command:

```bash
npx create-next-app@latest 
```

This will ask some basic questions, like

```bash
What is your project named?  todo-app
Would you like to add TypeScript with this project?  Y/N
Would you like to use ESLint with this project?  Y/N
Would you like to use Tailwind CSS with this project? Y/N
Would you like to use the `src/ directory` with this project? Y/N
Use App Router (recommended)? » No / Yes
Would you like to customize the default import alias? » No / Yes
```

To follow along with the series, simply change the application name to "todo-app" and press enter for all other options.

Consequently, this command will create a folder containing all the default settings, ensuring the application is ready to use.

Open it in your favorite code editor. If you don't have one, then I strongly suggest using [Vscode](https://code.visualstudio.com/).

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1683277708052/2607b17c-afc3-4fd6-9993-219e2a21d064.png align="center")

Well, there are a lot of files, but once you grasp the basics, you'll enjoy working with them and appreciate how much the framework provides by default.

You can run the application by using another simple command.

```bash
npm run dev
```

This should open the browser at the default URL: localhost:3000.

Well, that's 2 minutes. Thanks for your time, and in the next blog post, let's upload the files to GitHub and deploy to production. Believe me, it's as simple as it gets to write a web application. Gradually, we will add API, database, login, and external API calls too.