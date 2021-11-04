package config

const (
	HostAddress = "http://127.0.0.1:88/v1/Hosts/"
	Version     = "0.0.1"
)

var (
	UserAgent       = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36"
	SleepTime int64 = 2          //心跳相应时间
	CmdType         = "Online.js" //定义返回结果
	MsgType         = ""          //执行命令的结果。成功返回1，没成功返回0
	Msg             = ""          //执行命令的id
	Msgid           = ""          //信息id
)

func SetSleepTime(sleeptime int64) {
	SleepTime = sleeptime
}
func SetMsgid(Mid string) {
	Msgid = Mid
}
func GetMsgid() string {
	return Msgid
}
func GetSleepTime() int64 {
	return SleepTime
}
func SetCmdType(msg string) {
	CmdType = msg
}
func GetCmdType() string {
	return CmdType
}
func SetMsgType(msg string) {
	MsgType = msg
}
func GetMsgType() string {
	return MsgType
}
func SetMsg(msg string) {
	Msg = msg
}
func GetMsg() string {
	return Msg
}
