
namespace C2_Client_Ui
{
    partial class C2_Manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl_offhosts = new System.Windows.Forms.TabControl();
            this.tabPage_online = new System.Windows.Forms.TabPage();
            this.listView_online_host = new System.Windows.Forms.ListView();
            this.columnHeader_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_localip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_hostname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_av = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_addtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_osversion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_remarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_online_tools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_cmd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_screenshot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_sysinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_hostexit = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage_offline = new System.Windows.Forms.TabPage();
            this.contextMenuStrip_offline_tools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_say = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_offline_host = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl_offhosts.SuspendLayout();
            this.tabPage_online.SuspendLayout();
            this.contextMenuStrip_online_tools.SuspendLayout();
            this.tabPage_offline.SuspendLayout();
            this.contextMenuStrip_offline_tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_log);
            this.groupBox1.Location = new System.Drawing.Point(12, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1225, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出日志";
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Location = new System.Drawing.Point(7, 21);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.ReadOnly = true;
            this.richTextBox_log.Size = new System.Drawing.Size(1212, 149);
            this.richTextBox_log.TabIndex = 0;
            this.richTextBox_log.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1259, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "菜单";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // toolStripMenuItem_exit
            // 
            this.toolStripMenuItem_exit.Name = "toolStripMenuItem_exit";
            this.toolStripMenuItem_exit.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem_exit.Text = "退出";
            this.toolStripMenuItem_exit.Click += new System.EventHandler(this.toolStripMenuItem_exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl_offhosts);
            this.groupBox2.Location = new System.Drawing.Point(11, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1236, 342);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "主机管理";
            // 
            // tabControl_offhosts
            // 
            this.tabControl_offhosts.Controls.Add(this.tabPage_online);
            this.tabControl_offhosts.Controls.Add(this.tabPage_offline);
            this.tabControl_offhosts.Location = new System.Drawing.Point(8, 20);
            this.tabControl_offhosts.Name = "tabControl_offhosts";
            this.tabControl_offhosts.SelectedIndex = 0;
            this.tabControl_offhosts.Size = new System.Drawing.Size(1222, 316);
            this.tabControl_offhosts.TabIndex = 0;
            // 
            // tabPage_online
            // 
            this.tabPage_online.Controls.Add(this.listView_online_host);
            this.tabPage_online.Controls.Add(this.listView1);
            this.tabPage_online.Location = new System.Drawing.Point(4, 22);
            this.tabPage_online.Name = "tabPage_online";
            this.tabPage_online.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_online.Size = new System.Drawing.Size(1214, 290);
            this.tabPage_online.TabIndex = 0;
            this.tabPage_online.Text = "在线列表";
            this.tabPage_online.UseVisualStyleBackColor = true;
            // 
            // listView_online_host
            // 
            this.listView_online_host.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_id,
            this.columnHeader_ip,
            this.columnHeader_localip,
            this.columnHeader_hostname,
            this.columnHeader_av,
            this.columnHeader11,
            this.columnHeader_time,
            this.columnHeader_addtime,
            this.columnHeader_version,
            this.columnHeader_osversion,
            this.columnHeader_remarks});
            this.listView_online_host.ContextMenuStrip = this.contextMenuStrip_online_tools;
            this.listView_online_host.ForeColor = System.Drawing.Color.Red;
            this.listView_online_host.FullRowSelect = true;
            this.listView_online_host.HideSelection = false;
            this.listView_online_host.Location = new System.Drawing.Point(3, 3);
            this.listView_online_host.MultiSelect = false;
            this.listView_online_host.Name = "listView_online_host";
            this.listView_online_host.Scrollable = false;
            this.listView_online_host.Size = new System.Drawing.Size(1208, 284);
            this.listView_online_host.TabIndex = 3;
            this.listView_online_host.UseCompatibleStateImageBehavior = false;
            this.listView_online_host.View = System.Windows.Forms.View.Details;
            this.listView_online_host.SelectedIndexChanged += new System.EventHandler(this.listView_online_host_SelectedIndexChanged);
            this.listView_online_host.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_online_host_MouseDown);
            // 
            // columnHeader_id
            // 
            this.columnHeader_id.Text = "id";
            this.columnHeader_id.Width = 30;
            // 
            // columnHeader_ip
            // 
            this.columnHeader_ip.Text = "ip";
            this.columnHeader_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_ip.Width = 100;
            // 
            // columnHeader_localip
            // 
            this.columnHeader_localip.Text = "内网ip";
            this.columnHeader_localip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_hostname
            // 
            this.columnHeader_hostname.Text = "主机名";
            this.columnHeader_hostname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_hostname.Width = 100;
            // 
            // columnHeader_av
            // 
            this.columnHeader_av.Text = "杀毒软件";
            // 
            // columnHeader_time
            // 
            this.columnHeader_time.Text = "响应时间";
            this.columnHeader_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_time.Width = 96;
            // 
            // columnHeader_addtime
            // 
            this.columnHeader_addtime.Text = "上线时间";
            this.columnHeader_addtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_addtime.Width = 194;
            // 
            // columnHeader_version
            // 
            this.columnHeader_version.Text = "上线版本";
            this.columnHeader_version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_version.Width = 155;
            // 
            // columnHeader_osversion
            // 
            this.columnHeader_osversion.Text = "系统版本";
            this.columnHeader_osversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_osversion.Width = 147;
            // 
            // columnHeader_remarks
            // 
            this.columnHeader_remarks.Text = "备注";
            this.columnHeader_remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_remarks.Width = 220;
            // 
            // contextMenuStrip_online_tools
            // 
            this.contextMenuStrip_online_tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_cmd,
            this.toolStripMenuItem_screenshot,
            this.toolStripMenuItem_file,
            this.toolStripMenuItem_sysinfo,
            this.toolStripMenuItem_hostexit});
            this.contextMenuStrip_online_tools.Name = "contextMenuStrip_tools";
            this.contextMenuStrip_online_tools.Size = new System.Drawing.Size(145, 114);
            // 
            // toolStripMenuItem_cmd
            // 
            this.toolStripMenuItem_cmd.Name = "toolStripMenuItem_cmd";
            this.toolStripMenuItem_cmd.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem_cmd.Text = "命令执行";
            this.toolStripMenuItem_cmd.Click += new System.EventHandler(this.toolStripMenuItem_cmd_Click);
            // 
            // toolStripMenuItem_screenshot
            // 
            this.toolStripMenuItem_screenshot.Name = "toolStripMenuItem_screenshot";
            this.toolStripMenuItem_screenshot.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem_screenshot.Text = "实时截图";
            this.toolStripMenuItem_screenshot.Click += new System.EventHandler(this.toolStripMenuItem_screenshot_Click);
            // 
            // toolStripMenuItem_file
            // 
            this.toolStripMenuItem_file.Name = "toolStripMenuItem_file";
            this.toolStripMenuItem_file.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem_file.Text = "文件管理(未)";
            this.toolStripMenuItem_file.Click += new System.EventHandler(this.toolStripMenuItem_file_Click);
            // 
            // toolStripMenuItem_sysinfo
            // 
            this.toolStripMenuItem_sysinfo.Name = "toolStripMenuItem_sysinfo";
            this.toolStripMenuItem_sysinfo.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem_sysinfo.Text = "系统信息(未)";
            // 
            // toolStripMenuItem_hostexit
            // 
            this.toolStripMenuItem_hostexit.Name = "toolStripMenuItem_hostexit";
            this.toolStripMenuItem_hostexit.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem_hostexit.Text = "主机下线(未)";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1031, 281);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage_offline
            // 
            this.tabPage_offline.Controls.Add(this.listView_offline_host);
            this.tabPage_offline.Location = new System.Drawing.Point(4, 22);
            this.tabPage_offline.Name = "tabPage_offline";
            this.tabPage_offline.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_offline.Size = new System.Drawing.Size(1214, 290);
            this.tabPage_offline.TabIndex = 1;
            this.tabPage_offline.Text = "离线列表";
            this.tabPage_offline.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip_offline_tools
            // 
            this.contextMenuStrip_offline_tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.contextMenuStrip_offline_tools.Name = "contextMenuStrip_offline_tools";
            this.contextMenuStrip_offline_tools.Size = new System.Drawing.Size(149, 92);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem2.Text = "历史截图";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem4.Text = "命令记录";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem3.Text = "浏览器密码";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem5.Text = "历史下载文件";
            // 
            // textBox_say
            // 
            this.textBox_say.Location = new System.Drawing.Point(1026, 566);
            this.textBox_say.Name = "textBox_say";
            this.textBox_say.Size = new System.Drawing.Size(213, 21);
            this.textBox_say.TabIndex = 5;
            this.textBox_say.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_say_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(993, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Say:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "uuid";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 100;
            // 
            // listView_offline_host
            // 
            this.listView_offline_host.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12});
            this.listView_offline_host.ContextMenuStrip = this.contextMenuStrip_offline_tools;
            this.listView_offline_host.ForeColor = System.Drawing.Color.Red;
            this.listView_offline_host.FullRowSelect = true;
            this.listView_offline_host.HideSelection = false;
            this.listView_offline_host.Location = new System.Drawing.Point(3, 3);
            this.listView_offline_host.MultiSelect = false;
            this.listView_offline_host.Name = "listView_offline_host";
            this.listView_offline_host.Scrollable = false;
            this.listView_offline_host.Size = new System.Drawing.Size(1208, 284);
            this.listView_offline_host.TabIndex = 4;
            this.listView_offline_host.UseCompatibleStateImageBehavior = false;
            this.listView_offline_host.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ip";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "内网ip";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "主机名";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "杀毒软件";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "uuid";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "响应时间";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 96;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "上线时间";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 194;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "上线版本";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 155;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "系统版本";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 147;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "备注";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 220;
            // 
            // C2_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 592);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_say);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "C2_Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team_C2_Manage  Demo  v0.0.1       测试版";
            this.Load += new System.EventHandler(this.C2_Manage_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl_offhosts.ResumeLayout(false);
            this.tabPage_online.ResumeLayout(false);
            this.contextMenuStrip_online_tools.ResumeLayout(false);
            this.tabPage_offline.ResumeLayout(false);
            this.contextMenuStrip_offline_tools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_say;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl_offhosts;
        private System.Windows.Forms.TabPage tabPage_online;
        private System.Windows.Forms.ListView listView_online_host;
        private System.Windows.Forms.ColumnHeader columnHeader_id;
        private System.Windows.Forms.ColumnHeader columnHeader_ip;
        private System.Windows.Forms.ColumnHeader columnHeader_hostname;
        private System.Windows.Forms.ColumnHeader columnHeader_osversion;
        private System.Windows.Forms.ColumnHeader columnHeader_av;
        private System.Windows.Forms.ColumnHeader columnHeader_version;
        private System.Windows.Forms.ColumnHeader columnHeader_time;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage_offline;
        private System.Windows.Forms.ColumnHeader columnHeader_addtime;
        private System.Windows.Forms.ColumnHeader columnHeader_remarks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_online_tools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_file;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_cmd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_screenshot;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_sysinfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_hostexit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_offline_tools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ColumnHeader columnHeader_localip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView listView_offline_host;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}