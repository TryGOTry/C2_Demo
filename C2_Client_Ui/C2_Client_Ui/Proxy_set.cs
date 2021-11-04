using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C2_Client_Ui
{
    public partial class Proxy_set : Form
    {
        private Proxy_set ProxyForm;
        public Proxy_set()
        {
            InitializeComponent();
        }

        private void Proxy_set_Load(object sender, EventArgs e)
        {

        }
        private void Proxy_ser_Close(object sender, EventArgs e)
        {
            ProxyForm.Close();
        }

        private void checkBox_proxy_CheckedChanged(object sender, EventArgs e)
        {
            if (check_text())
            {
              
            }
            else
            {
                MessageBox.Show("请全部填写正确!", "提示");
            }
        }
        //检测是否为空
        public bool check_text() {
            if (textBox_proxyip.Text!=""&&textBox_proxyport.Text!="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (check_text())
            {

            }
            else
            {
                MessageBox.Show("请全部填写正确!","提示");
            }
        }
    }
}
