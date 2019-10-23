namespace Self_Discipline
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.l_ReadCount = new System.Windows.Forms.Label();
            this.l_ImgCount = new System.Windows.Forms.Label();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picture_Banner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // l_ReadCount
            // 
            this.l_ReadCount.AutoSize = true;
            this.l_ReadCount.Font = new System.Drawing.Font("宋体", 20F);
            this.l_ReadCount.ForeColor = System.Drawing.Color.Blue;
            this.l_ReadCount.Location = new System.Drawing.Point(347, 468);
            this.l_ReadCount.Name = "l_ReadCount";
            this.l_ReadCount.Size = new System.Drawing.Size(26, 27);
            this.l_ReadCount.TabIndex = 1;
            this.l_ReadCount.Text = "0";
            // 
            // l_ImgCount
            // 
            this.l_ImgCount.AutoSize = true;
            this.l_ImgCount.Font = new System.Drawing.Font("宋体", 20F);
            this.l_ImgCount.ForeColor = System.Drawing.Color.Blue;
            this.l_ImgCount.Location = new System.Drawing.Point(365, 468);
            this.l_ImgCount.Name = "l_ImgCount";
            this.l_ImgCount.Size = new System.Drawing.Size(40, 27);
            this.l_ImgCount.TabIndex = 1;
            this.l_ImgCount.Text = "/0";
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(12, 150);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(58, 192);
            this.btn_previous.TabIndex = 2;
            this.btn_previous.Text = "上一个";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(720, 150);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(58, 192);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "下一个";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "MainImg.png");
            this.imageList1.Images.SetKeyName(1, "AddPlanImg.png");
            this.imageList1.Images.SetKeyName(2, "AddPlanImg2.png");
            this.imageList1.Images.SetKeyName(3, "AddPlanImg3.png");
            // 
            // picture_Banner
            // 
            this.picture_Banner.Location = new System.Drawing.Point(79, 27);
            this.picture_Banner.Name = "picture_Banner";
            this.picture_Banner.Size = new System.Drawing.Size(630, 426);
            this.picture_Banner.TabIndex = 3;
            this.picture_Banner.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 527);
            this.Controls.Add(this.picture_Banner);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.l_ImgCount);
            this.Controls.Add(this.l_ReadCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HelpForm";
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.picture_Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_ReadCount;
        private System.Windows.Forms.Label l_ImgCount;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picture_Banner;
    }
}