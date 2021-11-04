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
    public partial class Login : Form
    {
        private Proxy_set p = null;
        private C2_Manage c2 = null;
        private TeamApi api = new TeamApi();
       
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载代理设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_proxy_Click(object sender, EventArgs e)
        {
            if (p!=null)
            {
                if (p.IsDisposed)
                {
                    p = new Proxy_set();
                    p.Show();
                    p.Focus();
                }
            
            }
            else
            {
                p = new Proxy_set();
                p.Show();
                p.Focus();
            }
           
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();//退出
        }
        string jwt = null;
        string username = null;
        string address = null;
        private void button_Login_Click(object sender, EventArgs e)
        {
            string serveraddress = textBox_address.Text + ":" + textBox_port.Text;
            jwt=api.Login(serveraddress,textBox_username.Text, textBox_password.Text);
            if (jwt!=null)
            {
                address = textBox_address.Text+":"+textBox_port.Text;
                username = textBox_username.Text;
                MessageBox.Show("登录成功!","提示");
                Thread thread = new Thread(() =>
                {
                    NewStart();
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
               
            }
            else
            {
                MessageBox.Show("服务器登录失败!","提示");
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox_port.ReadOnly = false;
        }
        private void NewStart() {
            Application.Run(new C2_Manage(address, jwt, username));
        }
    }
}
