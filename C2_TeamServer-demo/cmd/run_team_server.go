package cmd

//用于启动团队服务器的接口
import (
	"C2-Server/config"
	"C2-Server/middle"
	"C2-Server/teamapi"
	"fmt"
	"github.com/gin-gonic/gin"
	"net/http"
)

func RunTeamServer() {
	server_address := config.TeamServer_Ip + ":" + config.TeamServer_Port
	r := gin.Default()
	r.Use(middle.Cors())                      //解决跨域问题
	v1 := r.Group(config.Hosts_Api + "/Team") //v1接口
	{
		v1.GET("/Status", func(c *gin.Context) {
			c.String(http.StatusOK, "Team_server_ok is ok")
		})                                          //测试接口是否启动
		v1.POST("/Access/Login", teamapi.TeamLogin) //登陆团队服务器接口
	}
	v1_team_api := r.Group(config.Hosts_Api + "/Team_Api") //团队接口
	{
		//v1_team_api.POST("/GetHostList",middle.JWTAuthMiddleware(),teamapi.GetHostList) //获取主机列表
		//v1_team_api.POST("/GetScreenshot",middle.JWTAuthMiddleware(),teamapi.GetScreeList) //获取截图信息
		//v1_team_api.POST("/DelScreenshot",middle.JWTAuthMiddleware(),teamapi.DeleScreenlist) //获取截图信息
		v1_team_api.POST("/Action/*action",middle.JWTAuthMiddleware(),teamapi.TeamAction) //根据接口内容来执行
	}

	fmt.Print("Team_Server is Runing....\nYou Can See http://" + server_address + config.Hosts_Api + "/Team/Status  to check your TeamServer!\n")
	r.Run(server_address)
}
