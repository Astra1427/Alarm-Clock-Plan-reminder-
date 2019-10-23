namespace Self_Discipline
{
    partial class AddPlan
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Condition2 = new System.Windows.Forms.Button();
            this.c_Condition1 = new System.Windows.Forms.ComboBox();
            this.check_Repeat = new System.Windows.Forms.CheckBox();
            this.btn_BrowseFile = new System.Windows.Forms.Button();
            this.c_Bell = new System.Windows.Forms.ComboBox();
            this.r_No = new System.Windows.Forms.RadioButton();
            this.r_Yes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_DateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_title = new System.Windows.Forms.TextBox();
            this.t_Instructions = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(15, 361);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(149, 361);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "返回";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Condition2);
            this.panel1.Controls.Add(this.c_Condition1);
            this.panel1.Controls.Add(this.check_Repeat);
            this.panel1.Controls.Add(this.btn_BrowseFile);
            this.panel1.Controls.Add(this.c_Bell);
            this.panel1.Controls.Add(this.r_No);
            this.panel1.Controls.Add(this.r_Yes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtp_DateTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.t_title);
            this.panel1.Controls.Add(this.t_Instructions);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 355);
            this.panel1.TabIndex = 6;
            // 
            // btn_Condition2
            // 
            this.btn_Condition2.Enabled = false;
            this.btn_Condition2.Location = new System.Drawing.Point(149, 156);
            this.btn_Condition2.Name = "btn_Condition2";
            this.btn_Condition2.Size = new System.Drawing.Size(75, 23);
            this.btn_Condition2.TabIndex = 18;
            this.btn_Condition2.Text = "请选择";
            this.btn_Condition2.UseVisualStyleBackColor = true;
            this.btn_Condition2.Click += new System.EventHandler(this.btn_Condition2_Click);
            // 
            // c_Condition1
            // 
            this.c_Condition1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_Condition1.Enabled = false;
            this.c_Condition1.FormattingEnabled = true;
            this.c_Condition1.Items.AddRange(new object[] {
            "每日",
            "每周",
            "每月"});
            this.c_Condition1.Location = new System.Drawing.Point(57, 156);
            this.c_Condition1.Name = "c_Condition1";
            this.c_Condition1.Size = new System.Drawing.Size(64, 20);
            this.c_Condition1.TabIndex = 17;
            this.c_Condition1.SelectedIndexChanged += new System.EventHandler(this.c_Condition1_SelectedIndexChanged);
            // 
            // check_Repeat
            // 
            this.check_Repeat.AutoSize = true;
            this.check_Repeat.Location = new System.Drawing.Point(3, 156);
            this.check_Repeat.Name = "check_Repeat";
            this.check_Repeat.Size = new System.Drawing.Size(48, 16);
            this.check_Repeat.TabIndex = 16;
            this.check_Repeat.Text = "重复";
            this.check_Repeat.UseVisualStyleBackColor = true;
            this.check_Repeat.CheckedChanged += new System.EventHandler(this.check_Repeat_CheckedChanged);
            // 
            // btn_BrowseFile
            // 
            this.btn_BrowseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BrowseFile.Font = new System.Drawing.Font("宋体", 5F);
            this.btn_BrowseFile.Location = new System.Drawing.Point(195, 125);
            this.btn_BrowseFile.Name = "btn_BrowseFile";
            this.btn_BrowseFile.Size = new System.Drawing.Size(38, 23);
            this.btn_BrowseFile.TabIndex = 15;
            this.btn_BrowseFile.Text = "···";
            this.toolTip1.SetToolTip(this.btn_BrowseFile, "后期软件升级会加入自定义铃声");
            this.btn_BrowseFile.UseVisualStyleBackColor = true;
            this.btn_BrowseFile.Click += new System.EventHandler(this.Btn_BrowseFile_Click);
            // 
            // c_Bell
            // 
            this.c_Bell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_Bell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c_Bell.FormattingEnabled = true;
            this.c_Bell.Location = new System.Drawing.Point(8, 126);
            this.c_Bell.Name = "c_Bell";
            this.c_Bell.Size = new System.Drawing.Size(186, 20);
            this.c_Bell.TabIndex = 14;
            // 
            // r_No
            // 
            this.r_No.AutoSize = true;
            this.r_No.Location = new System.Drawing.Point(149, 49);
            this.r_No.Name = "r_No";
            this.r_No.Size = new System.Drawing.Size(35, 16);
            this.r_No.TabIndex = 12;
            this.r_No.Text = "否";
            this.r_No.UseVisualStyleBackColor = true;
            // 
            // r_Yes
            // 
            this.r_Yes.AutoSize = true;
            this.r_Yes.Checked = true;
            this.r_Yes.Location = new System.Drawing.Point(86, 49);
            this.r_Yes.Name = "r_Yes";
            this.r_Yes.Size = new System.Drawing.Size(35, 16);
            this.r_Yes.TabIndex = 13;
            this.r_Yes.TabStop = true;
            this.r_Yes.Text = "是";
            this.r_Yes.UseVisualStyleBackColor = true;
            this.r_Yes.CheckedChanged += new System.EventHandler(this.R_Yes_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "是否提醒";
            // 
            // dtp_DateTime
            // 
            this.dtp_DateTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateTime.Location = new System.Drawing.Point(7, 86);
            this.dtp_DateTime.Name = "dtp_DateTime";
            this.dtp_DateTime.Size = new System.Drawing.Size(225, 21);
            this.dtp_DateTime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "铃声";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(3, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "正文";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "标题";
            // 
            // t_title
            // 
            this.t_title.Location = new System.Drawing.Point(7, 23);
            this.t_title.MaxLength = 40;
            this.t_title.Name = "t_title";
            this.t_title.Size = new System.Drawing.Size(225, 21);
            this.t_title.TabIndex = 6;
            // 
            // t_Instructions
            // 
            this.t_Instructions.Font = new System.Drawing.Font("宋体", 10F);
            this.t_Instructions.Location = new System.Drawing.Point(7, 195);
            this.t_Instructions.Multiline = true;
            this.t_Instructions.Name = "t_Instructions";
            this.t_Instructions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.t_Instructions.Size = new System.Drawing.Size(225, 160);
            this.t_Instructions.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPlan";
            this.Text = "添加计划";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPlan_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton r_No;
        private System.Windows.Forms.RadioButton r_Yes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_DateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_Instructions;
        private System.Windows.Forms.TextBox t_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox c_Bell;
        private System.Windows.Forms.Button btn_BrowseFile;
        private System.Windows.Forms.ComboBox c_Condition1;
        private System.Windows.Forms.CheckBox check_Repeat;
        private System.Windows.Forms.Button btn_Condition2;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}