
namespace C2_Client_Ui
{
    partial class Proxy_set
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_proxy = new System.Windows.Forms.CheckBox();
            this.textBox_proxyip = new System.Windows.Forms.TextBox();
            this.textBox_proxyport = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "验证";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "地址:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口:";
            // 
            // checkBox_proxy
            // 
            this.checkBox_proxy.AutoSize = true;
            this.checkBox_proxy.Location = new System.Drawing.Point(216, 77);
            this.checkBox_proxy.Name = "checkBox_proxy";
            this.checkBox_proxy.Size = new System.Drawing.Size(72, 16);
            this.checkBox_proxy.TabIndex = 3;
            this.checkBox_proxy.Text = "是否启用";
            this.checkBox_proxy.UseVisualStyleBackColor = true;
            this.checkBox_proxy.CheckedChanged += new System.EventHandler(this.checkBox_proxy_CheckedChanged);
            // 
            // textBox_proxyip
            // 
            this.textBox_proxyip.Location = new System.Drawing.Point(70, 16);
            this.textBox_proxyip.Name = "textBox_proxyip";
            this.textBox_proxyip.Size = new System.Drawing.Size(97, 21);
            this.textBox_proxyip.TabIndex = 4;
            this.textBox_proxyip.Text = "127.0.0.1";
            // 
            // textBox_proxyport
            // 
            this.textBox_proxyport.Location = new System.Drawing.Point(70, 45);
            this.textBox_proxyport.Name = "textBox_proxyport";
            this.textBox_proxyport.Size = new System.Drawing.Size(61, 21);
            this.textBox_proxyport.TabIndex = 5;
            this.textBox_proxyport.Text = "8080";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(148, 29);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "仅支持http代理";
            // 
            // Proxy_set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 121);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox_proxyport);
            this.Controls.Add(this.textBox_proxyip);
            this.Controls.Add(this.checkBox_proxy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Proxy_set";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代理设置";
            this.Load += new System.EventHandler(this.Proxy_set_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox checkBox_proxy;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_proxyip;
        public System.Windows.Forms.TextBox textBox_proxyport;
    }
}