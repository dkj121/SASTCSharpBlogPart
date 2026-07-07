# ASP\.NET Core Docs

安装你的第一套 \.NET 环境

## 一、 引入

\.NET 的传统网络框架是一套庞大且各具特色的技术体系。而在今天，[ASP\.NET](https://asp.net/) Core (\.NET 8\+) 已成为 \.NET 平台进行 Web 开发的绝对核心。它是一个统一的、跨平台的、高性能的现代框架，整合了传统 [MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview) 和 Web API 的模式，并提供了比 [WCF](https://learn.microsoft.com/en-us/dotnet/framework/wcf/whats-wcf) 更轻量、现代化的替代方案。

## 二、 \.NET vs [Spring](https://spring.io/)

事实上，不论选择哪一套框架，一丝不苟，精益求精，永远都是最重要的（本质上，都是通用的毕竟）

|基础语言|C\#（语法现代、简洁，持续创新）|Java（生态庞大，语法稳定、严谨）|
|---|---|---|
|微服务生态|**现代、高效**依托\.NET原生性能和[gRPC](https://grpc.io/docs/what-is-grpc/introduction/)等支持，构建高性能微服务|**全面、成熟**Spring Cloud提供了一套经过大规模生产验证的完整微服务解决方案|
|开发体验|**开箱即用，工具强大**dotnet CLI功能完备，配合Visual Studio提供卓越的开发、调试体验。Minimal API让构建轻量服务更快捷|**生态丰富，高度灵活**Spring Initializr可快速定制项目骨架。IntelliJ IDEA提供强大支持，配置灵活，但存在一定的学习曲线|
|ORM对比|**高效便捷**EF Core（实体框架核心）与LINQ无缝集成，开发效率高|**性能优化出色**Spring Data JPA/Hibernate在某些复杂查询和批量操作上性能更优|
|云原生友好程度|**Azure深度集成**与自家Azure云平台集成顺滑。AOT编译使容器镜像极小，冷启动极快|与[Kubernetes](https://kubernetes.io)（k8s）、[Docker](https://www.docker.com)及 AWS 等各大云厂商配合良好。Spring Native推进了GraalVM原生镜像支持|

~~老生常谈说是。~~

## 三、 ASP\.NET Core web Framework

### 1、 [ASP\.NET](https://learn.microsoft.com/en-us/aspnet/core/blazor/)[ Core Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/)

> For new project development, we recommend [ASP\.NET](https://learn.microsoft.com/en-us/aspnet/core/blazor/)[ Core Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/)\. —— Microsoft
>
>

作为一个全栈的 Web Framework ，属于是微软力挺的现代 Web Framework。

不同于传统前后端分离设计，Blazor 主要采用 Razor 这种标记语法，而Razor 语法由 Razor 标记、C\# 和 HTML 组成。 这也就意味着 Blazor 在技术上能实现 C\# 的前后端大一统，而像这样统一前后端的设计在隔壁 [Qt](https://doc.qt.io/) 尤其是 Qt Quick 中也有所推崇。

横向对比 Next.js 这个基于 Node.js + React 而诞生的全栈框架，Blazor 主要优势集中于与微软生态的深度集成。

~~说人话：大厂做事，就是不留活口~~

### 2、 [ASP\.NET](https://dotnet.microsoft.com/en-us/apps/aspnet/mvc)[ Core MVC](https://dotnet.microsoft.com/en-us/apps/aspnet/mvc)

与 [WinUI 3](https://njupt-sast.feishu.cn/wiki/Zy59wXUnjinmTWkTA49cIyTqnrb) 中的 [Model\-View\-ViewModel（MVVM）](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm) 相似的，[Model\-View\-Controller（MVC）](https://dotnet.microsoft.com/en-us/apps/aspnet/mvc)作为一种设计模式，是处理复杂项目的不二之选。

MVC 充分体现了传统 UI 设计模式，将每一个功能，切割成三个主要的部分 models、views 以及 controllers。正如 Spring Boot 框架中分割成的model、server、repository、controller。根本目的，在于拓展性与彻底解耦，以实现项目的稳定性与安全性。

而现代的 MVC 设计模式更推荐开发者们去使用 ASP\.NET Core Razor Pages，来进行开发。

> 主要为了提高灵活性作者以为。
>
>

### 3、 ASP\.NET Core Single Page Applications \(SPA\) with frontend JavaScript technologies

不同于前两者深度集成 \.NET 框架，这里的 SPA 属于对已有的几个 Single Page Applications （可以说是前端框架）做出的模仿（[Angular](https://angular.dev/)、[React](https://react.dev/)、[Vue](https://vuejs.org/)等），同时又引入了 JavaScript （以及微软自己开发的[TypeScript](https://www.typescriptlang.org/)）来处理交互操作。

## 四、 下一步

在 Azure 上发布你的 WebAPP！

~~TODO：图书馆管理系统~~

---

> 参考网站：
>
> [Choose an ASP\.NET Core web UI](https://learn.microsoft.com/en-us/aspnet/core/tutorials/choose-web-ui?view=aspnetcore-10.0)
>
