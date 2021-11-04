package teamapi

import (
	"C2-Server/auth"
	"C2-Server/middle"
	json2 "encoding/json"
	"github.com/gin-gonic/gin"
)

//验证签名

func AuthMd5(c *gin.Context) bool {
	a, _ := c.GetRawData()
	//login_ip := c.ClientIP()
	token := c.GetHeader("token")
	decodestr := middle.Dcode(token, string(a))
	json := GetInfoUuid{} //注意该结构接受的内容
	json2.Unmarshal([]byte(decodestr), &json)
	//login_ip := c.ClientIP()
	jwttoken := c.GetHeader("Authorization")
	username := json.Username
	timestr := json.Time
	atoken := auth.GetMd5(username + jwttoken + timestr)
	if auth.AuthToken(token, atoken) == false { //验证两边token是否一致
		return false
	} else {
		return true
	}
}
