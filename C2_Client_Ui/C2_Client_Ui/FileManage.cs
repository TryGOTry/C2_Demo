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
    public partial class FileManage : Form
    {
        private string uuid;
        public FileManage(string uuid)
        {
            this.uuid = uuid;
            InitializeComponent();
        }

        private void FileManage_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(uuid);
            this.Text = "FileManage:"+uuid;
        }
    }
}
