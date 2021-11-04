using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C2_Client_Ui
{
    public partial class C2_Manage : Form
    {
        string Uuid = null;  //唯一标识符
        List<HostListInfo> Hostlist = new List<HostListInfo>();
        private TeamApi api = new TeamApi();
        //private
        private string token;
        private string ipaddress;
        private string username;
        public C2_Manage(string ipaddress,string token,string username)
        {
            this.ipaddress = ipaddress;
            this.token = token;
            this.username = username;
            
            InitializeComponent();

        }
      
        public void Addlog(string str) {

            richTextBox_log.Text = richTextBox_log.Text  +DateTime.Now.ToString() + "\t" + str + "\n";
        }
        private void C2_Manage_Load(object sender, EventArgs e)
        {
            if (token==null)
            {
                MessageBox.Show("未登录","提示");
                Process.GetCurrentProcess().Kill();//退出
            }
            Addlog(username + " join... ");
            ShowList(); //获取主机列表
            timer1.Enabled = true;

            timer1.Interval = 5000;  //定时器时间间隔

            timer1.Start();   //定时器开始工作
        }
        public void ShowList() {
            Hostlist.Clear();
            listView_online_host.Items.Clear();
            listView_offline_host.Items.Clear();
            IList<HostListInfo> list = api.GetHostList(ipaddress, token, username);
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Hostlist.Add(new HostListInfo() { id = list[i].id, uuid = list[i].uuid, ip = list[i].ip, hostname = list[i].hostname, version = list[i].version, os = list[i].os, av = list[i].av, remarks = list[i].remarks, sleeptime = list[i].sleeptime, online = list[i].online, ctime = list[i].ctime,localip=list[i].localip,utime=list[i].utime});
                }
                foreach (HostListInfo host in Hostlist)
                {
                    ListViewItem lv = new ListViewItem();
                    if (host.online == "1")
                    {
                        lv.Text = host.id;
                        lv.SubItems.Add(host.ip);
                        lv.SubItems.Add(host.localip);
                        lv.SubItems.Add(host.hostname);
                        lv.SubItems.Add(host.av);
                        lv.SubItems.Add(host.uuid);
                        lv.SubItems.Add(host.utime);
                        lv.SubItems.Add(host.ctime);
                        lv.SubItems.Add(host.version);
                        lv.SubItems.Add(host.os);
                        lv.SubItems.Add(host.remarks);
                        listView_online_host.Items.Add(lv);
                    }
                    else {
                        lv.Text = host.id;
                        lv.SubItems.Add(host.ip);
                        lv.SubItems.Add(host.localip);
                        lv.SubItems.Add(host.hostname);
                        lv.SubItems.Add(host.av);
                        lv.SubItems.Add(host.uuid);
                        lv.SubItems.Add(host.utime);
                        lv.SubItems.Add(host.ctime);
                        lv.SubItems.Add(host.version);
                        lv.SubItems.Add(host.os);
                        lv.SubItems.Add(host.remarks);
                        listView_offline_host.Items.Add(lv);
                    }
                   
                }
                tabPage_online.Text = "在线列表["+ listView_online_host.Items.Count+"]";
                tabPage_offline.Text = "离线列表[" + listView_offline_host.Items.Count + "]";
            }
            else
            {
                Addlog("服务器连接失败....");
            }
        }
        private void toolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();//退出
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowList();
    
        }

        private void toolStripMenuItem_file_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                FileManageStar();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        /// <summary>
        /// 加载文件管理窗口
        /// </summary>
        private void FileManageStar()
        {
            Application.Run(new FileManage(Uuid));
        }
        /// <summary>
        /// 加载命令执行窗口
        /// </summary>
        private void CmdFormStar()
        {
            Application.Run(new CmdForm(Uuid, ipaddress, token, username));
        }
          private void ScreenshotFormStar()
        {
            Application.Run(new Screenshot(Uuid, ipaddress, token, username));
        }

        private void listView_online_host_MouseDown(object sender, MouseEventArgs e)
        {
            var c = listView_online_host.Items.IndexOf(listView_online_host.FocusedItem);
           // MessageBox.Show(Hostlist[c+1].uuid);
            if (c < 0)
            {
                Uuid = null;
            }
            else {
                Uuid = Hostlist[c + 1].uuid;
            }
           
           // MessageBox.Show(Uuid);
           // MessageBox.Show(Hostlist[c].uuid);
        }

        private void toolStripMenuItem_cmd_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                CmdFormStar();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        /// <summary>
        /// 命令执行窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_screenshot_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                ScreenshotFormStar();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowList();
        }

        private void textBox_say_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Enter)
            {
                Addlog(textBox_say.Text);
                textBox_say.Clear();
            }
        }

        private void listView_online_host_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
