
namespace C2_Client_Ui
{
    partial class CmdForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cmdstr = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_cmdret = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "命令:";
            // 
            // textBox_cmdstr
            // 
            this.textBox_cmdstr.Location = new System.Drawing.Point(46, 10);
            this.textBox_cmdstr.Name = "textBox_cmdstr";
            this.textBox_cmdstr.Size = new System.Drawing.Size(718, 21);
            this.textBox_cmdstr.TabIndex = 2;
            this.textBox_cmdstr.TextChanged += new System.EventHandler(this.textBox_cmdstr_TextChanged);
            this.textBox_cmdstr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_cmdstr_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_cmdret);
            this.groupBox1.Location = new System.Drawing.Point(9, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 391);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "命令回显";
            // 
            // richTextBox_cmdret
            // 
            this.richTextBox_cmdret.BackColor = System.Drawing.SystemColors.Desktop;
            this.richTextBox_cmdret.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_cmdret.Location = new System.Drawing.Point(10, 17);
            this.richTextBox_cmdret.Name = "richTextBox_cmdret";
            this.richTextBox_cmdret.Size = new System.Drawing.Size(745, 368);
            this.richTextBox_cmdret.TabIndex = 1;
            this.richTextBox_cmdret.Text = "Microsoft Windows [版本 10.0.19043.1288]\n(c) Microsoft Corporation。保留所有权利。\n";
            // 
            // CmdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_cmdstr);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CmdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CmdForm";
            this.Load += new System.EventHandler(this.CmdForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cmdstr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_cmdret;
    }
}