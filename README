# go+c#乱写了一个基于http的远控(支持团队协同作战,功能很少)(写不下去了,勿喷)
# 实现功能
1.采用sqlite存储数据,但是不知道为啥,就几个表体积就变的很大？

2.参考cs弄成写成了团队服务器,所有接口采用一个文件启动.

3.管理接口通信采用base64混淆传输

4.客户端接口通信采用hex加aes传输,aes的key取uuid的前16位.

5.截图（转成base64后传输存放）

6.命令执行

# 使用说明
1.(C2_TeamServer-demo)Go 先启动服务端
server.exe -h 查看帮助
server.exe -r teamserver     启动团队接口,用于管理端连接,端口89
server.exe -r clientsever      启动客户机上线接口,端口88

db文件可以在这里下载后放到服务端的db目录下   db下载:https://share.weiyun.com/9aPUam9u

2.(C2_Client_Ui)c#两个接口启用完毕后开启管理端连接,默认账号密码123456

3.(C2_Client_Go)Go  登录后可以运行上线端进行测试,就是马儿.(运行前请先开启burp,监听端口8080,因为默认使用了代理,也方便测试)


# 相关截图
登录团队服务器
![login](https://github.com/TRYblog/C2_Demo/blob/main/login.png "login")
命令执行
![cmd](https://github.com/TRYblog/C2_Demo/blob/main/cmd.png "cmd")
截图
![sc](https://github.com/TRYblog/C2_Demo/blob/main/sc.png "sc")
