package teamapi

import (
	"C2-Server/auth"
	"C2-Server/middle"
	"C2-Server/sql3"
	json2 "encoding/json"
	"github.com/gin-gonic/gin"
	"net/http"
)

//登陆团队服务器
type User struct {
	Username string `json:"username"`
	Password string `json:"password"`
	Time     string `json:"time"`
}

//登录接口
func TeamLogin(c *gin.Context) {
	a, _ := c.GetRawData()
	login_ip := c.ClientIP()
	token := c.GetHeader("token")
	decodestr := middle.Dcode(token, string(a))
	json := User{} //注意该结构接受的内容
	json2.Unmarshal([]byte(decodestr), &json)
	username := json.Username
	password := json.Password
	timestr := json.Time
	atoken := auth.GetMd5(username + password + timestr)
	userinfo := sql3.Users{Username: username, Password: password, Login_Ip: login_ip}
	if auth.AuthToken(token, atoken) == false { //验证两边token是否一致
		e := RetErr(token)
		c.String(http.StatusBadGateway, e)
		return
	} else if userinfo.AuthTeamLogin() {
		tokenstr, _ := middle.GenToken(username) //成功返回jwt的token
		abc := middle.RetStr(token, tokenstr)
		c.String(http.StatusOK, abc)
		return
	} else {
		e := RetErr(token)
		c.String(http.StatusBadGateway, e)
		return
	}
}
