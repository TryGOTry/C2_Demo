package main

import (
	"C2-Server/cmd"
	"C2-Server/manage"
	"flag"
	"fmt"
)

var (
	server_type string
	manage_type string
	help_type   string
	username    string
	password    string
)

func init() {
	//logo := `c2_Server` + config.Server_Version
	//	fmt.Println(logo)
	flag.StringVar(&server_type, "r", "", "run")
	flag.StringVar(&manage_type, "m", "", "manage")
	flag.StringVar(&help_type, "h", "ddd", "help")
	flag.StringVar(&username, "u", "", "")
	flag.StringVar(&password, "p", "", "")
	flag.Parse()
}

func main() {
	switch server_type {
	case "teamserver":
		cmd.RunTeamServer()
		break
	case "clientserver":
		cmd.RunHostServer()
		break
	}
	switch manage_type { //系统管理
	case "list":
		//打印全部用户
		manage.GetAllUser()
		break
	case "add":
		if username != "" && password != "" {
			manage.AddUser(username, password)
		} else {
			flag.Usage()
		}
		break
	case "del":
		if username != "" {
			manage.DelUser(username)
		} else {
			fmt.Println("[Info] You need a name!")
			break
		}
	}
	if help_type == "" && server_type == "" && manage_type == "" {
		flag.Args()
	}

}
