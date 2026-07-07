# SASTCsharpBlogPart

这里有一份极简的 Blog 的 API 代码~
目前这份 Blog 采用的是 MiniAPI，假如你对其他类型的框架更熟悉的话也可以自行选择简单重构这个项目
至于样例 Bolg 我们在 [blogs](/wwwroot/blogs/) 文件夹中提供了一部分（均为 markdown 格式），你也可以自行上传自己喜欢的内容

## 1、基础要求

- [ ] 在自己的电脑上完成数据库绑定
- [ ] 目前这份 Blog API 仅仅只能实现最基础的 CURD 功能，我们希望你能给他添加评论区功能
- [ ] 为他搭建起一套前端！（允许 vibe coding ~~，但是并不妨碍我们进行批斗~~）

## 2、进阶要求

- [ ] 把数据库部署到云端（neon、Azure DB 均可）
- [ ] 部署这个 Blog（github pages、cloudflare、render 甚至 Azure Web App 均可）
- [ ] 添加一整套用户功能

## 3、开放内容

1. 顺手尽可能美化一下你的前端
2. 添加一些你觉得可能用的到的功能

## 4、项目结构

```txt

SASTCsharpBlogPart
├─📂Endpoints
│ └─BlogItemEndpoints.cs
├─📂Models
│ └─BlogItem.cs
├─📂Properties
│ └─launchSettings.json
├─📂wwwroot
│ └─blogs // 一些 Blog 文件
├─Program.cs
├─appsettings.Development.json
├─appsettings.json
└─SASTCSharpBlogPart.csproj

```
