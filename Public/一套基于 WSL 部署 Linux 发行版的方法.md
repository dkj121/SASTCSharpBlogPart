# 一套基于 WSL 部署 Linux 发行版的方法

这里我们使用 powershell 安装 Ubuntu 来做示范。

## 一、 安装发行版

正如上文提及的我们选择 Ubuntu 作为示范，来完成下面的操作。

### 1、 WSL 配置

* [ ] 首先前往 Windows 系统配置页，打开更多 Windows 功能

![Image](./assets/一套基于%20WSL%20部署%20Linux%20发行版的方法/image.png)

* [ ] 选择启用`适用于 Linux 的 Windows 子系统`

![Image](./assets/一套基于%20WSL%20部署%20Linux%20发行版的方法/image%20(1).png)

### 2、 安装发行版

```PowerShell
wsl --version        # 查看 wsl 版本（至少为wsl2）
wsl --upgrade        # 更新 wsl 至最新发行版
wsl --list --online  # 查看是否存在对于 linux 发行版
wsl --install Ubuntu # 安装 Ubuntu 发行版
正在下载: Ubuntu
正在安装: Ubuntu
已成功安装分发。可以通过 “wsl.exe -d Ubuntu” 启动它
正在启动 Ubuntu...
Provisioning the new WSL instance Ubuntu
This might take a while...
Create a default Unix user account: 7260
Invalid username. A valid username must start with a lowercase letter or underscore, and can contain lowercase letters, digits, underscores, and dashes.
```

正如提示的那样，新建的默认用户必须以字母或者`\_`开头，出现下面字样就是安装好了✅️

```PowerShell
Create a default Unix user account: dkj
New password:
Retype new password:
passwd: password updated successfully
To run a command as administrator (user "root"), use "sudo <command>".
See "man sudo_root" for details.

ACCOUNT@YOURNAME:/mnt/c/Users/USERNAME$
```

如果你使用的是 Windows Terminal 那么打开新建窗口的下拉键，就已经可以看见你的 Ubuntu 了。

![Image](./assets/一套基于%20WSL%20部署%20Linux%20发行版的方法/image%20(2).png)

## 二、 配置 Ubuntu

### 1、 配置 apt mirror

无需多言，前往 [清华源 Ubuntu 软件仓库](https://mirror.tuna.tsinghua.edu.cn/help/ubuntu/) 跟随教程复制粘贴即可。

> Apt 的`sources\.list` 现在已经弃用
>
> 使用 vim 文本编辑器编辑 `ubuntu\.sources` 时注意启用 sudo 权限
>
> 它默认是 readonly
>
>

### 2、 更新 apt

输入 `apt help` 获取帮助，类似于 `pacman` 分别先后使用 `upgrade` 和 `updata` 即可。

## 三、 安装软件？

各取所需而已，而且 Ubuntu 很多软件都已经预设好了，几乎不需要额外安装什么软件，就已经可以完成大部分工作了。

> 附 [Ubuntu Packages Search](https://packages.ubuntu.com/)

---

> 参考网站：
>
> [How to install Linux on Windows with WSL](https://learn.microsoft.com/en-us/windows/wsl/install)
>
> [清华大学开源软件镜像站](https://mirror.tuna.tsinghua.edu.cn/)
>
>
