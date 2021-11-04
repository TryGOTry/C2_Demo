package teamapi

import (
	"fmt"
	"github.com/gin-gonic/gin"
)

func TeamAction(c *gin.Context) {
	action := c.Param("action")
	fmt.Println(action)
	switch action {
	case "/GetHostList":
		fmt.Println("获取主机")
		GetHostList(c) //获取主机列表
	case "/AddCmd": //添加命令
		Addcmd(c)
	case "/GetScreenshot":
		GetScreeList(c) //获取截图
	case "/DelScreenshot":
		DeleScreenlist(c) //删除截图
	case "/GetCmdStr":
		GetCmdstr(c) //获取命令执行结果
	}
}
