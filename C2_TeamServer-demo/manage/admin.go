package manage

import (
	"C2-Server/sql3"
	"fmt"
)

func Logo() {

	logo := `
██████╗██████╗     ███╗   ███╗ █████╗ ███╗   ██╗ █████╗  ██████╗ ███████╗
██╔════╝╚════██╗    ████╗ ████║██╔══██╗████╗  ██║██╔══██╗██╔════╝ ██╔════╝
██║      █████╔╝    ██╔████╔██║███████║██╔██╗ ██║███████║██║  ███╗█████╗  
██║     ██╔═══╝     ██║╚██╔╝██║██╔══██║██║╚██╗██║██╔══██║██║   ██║██╔══╝  
╚██████╗███████╗    ██║ ╚═╝ ██║██║  ██║██║ ╚████║██║  ██║╚██████╔╝███████╗
 ╚═════╝╚══════╝    ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝
                                                                          
-----------------------------------------------------------------------------
`
	fmt.Println(logo)
}
func GetAllUser() { //获取全部用户
	Logo()
	userlist := sql3.GetUserlist()
	fmt.Println("Username\t", "Password\t", "Login_Ip")
	for i, n := 0, len(userlist); i < n; i++ { // 常见的 for 循环，支持初始化语句。
		fmt.Print(userlist[i].Username + "\t\t ")
		fmt.Print(userlist[i].Password + "\t\t ")
		fmt.Print(userlist[i].Login_Ip + "\n")
	}
	fmt.Println("-----------------------------------------------------------------------------")
	fmt.Println("[Info] Show complete!")
}
func AddUser(user string, pass string) { //添加用户
	Logo()
	if sql3.AuthUser(user) == false {
		sql3.AddUser(user, pass)
		fmt.Println("[Info] Add user complete!")
	} else {
		fmt.Println("[log] "+user, "already exists!")
	}
	//fmt.Println(user,pass)
}
func DelUser(user string) { //删除用户,软删除,不会真删除数据
	Logo()
	sql3.DelUser(user)
	fmt.Println("[Info] ", user, "is Del!")
}
