using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Discipline
{
    public partial class RepeatDays : Form
    {
        Button[] buttons = default;
        Button _FBtn;
        public RepeatDays(int days,string selectionDaysstr,Button btn)//,int[] SelectedDays
        {
            string[] dayStrings = new string[days];
            string[] selectionDays = null;
            _FBtn = btn;
            if (selectionDaysstr != "请选择" && selectionDaysstr.Length > 0)
            {
                selectionDaysstr = selectionDaysstr.Substring(1, selectionDaysstr.Length-2);
                selectionDays = selectionDaysstr.Split(',');
            }

            InitializeComponent();
            buttons = new Button[days];
            
                for (int i = 0; i < buttons.Length; i++)
                {
                    /*var boo = from v in SelectedDays
                              where v == i
                              select true;*/

                    buttons[i] = new Button()
                    {
                        Width = 80,
                        Height = 50,
                        BackColor = Color.FromArgb(192, 192, 255),//Cursor 192, 255, 192
                        FlatStyle = FlatStyle.Popup,
                        Text = (i + 1).ToString()
                    };
                    if (selectionDays!=null && selectionDays[i] == (i +1).ToString())
                    {
                        buttons[i].BackColor = Color.FromArgb(192, 255, 192);
                    }
                    buttons[i].Click += (s, e) => {
                        Button b = s as Button;
                        if (b.BackColor != Color.FromArgb(192, 255, 192))//active
                        {
                            b.BackColor = Color.FromArgb(192, 255, 192);
                        }
                        else
                        {
                            b.BackColor = Color.FromArgb(192, 192, 255);
                        }
                    };
                    /*if (boo.Count() > 0)
                    {
                        buttons[i].BackColor = Color.FromArgb(192, 255, 192);
                    }*/
                }
                flp_Days.Controls.AddRange(buttons);
            
        }

        /// <summary>
        /// 获取选择的日期
        /// </summary>
        /// <returns>返回拼接并处理后的字符串 如 ,1,2,3,</returns>
        string GetSelectionDays()
        {
            string RepetitionDays = ",";
            foreach (Button button in flp_Days.Controls)
            {
                if (button.BackColor == Color.FromArgb(192, 255, 192))
                {
                    RepetitionDays += button.Text;
                }
                RepetitionDays += ",";
            }
            return RepetitionDays;
        }

        public static string RepetitionDays = null;
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("此操作不可逆，是否继续？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                RepetitionDays = GetSelectionDays();
                ToolTip toolTip = new ToolTip
                {
                    AutoPopDelay = 5000,
                    UseFading = true,
                    UseAnimation = true
                };
                string toolstr = RepetitionDays.Length <= 2 ? "请选择" : RepetitionDays;
                toolTip.SetToolTip(_FBtn, toolstr);
                _FBtn.Text = toolstr;
                this.Close();
                toolTip.Dispose();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确认退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void RepeatDays_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!this.IsDisposed)
                this.Dispose();
        }
    }

}
