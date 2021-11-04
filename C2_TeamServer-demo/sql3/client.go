package sql3

import (
	"fmt"
	"strconv"
	"strings"
	"time"
)

func CheckHostStatus() { //检查主机是否离线

	s := GetAllHostList()
	newtime := time.Now().Format("2006-01-02 15:04:05") //登录时间
	ntime := newtime[len(newtime)-2:]                   //获取当前的秒的值
	intnewtime, _ := strconv.Atoi(ntime)
	//fmt.Println(len(s))
	for i := 0; i <= len(s)-1; i++ {
		//fmt.Println(s[i].Utime)
		uptime := s[i].Utime[len(newtime)-2:]
		//fmt.Println(intnewtime,uptime)
		intuptime, _ := strconv.Atoi(strings.Replace(uptime, "Z", "", 1))
		//fmt.Println(ntime,intuptime)
		if intnewtime-intuptime > 10 {
			//fmt.Println(s[i])
			fmt.Println("有主机已下线,主机名:", s[i].Hostname)
			OfflineHost(s[i]) //主机下线
		}
	}
}
func OfflineHost(s HostLists) { //主机下线
	//fmt.Println("有主机已下线")
	utime := time.Now().Format("2006-01-02 15:04:05") //获取下线时间
	err := Db.Table("hosts_list").Model(&s).Updates(HostLists{Online: "0", Dtime: utime})
	if err != nil {
		fmt.Println("sql:", err)
	}
}
func AuthHost(s HostLists) bool { //验证主机是否上过线
	count := 0
	err := Db.Table("hosts_list").Where("uuid = ? AND hostname = ? AND localip = ?", s.Uuid, s.Hostname, s.Localip).Count(&count).Error
	if err != nil {
		fmt.Println("sql:", err)
		return false
	}
	if count >= 1 {
		fmt.Println("该主机已上线过,不用再添加.")

		return false
	}
	return true
}
func UpHostStatus(uuid string, ip string) { //更新主机状态,上线
	//fmt.Println("有主机上线.")
	var s HostLists
	utime := time.Now().Format("2006-01-02 15:04:05") //登录时间
	err := Db.Table("hosts_list").Model(&s).Where("uuid = ? and ip = ?", uuid, ip).Updates(HostLists{Online: "1", Utime: utime})
	if err != nil {
		//fmt.Println("sql:", err)
	}
}
func AddHost(s HostLists) { //新加主机上线
	//var host HostLists
	//fmt.Println(user)
	s.Ctime = time.Now().Format("2006-01-02 15:04:05") //登录时间
	s.Online = "1"
	Db.Table("hosts_list").Create(&s)
}
func ScHost(uuid string, msg string) { //主机截图
	var s Screenshot
	s.Uuid = uuid
	s.Img = msg
	s.Time = time.Now().Format("2006-01-02 15:04:05") //登录时间
	Db.Table("screenshot").Create(&s)
}

func UpCmdret(uuid string, msgid string,msg string) { //添加命令执行成功结果
	var s Client_cmd
	fmt.Println("命令执行")
	rtime := time.Now().Format("2006-01-02 15:04:05") //登录时间
	err := Db.Table("client_cmd").Model(&s).Where("uuid = ? and msgid = ?", uuid,msgid).Updates(Client_cmd{Msgret: msg, Time: rtime, Use: 1})
	if err != nil {
		fmt.Println("sql:", err)
	}
}
