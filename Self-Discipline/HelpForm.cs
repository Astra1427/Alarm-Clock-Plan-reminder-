using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Discipline
{
    /// <summary>
    /// 文件名：HelpForm.cs
    /// 创建人：L
    /// 日期：2019-10-23
    /// 描述：帮助界面
    /// 版本：1.0
    /// </summary>
    public partial class HelpForm : Form
    {
        int ImgIndex = 0;
        string[] ImgsPath;
        bool NonImg = false;
        public HelpForm()
        {
            InitializeComponent();
            ImgsPath = LoadImg();
            if (ImgsPath == null || ImgsPath.Length == 0)
            {
                NonImg = true;
                MessageBox.Show("获取图片失败");
                return;
            }
            picture_Banner.ImageLocation = ImgsPath[ImgIndex];
            picture_Banner.SizeMode = PictureBoxSizeMode.StretchImage;
            l_ReadCount.Text = "1";
            l_ImgCount.Text = $"/{ImgsPath.Length}";

        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (NonImg)
            {
                return;
            }
            ImgIndex = --ImgIndex < 0 ? ImgsPath.Length - 1 : ImgIndex;
            picture_Banner.ImageLocation = ImgsPath[ImgIndex];
            l_ReadCount.Text = $"{ImgIndex+1}";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (NonImg)
            {
                return;
            }
            ImgIndex = ++ImgIndex >= ImgsPath.Length ? 0 : ImgIndex;
            picture_Banner.ImageLocation = ImgsPath[ImgIndex];
            l_ReadCount.Text = $"{ImgIndex+1}";
        }

        string[] LoadImg()
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "//IMG");
            string ImgFolderPath = Application.StartupPath + "\\IMG";
            return Directory.GetFiles(ImgFolderPath);
        }
    }
}
