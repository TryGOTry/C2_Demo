using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C2_Client_Ui
{
    public partial class CmdForm : Form
    {
        private TeamApi api = new TeamApi();
        private AddMsgtype addMsgtype = new AddMsgtype();
        public CmdForm(string uuid, string address, string jwt, string username)
        {
            addMsgtype.Jwttoken = jwt;
            addMsgtype.Uuid = uuid;
            addMsgtype.Username = username;
            addMsgtype.Address = address;
            addMsgtype.Cmdtype = "cmd"; //命令请求
            InitializeComponent();
        }
        async Task DemoAsync()
        {
            //将后续代码交给线程池执行
            
            await Task.Run(() => { Thread.Sleep(3000); });
            string a = api.GetCmdstr(addMsgtype);
            Addstr(a);
            //Thread.Sleep(3000); //毫秒

        }
        private void CmdForm_Load(object sender, EventArgs e)
        {
            this.Text = "命令执行:" + addMsgtype.Uuid;
        }
        public void Addstr(string str) 
        {
            richTextBox_cmdret.Text = richTextBox_cmdret.Text+ "\n"+ str;
        }
        private void textBox_cmdstr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Enter)
            {
                DemoAsync();
           
                addMsgtype.Msg = textBox_cmdstr.Text.Replace("\\","\\\\");  //需要执行的命令
                api.AddCmdType(addMsgtype); //提交请求
                Addstr("cmd:"+textBox_cmdstr.Text);
                textBox_cmdstr.Clear();
                
               
            }
        }

        private void textBox_cmdstr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
