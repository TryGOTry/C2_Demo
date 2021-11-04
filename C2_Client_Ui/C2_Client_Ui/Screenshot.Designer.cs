
namespace C2_Client_Ui
{
    partial class Screenshot
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
            this.pictureBox_screenshot = new System.Windows.Forms.PictureBox();
            this.timer_MainForm = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.button_end = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_screenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_screenshot
            // 
            this.pictureBox_screenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_screenshot.Location = new System.Drawing.Point(3, 41);
            this.pictureBox_screenshot.Name = "pictureBox_screenshot";
            this.pictureBox_screenshot.Size = new System.Drawing.Size(1443, 596);
            this.pictureBox_screenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_screenshot.TabIndex = 0;
            this.pictureBox_screenshot.TabStop = false;
            // 
            // timer_MainForm
            // 
            this.timer_MainForm.Tick += new System.EventHandler(this.timer_MainForm_Tick);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(778, 11);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_end
            // 
            this.button_end.Location = new System.Drawing.Point(1160, 12);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(75, 23);
            this.button_end.TabIndex = 2;
            this.button_end.Text = "结束";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "截图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Screenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox_screenshot);
            this.MaximizeBox = false;
            this.Name = "Screenshot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screenshot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Screenshot_FormClosing);
            this.Load += new System.EventHandler(this.Screenshot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_screenshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_screenshot;
        private System.Windows.Forms.Timer timer_MainForm;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Button button1;
    }
}