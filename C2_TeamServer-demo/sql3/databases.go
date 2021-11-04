package sql3

import (
	"github.com/jinzhu/gorm"
	"log"
	"os"
	"strings"
)
var Db *gorm.DB

func GetDb() *gorm.DB {
	var err error
	pwd, _ := os.Getwd()
	s:=strings.Replace(pwd,"\\","/",-1)
	//fmt.Println(s+"/db/team.db")
	Db, err := gorm.Open("sqlite3", s+"/db/team.db")
	//defer Db.Close()
	if err != nil {
		log.Println("[Info] 数据库连接失败！",err)
	}
	if err != nil {
		panic(err)
	}
	//Db.LogMode(true)  //sql调试模式
	return Db
}
type Users struct { //users表
	gorm.Model
	Username   string `json:"username"`
	Password   string `json:"password"`
	Login_Ip   string `json:"login_ip"`
	Login_Time string `json:"login_time"`
}
type HostLists struct { //host_list表
	//gorm.Model
	Id         string `json:"id"`
	Uuid       string `json:"uuid"`      //uuid唯一标识
	Ip         string `json:"ip"`        //上线ip
	Localip    string `json:"localip"`   //内网ip
	Hostname   string `json:"hostname"`  //主机名
	Os         string `json:"os"`        //系统版本
	Av         string `json:"av"`        //杀毒软件
	Version    string `json:"version"`   //上线客户端版本
	Remarks    string `json:"remarks"`   //备注
	Sleep_time string `json:"sleeptime"` //响应时间
	Online     string `json:"online"`    //是否在线
	Ctime      string `json:"ctime"`     //上线时间
	Utime      string `json:"utime"`     //响应时间
	Dtime      string `json:"dtime"`     //下线时间
}
type TokenList struct { //token_list表
	gorm.Model
	Token string `json:"token"` //验证token是否存在
}
type Screenshot struct { //截图表
	Id   int    `json:"id"`
	Img  string `json:"img"` //截图数据
	Uuid string `json:"uuid"`
	Time string `json:"time"`
}

//type Cmd struct { //命令执行表
//	Id     int    `json:"id"`
//	Cmdstr string `json:"cmdstr"` //需要执行的命令
//	Cmdret string `json:"cmdret"` //执行的结果
//	Use    int    `json:"use"`    //是否已执行
//	Uuid   string `json:"uuid"`
//	Time   string `json:"time"`
//}
type Client_cmd struct {
	Id      int    `json:"id"`
	Use     int    `json:"use"` //是否已执行
	Uuid    string `json:"uuid"`
	Msg     string `json:"msg"`     //详细命令
	Msgret  string `json:"msgret"`  //执行结果
	Msgtype string `json:"msgtype"` //命令类型
	Time   string `json:"time"`
	Msgid 	string `json:"msgid"`  //命令id
}
