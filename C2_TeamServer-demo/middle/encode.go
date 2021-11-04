package middle

import (
	"encoding/base64"
	"fmt"
	"strings"
)

//base64混淆加密
func Bcode(s1 string, str string) string {
	key1 := s1[len(s1)-18:]
	key2 := s1[len(s1)-10:]
	sEnc1 := base64.StdEncoding.EncodeToString([]byte(key1))
	sEnc2 := base64.StdEncoding.EncodeToString([]byte(key2))
	strcode := base64.StdEncoding.EncodeToString([]byte(str))
	s := sEnc1 + strcode + sEnc2
	return s
}
//解密
func Dcode(s1 string,str string) string {
	key1 := s1[len(s1)-18:]
	key2 := s1[len(s1)-10:]
	sEnc1 := base64.StdEncoding.EncodeToString([]byte(key1))
	sEnc2 := base64.StdEncoding.EncodeToString([]byte(key2))
	str = strings.Replace(str,sEnc1,"",-1)
	str = strings.Replace(str,sEnc2,"",-1)
	sDec, _ := base64.StdEncoding.DecodeString(str)
	return string(sDec)
}

//200后返回包统一加密方法
func RetStr(token string,str string)string{
	adc := EncodeStr(str)
	abc := Bcode(token, adc) //加密后
	return abc
}

func EncodeStr(str string) string {
	a := `{"status":  200,
			"data":  "%s"}`
	content := []byte(fmt.Sprintf(a, str))
	return string(content)
}