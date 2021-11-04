package sql3

import (
	"fmt"
	_ "github.com/jinzhu/gorm/dialects/sqlite"
	"time"
)


func init() {
	Db = GetDb()
}
func AuthToken(token string) bool { //查询数据库是否存在这个token
	count := 0
	err := Db.Table("token_list").Where("token = ?", token).Count(&count).Error
	if err != nil {
		fmt.Println("sql:", err)
		return false
	}
	if count >= 1 {
		fmt.Println("该token已使用过了,禁止重放.")
		return false
	}
	return true
}
func IsToken(token string) { //将使用过的token插入数据库
	count := 0
	var s = TokenList{Token: token}
	Db.Table("token_list").Create(&s).Count(&count)
}
func (u *Users) AuthTeamLogin() bool { //团队服务器登陆账号密码验证
	count := 0
	err := Db.Table("users").Where("username = ? and password = ?", u.Username, u.Password).Count(&count).Error
	if err != nil {
		fmt.Println("sql:", err)
		return false
	}
	if count >= 1 {
		fmt.Println("登录成功.")
		u.UpdataLoginInfo()
		return true
	}
	return false
}
func (u *Users) UpdataLoginInfo() { //更新登录时间和ip
	u.Login_Time = time.Now().Format("2006-01-02 15:04:05") //登录时间
	Db.Table("users").Model(&u).Where("username = ?", u.Username).Update("login_time", u.Login_Time).Update("login_ip", u.Login_Ip)
}
func GetAllHostList() []HostLists { //获取全部主机
	var hostlist []HostLists
	err := Db.Table("hosts_list").Find(&hostlist).Error
	if err != nil {
		fmt.Println("sql:", err)
	}
	return hostlist
}
func AddCmdstr(uuid string, Cmdtype string, Cmdstr string) { //添加需要执行的命令
	var s Client_cmd
	s.Uuid = uuid
	s.Msgtype = Cmdtype
	s.Msg = Cmdstr
	s.Time = time.Now().Format("2006-01-02 15:04:05") //登录时间
	s.Use = 0
	s.Msgid = Getkey()
	Db.Table("client_cmd").Create(&s)
}
func GetCmdType(uuid string) Client_cmd { //获取主机命令
	var scr Client_cmd
	err := Db.Table("client_cmd").Where("uuid = ? and use = 0", uuid).Last(&scr).Error
	if err != nil {
		fmt.Println("sql:", err)
	}
	return scr
}
func GetScreeList(uuid string) string { //获取截图
	var scr Screenshot
	err := Db.Table("screenshot").Where("uuid = ?", uuid).Last(&scr).Error
	if err != nil {
		fmt.Println("sql:", err)
	}
	return scr.Img
}
func DelScList(uuid string) { //删除截图
	var scr Screenshot
	err := Db.Table("screenshot").Where("uuid = ?", uuid).Delete(&scr).Error
	if err != nil {
		fmt.Println("sql:", err)
	}
}
func GetCmdlist(uuid string)string{ //获取命令执行结果
	var s Client_cmd
	err := Db.Table("client_cmd").Where("uuid = ? and msgtype = ?", uuid,"cmd").Last(&s).Error
	if err != nil {
		fmt.Println("sql:", err)
	}
	return s.Msgret
}