package auth

import (
	"C2-Server/sql3"
	"crypto/md5"
	"fmt"
	"strings"
)


var (
	Md5Str1 = "asdjkla"
	Md5Str2 = "asdasd11321zxc"
)

func GetMd5(str string) string { //获取请求的sign
	//address="中国北京市东城区东华门街道锡拉胡同6号"
	signstr := Md5Str1+str+Md5Str2
	data := []byte(signstr)
	has := md5.Sum(data)
	md5str := fmt.Sprintf("%x", has) //将[]byte转成16进制
	md5str = strings.ToTitle(md5str)
	//fmt.Println(md5str1)
	return md5str
}
func AuthToken(ctoken string,stoken string)bool{  //验证签名,不正确返回false,正确返回true并且写入数据库,
	if ctoken==stoken {
		if sql3.AuthToken(stoken){
			sql3.IsToken(stoken)
			return true
		}
		return false
	}else {

		return false
	}
}