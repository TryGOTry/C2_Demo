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

type GetHost struct {
	Username string `json:"username"`
	Time     string `json:"time"`
}

func GetHostList(c *gin.Context) {
	fmt.Println("获取截图")
	a, _ := c.GetRawData()
	//login_ip := c.ClientIP()
	token := c.GetHeader("token")
	decodestr := middle.Dcode(token, string(a))
	json := GetHost{} //注意该结构接受的内容
	json2.Unmarshal([]byte(decodestr), &json)
	//login_ip := c.ClientIP()
	jwttoken := c.GetHeader("Authorization")
	username := json.Username
	timestr := json.Time
	atoken := auth.GetMd5(username + jwttoken + timestr)
	fmt.Println(atoken)
	if auth.AuthToken(token, atoken) == false { //验证两边token是否一致
		e := RetErr(token)
		c.String(http.StatusBadGateway, e)
		return
	} else {
		a := sql3.GetAllHostList()
		jsonstr := Getlistinfo(a)                   //原始数据
		abc := middle.Bcode(token, string(jsonstr)) //加密后
		//dd:=middle.AESDecrypt(d,[]byte("hello"))
		c.String(http.StatusOK, abc)
	}
}
func Getlistinfo(s []sql3.HostLists) []byte { //编码json加密传输
	jsonByte, _ := json2.Marshal(s)
	jsonStr := string(jsonByte)
	a := `{"status":  200,
			"message": "ok",
			"data":    %s}`
	content := []byte(fmt.Sprintf(a, jsonStr))
	//fmt.Println(jsonStr)
	return content
}

