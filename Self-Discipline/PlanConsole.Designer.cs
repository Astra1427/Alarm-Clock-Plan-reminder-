namespace Self_Discipline
{
    partial class PlanConsole
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_BeginRange = new System.Windows.Forms.CheckBox();
            this.check_Range = new System.Windows.Forms.CheckBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.c_IsComplete = new System.Windows.Forms.ComboBox();
            this.c_IsRemind = new System.Windows.Forms.ComboBox();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.t_Title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flp_Plan = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_BeginRange);
            this.groupBox1.Controls.Add(this.check_Range);
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.c_IsComplete);
            this.groupBox1.Controls.Add(this.c_IsRemind);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.t_Title);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制面板";
            // 
            // check_BeginRange
            // 
            this.check_BeginRange.AutoSize = true;
            this.check_BeginRange.Location = new System.Drawing.Point(190, 25);
            this.check_BeginRange.Name = "check_BeginRange";
            this.check_BeginRange.Size = new System.Drawing.Size(15, 14);
            this.check_BeginRange.TabIndex = 8;
            this.check_BeginRange.UseVisualStyleBackColor = true;
            this.check_BeginRange.Click += new System.EventHandler(this.Check_BeginRange_Click);
            // 
            // check_Range
            // 
            this.check_Range.AutoSize = true;
            this.check_Range.Location = new System.Drawing.Point(270, 25);
            this.check_Range.Name = "check_Range";
            this.check_Range.Size = new System.Drawing.Size(15, 14);
            this.check_Range.TabIndex = 8;
            this.check_Range.UseVisualStyleBackColor = true;
            this.check_Range.Click += new System.EventHandler(this.Check_Range_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(740, 36);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(78, 35);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "重置条件";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(656, 36);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(78, 35);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "刷新结果";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // c_IsComplete
            // 
            this.c_IsComplete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_IsComplete.FormattingEnabled = true;
            this.c_IsComplete.Items.AddRange(new object[] {
            "全部",
            "是",
            "否",
            "待完成"});
            this.c_IsComplete.Location = new System.Drawing.Point(515, 44);
            this.c_IsComplete.Name = "c_IsComplete";
            this.c_IsComplete.Size = new System.Drawing.Size(59, 20);
            this.c_IsComplete.TabIndex = 6;
            this.c_IsComplete.SelectedIndexChanged += new System.EventHandler(this.t_Title_TextChanged);
            // 
            // c_IsRemind
            // 
            this.c_IsRemind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_IsRemind.FormattingEnabled = true;
            this.c_IsRemind.Items.AddRange(new object[] {
            "全部",
            "是",
            "否"});
            this.c_IsRemind.Location = new System.Drawing.Point(422, 45);
            this.c_IsRemind.Name = "c_IsRemind";
            this.c_IsRemind.Size = new System.Drawing.Size(59, 20);
            this.c_IsRemind.TabIndex = 6;
            this.c_IsRemind.SelectedIndexChanged += new System.EventHandler(this.t_Title_TextChanged);
            // 
            // dtp2
            // 
            this.dtp2.Enabled = false;
            this.dtp2.Location = new System.Drawing.Point(270, 44);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(111, 21);
            this.dtp2.TabIndex = 5;
            this.dtp2.ValueChanged += new System.EventHandler(this.Dtp1_ValueChanged);
            // 
            // dtp1
            // 
            this.dtp1.Enabled = false;
            this.dtp1.Location = new System.Drawing.Point(124, 45);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(111, 21);
            this.dtp1.TabIndex = 5;
            this.dtp1.CloseUp += new System.EventHandler(this.Dtp1_CloseUp);
            this.dtp1.ValueChanged += new System.EventHandler(this.Dtp1_ValueChanged);
            // 
            // t_Title
            // 
            this.t_Title.Location = new System.Drawing.Point(6, 45);
            this.t_Title.Name = "t_Title";
            this.t_Title.Size = new System.Drawing.Size(94, 21);
            this.t_Title.TabIndex = 4;
            this.t_Title.TextChanged += new System.EventHandler(this.t_Title_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "是否完成";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "是否提醒";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "创建日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题";
            // 
            // flp_Plan
            // 
            this.flp_Plan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Plan.AutoScroll = true;
            this.flp_Plan.Location = new System.Drawing.Point(12, 128);
            this.flp_Plan.Name = "flp_Plan";
            this.flp_Plan.Size = new System.Drawing.Size(824, 310);
            this.flp_Plan.TabIndex = 1;
            // 
            // PlanConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.flp_Plan);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PlanConsole";
            this.Text = "PlanConsole";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox c_IsComplete;
        private System.Windows.Forms.ComboBox c_IsRemind;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox t_Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_Plan;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.CheckBox check_Range;
        private System.Windows.Forms.CheckBox check_BeginRange;
    }
}