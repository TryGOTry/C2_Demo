package clientApi

import "C2-Server/middle"

func EncodeStr(uuid string,msg string)string{
	encodestr :=middle.Encodestr(msg,uuid)
	return encodestr
}
