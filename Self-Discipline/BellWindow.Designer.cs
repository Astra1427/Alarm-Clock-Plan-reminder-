namespace Self_Discipline
{
    partial class BellWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BellWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_Title = new System.Windows.Forms.Label();
            this.l_Date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_Time = new System.Windows.Forms.Label();
            this.btn_PauseOrPlay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.l_BellName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 2);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 219);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(377, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 219);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(2, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 2);
            this.label4.TabIndex = 0;
            // 
            // l_Title
            // 
            this.l_Title.AutoSize = true;
            this.l_Title.Font = new System.Drawing.Font("宋体", 18F);
            this.l_Title.Location = new System.Drawing.Point(23, 30);
            this.l_Title.Name = "l_Title";
            this.l_Title.Size = new System.Drawing.Size(70, 24);
            this.l_Title.TabIndex = 1;
            this.l_Title.Text = "title";
            // 
            // l_Date
            // 
            this.l_Date.AutoSize = true;
            this.l_Date.Font = new System.Drawing.Font("宋体", 12F);
            this.l_Date.Location = new System.Drawing.Point(115, 38);
            this.l_Date.Name = "l_Date";
            this.l_Date.Size = new System.Drawing.Size(72, 16);
            this.l_Date.TabIndex = 2;
            this.l_Date.Text = "datetime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "计划永远赶不上变化,变化永远赶不上人的一句话";
            // 
            // l_Time
            // 
            this.l_Time.AutoSize = true;
            this.l_Time.Font = new System.Drawing.Font("宋体", 60F);
            this.l_Time.Location = new System.Drawing.Point(13, 79);
            this.l_Time.Name = "l_Time";
            this.l_Time.Size = new System.Drawing.Size(354, 80);
            this.l_Time.TabIndex = 4;
            this.l_Time.Text = "12:20:30";
            // 
            // btn_PauseOrPlay
            // 
            this.btn_PauseOrPlay.Location = new System.Drawing.Point(58, 177);
            this.btn_PauseOrPlay.Name = "btn_PauseOrPlay";
            this.btn_PauseOrPlay.Size = new System.Drawing.Size(81, 27);
            this.btn_PauseOrPlay.TabIndex = 5;
            this.btn_PauseOrPlay.Text = "停止响铃";
            this.btn_PauseOrPlay.UseVisualStyleBackColor = true;
            this.btn_PauseOrPlay.Click += new System.EventHandler(this.Btn_PauseOrPlay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(304, 186);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(75, 23);
            this.axWMP.TabIndex = 7;
            this.axWMP.Visible = false;
            // 
            // l_BellName
            // 
            this.l_BellName.AutoSize = true;
            this.l_BellName.Location = new System.Drawing.Point(36, 64);
            this.l_BellName.Name = "l_BellName";
            this.l_BellName.Size = new System.Drawing.Size(53, 12);
            this.l_BellName.TabIndex = 8;
            this.l_BellName.Text = "BellName";
            // 
            // BellWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 221);
            this.Controls.Add(this.l_BellName);
            this.Controls.Add(this.axWMP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_PauseOrPlay);
            this.Controls.Add(this.l_Time);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.l_Date);
            this.Controls.Add(this.l_Title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BellWindow";
            this.Text = "BellWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BellWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_Title;
        private System.Windows.Forms.Label l_Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_Time;
        private System.Windows.Forms.Button btn_PauseOrPlay;
        private System.Windows.Forms.Button button2;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Label l_BellName;
    }
}