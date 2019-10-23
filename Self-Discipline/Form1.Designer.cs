namespace Self_Discipline
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.flp_Plan = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddPlan = new System.Windows.Forms.Button();
            this.btn_AllPlan = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.l_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.l_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Config = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "主界面";
            // 
            // flp_Plan
            // 
            this.flp_Plan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Plan.AutoScroll = true;
            this.flp_Plan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Plan.Location = new System.Drawing.Point(0, 155);
            this.flp_Plan.Name = "flp_Plan";
            this.flp_Plan.Size = new System.Drawing.Size(414, 306);
            this.flp_Plan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(5, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "今日计划：";
            // 
            // btn_AddPlan
            // 
            this.btn_AddPlan.Location = new System.Drawing.Point(1, 69);
            this.btn_AddPlan.Name = "btn_AddPlan";
            this.btn_AddPlan.Size = new System.Drawing.Size(75, 31);
            this.btn_AddPlan.TabIndex = 3;
            this.btn_AddPlan.Text = "添加计划";
            this.btn_AddPlan.UseVisualStyleBackColor = true;
            this.btn_AddPlan.Click += new System.EventHandler(this.Btn_AddPlan_Click);
            // 
            // btn_AllPlan
            // 
            this.btn_AllPlan.Location = new System.Drawing.Point(85, 69);
            this.btn_AllPlan.Name = "btn_AllPlan";
            this.btn_AllPlan.Size = new System.Drawing.Size(75, 31);
            this.btn_AllPlan.TabIndex = 3;
            this.btn_AllPlan.Text = "全部计划";
            this.btn_AllPlan.UseVisualStyleBackColor = true;
            this.btn_AllPlan.Click += new System.EventHandler(this.Btn_AllPlan_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(253, 69);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(75, 31);
            this.btn_Help.TabIndex = 3;
            this.btn_Help.Text = "帮助";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_Date,
            this.l_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(414, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // l_Date
            // 
            this.l_Date.Name = "l_Date";
            this.l_Date.Size = new System.Drawing.Size(44, 17);
            this.l_Date.Text = "年月日";
            // 
            // l_Time
            // 
            this.l_Time.Name = "l_Time";
            this.l_Time.Size = new System.Drawing.Size(44, 17);
            this.l_Time.Text = "时分秒";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(169, 69);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 31);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "刷新";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.Location = new System.Drawing.Point(339, 69);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(75, 31);
            this.btn_Config.TabIndex = 5;
            this.btn_Config.Text = "设置";
            this.btn_Config.UseVisualStyleBackColor = true;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 486);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_AllPlan);
            this.Controls.Add(this.btn_AddPlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flp_Plan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Self-Discipline";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_Plan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddPlan;
        private System.Windows.Forms.Button btn_AllPlan;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel l_Date;
        private System.Windows.Forms.ToolStripStatusLabel l_Time;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Config;
    }
}

