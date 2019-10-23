using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Discipline
{
    /// <summary>
    /// 文件名:BellWindow
    /// 创建人：L
    /// 日期：2019-10-6
    /// 描述：主要实现响铃弹窗
    /// 版本：1.0
    /// </summary>
    public partial class BellWindow : Form
    {
        private string[]  Plan;
        private Thread t;
        public static bool bExit = false;
        public BellWindow(string[] _Plan)
        {
            InitializeComponent();
            //this.TransparencyKey = Color.White;
            //this.BackColor = Color.White;
            this.Plan = _Plan;
            Play();
            StartPosition = FormStartPosition.CenterScreen;
            
            l_Title.Text = Plan[1];
            l_Date.Text = Plan[2].Split(' ')[0];
            l_Time.Text = DateTime.Now.ToString("HH:mm:ss");
            l_BellName.Text = Path.GetFileName(Plan[4]);
            t = new Thread(new ThreadStart(SetDateTime));
            t.Start();
        }

        /// <summary>
        /// 播放
        /// </summary>
        void Play()
        {
            try
            {
                axWMP.URL = Plan[4];
                axWMP.Ctlcontrols.play();
            }
            catch(Exception e)
            {
                MessageBox.Show("获取音频文件失败，请检查文件是否存在，文件格式是否正确");
                Tools.LogError("BellWindow.cs > Void Play()", e);
            }
        }

        /// <summary>
        /// 重写鼠标拖动页面
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x00A1, 2, 0);
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        int isStop = 1;

        private void Button2_Click(object sender, EventArgs e)
        {
            t.Abort();
            axWMP.Ctlcontrols.stop();
            axWMP.Dispose();
            this.Dispose();
            this.Close();
        }

        void SetDateTime()
        {
            while (true)
            {
                if (BellWindow.bExit)
                {
                    return;
                }
                Thread.Sleep(1000);
                this.Invoke(new EventHandler(delegate
                {
                    l_Time.Text = DateTime.Now.ToString("HH:mm:ss");
                }));

            }
        }

        private void BellWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Abort();
        }

        private void Btn_PauseOrPlay_Click(object sender, EventArgs e)
        {

            if (isStop % 2 != 0)
            {
                axWMP.Ctlcontrols.pause();
                btn_PauseOrPlay.Text = "播放";
            }
            else
            {
                btn_PauseOrPlay.Text = "暂停";
                axWMP.Ctlcontrols.play();
            }
            isStop++;
        }
    }
}
