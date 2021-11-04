package sql3

import "fmt"

//manage管理
func GetUserlist() []Users { //获取全部用户
	var user []Users
	Db.Find(&user)
	return user
}
func AuthUser(username string) bool { //验证该用户是否存在
	count := 0
	err := Db.Table("users").Where("username = ? ", username).Count(&count).Error
	if err != nil {
		fmt.Println("sql:", err)
		return false
	}
	if count >= 1 {
		return true
	}
	return false
}

func AddUser(username string, password string) { //添加用户
	var user Users
	user.Username = username
	user.Password = password
	//fmt.Println(user)
	Db.Table("users").Create(&user)
}
func DelUser(username string) {//删除用户
	var user Users
	user.Username=username
	Db.Table("users").Where("username = ?",username).Delete(&user)
}
