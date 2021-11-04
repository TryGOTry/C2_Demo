package teamapi

import "C2-Server/middle"

//验证500
func AuthToken(){

}
//同一返回500
func RetErr(token string)string{
	a:=`{"status":  500,
			"message": "burp?"}`
	abc := middle.Bcode(token, a) //加密后
	return abc
}
