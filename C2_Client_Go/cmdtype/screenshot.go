package cmdtype


/*
* @Author: A
* @Date:   2021/6/17 12:56
 截图功能模块,获取截图，然后用base64发送
*/
import (

	"encoding/base64"
	"fmt"
	"github.com/kbinani/screenshot"
	"image"
	"image/png"
	"log"
	"os"
	"time"
)

func Getbase64img(filename string) string {
	ff, _ := os.Open(filename)
	defer ff.Close()
	sourcebuffer := make([]byte, 500000)
	n, _ := ff.Read(sourcebuffer)
	sourcestring := base64.StdEncoding.EncodeToString(sourcebuffer[:n])
	//fmt.Println(sourcestring)
	baseimgstr := "data:image/jpeg;base64," + sourcestring
	//fmt.Println(baseimgstr)
	return baseimgstr
}
func save(img *image.RGBA, filePath string) (string, error) {
	file, err := os.Create(filePath)
	if err != nil {
		panic(err)
		return "", err
	}
	defer file.Close()
	png.Encode(file, img)
	return filePath, nil
}
func Screenshot() (string,error) {
	n := screenshot.NumActiveDisplays()
	if n <= 0 {
		panic("没有发现活动的显示器")
		return "没有发现活动的显示器",nil
	}
	nfilename := fmt.Sprintf("%d", time.Now().Unix())
	//全屏截取所有活动屏幕
	if n > 0 {
		for i := 0; i < n; i++ {
			img, err := screenshot.CaptureDisplay(i)
			if err != nil {
				panic(err)
			}
			fileName := fmt.Sprintf("c:\\users\\public\\Pictures\\" + nfilename + ".png")
			//fmt.Println(img)
			f, err := save(img, fileName)
			if err != nil {
				return "",err
			} else {
				//fmt.Println(f)
				basestr := Getbase64img( f)
				if basestr == "" {
					log.Println("截图失败!",err)
					return "",err
				} else {
					os.Remove(f)
					log.Println("截图成功！")
					return basestr,nil
				}
			}
		}
	}
	return "",nil
}