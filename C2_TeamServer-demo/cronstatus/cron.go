package cronstatus

import (
	"C2-Server/sql3"
	"fmt"
	"github.com/robfig/cron"
	"time"
)

func Cronstatus()  {
	c := cron.New()
	c.AddFunc("2 * * * * *", sql3.CheckHostStatus)  //2 * * * * *, 2 表示每分钟的第2s执行一次
	c.Start()
	t1 := time.NewTimer(time.Second * 2) // ?time.Second * 10 啥意思？ *100行吗？
	for {
		select {
		case <-t1.C:
			fmt.Println("Time now:", time.Now().Format("2006-01-02 15:04:05")) // 为何要专门制定这个时间
			t1.Reset(time.Second * 2)
		}
	}
}
