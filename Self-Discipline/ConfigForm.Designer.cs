namespace Self_Discipline
{
    partial class ConfigForm
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
            this.check_AutoStart = new System.Windows.Forms.CheckBox();
            this.check_RemindUncomplete = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // check_AutoStart
            // 
            this.check_AutoStart.AutoSize = true;
            this.check_AutoStart.Location = new System.Drawing.Point(12, 16);
            this.check_AutoStart.Name = "check_AutoStart";
            this.check_AutoStart.Size = new System.Drawing.Size(72, 16);
            this.check_AutoStart.TabIndex = 0;
            this.check_AutoStart.Text = "开机自启";
            this.check_AutoStart.UseVisualStyleBackColor = true;
            this.check_AutoStart.Click += new System.EventHandler(this.check_AutoStart_Click);
            // 
            // check_RemindUncomplete
            // 
            this.check_RemindUncomplete.AutoSize = true;
            this.check_RemindUncomplete.Checked = true;
            this.check_RemindUncomplete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_RemindUncomplete.Location = new System.Drawing.Point(90, 16);
            this.check_RemindUncomplete.Name = "check_RemindUncomplete";
            this.check_RemindUncomplete.Size = new System.Drawing.Size(132, 16);
            this.check_RemindUncomplete.TabIndex = 0;
            this.check_RemindUncomplete.Text = "提醒昨日未完成计划";
            this.check_RemindUncomplete.UseVisualStyleBackColor = true;
            this.check_RemindUncomplete.Click += new System.EventHandler(this.check_RemindUncomplete_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 56);
            this.Controls.Add(this.check_RemindUncomplete);
            this.Controls.Add(this.check_AutoStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigForm";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_AutoStart;
        private System.Windows.Forms.CheckBox check_RemindUncomplete;
    }
}