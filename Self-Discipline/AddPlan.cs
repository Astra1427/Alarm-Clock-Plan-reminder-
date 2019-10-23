using PlanControls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Discipline
{
    /// <summary>
    /// 文件名：AddPlan.cs
    /// 创建人：L
    /// 日期：2019-9-？？
    /// 描述：实现添加Plan
    /// 版本：1.0
    /// </summary>
    public partial class AddPlan : Form
    {
        private List<p_Plan> Plans = new List<p_Plan>();
        private List<string[]> PlanDatas = new List<string[]>();
        private FlowLayoutPanel flp_Plan;
        public AddPlan(List<string[]> PlanDatas, List<p_Plan> Plans, FlowLayoutPanel flp_Plan)
        {
            try
            {

                InitializeComponent();
                this.Plans = Plans;
                this.PlanDatas = PlanDatas;
                this.flp_Plan = flp_Plan;
            }
            catch(Exception e)
            {
                Tools.LogError("AddPlan 42",e);
            }

            StartPosition = FormStartPosition.CenterScreen;
            ///加载音频文件
            Tools.LoadSound(c_Bell);

            if(c_Bell.Items.Count != 0)
                c_Bell.SelectedIndex = 0;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            switch (Tools.JudgeTextBoxIsEmpty(panel1))
            {
                case "t_title":
                        MessageBox.Show("标题不能为空！");
                    return;
                case "t_Instructions":
                        MessageBox.Show("正文不能为空！");
                    return;
            }

            if (t_title.Text.Length > 20)
            {
                MessageBox.Show("标题不能超过20个字");
                    return;
            }
            else if (t_Instructions.Text.Length > 200)
            {
                MessageBox.Show("内容不能超过200个字");
                return;
            }

            if (check_Repeat.Checked && c_Condition1.SelectedIndex != 0 && RepeatDays.RepetitionDays == null)
            {
                MessageBox.Show("请选择重复日期!");
                return;
            }

            string[] conds = CreateRepetitionCondition();

            string 铃声路径 = String.IsNullOrEmpty(c_Bell.Text) ? "No Remind" : PlanSetting.Default.SoundFiles[c_Bell.SelectedIndex];
            int IsRemind = r_Yes.Checked ? 1 : 0;
            //插入记录
            SQLiteDB.Open();
            /*,datetime('{dtp_DateTime.Value.ToString("yyyy-MM-dd HH:mm")}')*/
            int insertRows = SQLiteDB.Run($"INSERT INTO PlanTB VALUES(NULL,'{t_title.Text}','{dtp_DateTime.Value.ToString("yyyy-MM-dd HH:mm")}','{t_Instructions.Text}','{铃声路径}',{IsRemind},0,{conds[0]},'{conds[1]}')");
            //int updateRows = SQLiteDB.Run($"INSERT INTO PlanTB VALUES(NULL,'{t_title.Text}')");
            if (insertRows > 0)
            {
                MessageBox.Show("添加成功");
                Tools.SearchForTodayPlan(PlanDatas, Plans, flp_Plan);

            }
            else
            {
                MessageBox.Show("添加失败");
            }
            SQLiteDB.Close();
        }

        /// <summary>
        /// 选择的天数
        /// </summary>
        string RepetitionDays = null;
        private string[] CreateRepetitionCondition()
        {
            string[] Conditions = new string[2];
            Conditions[0] = check_Repeat.Checked ? c_Condition1.SelectedIndex.ToString() : "-1";
            Conditions[1] = c_Condition1.SelectedIndex == 0 ? "" : RepeatDays.RepetitionDays;
            return Conditions;
        }


        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 从本地选择音频文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_BrowseFile_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = openFileDialog1;
            fileDialog.Title = "请选择音频文件";
            fileDialog.Filter = "音频文件(*.mp3、*.MPEG*、*.WAV、*.WMA、*.AAC)|*.mp3;*.MPEG;*.WAV;*.WMA;*.AAC|所有文件(*.*)|*.*";
            
            fileDialog.ShowDialog();
            if (fileDialog.CheckFileExists && fileDialog.FileName != "openFileDialog1")
            {
                c_Bell.Items.Add(Path.GetFileName(fileDialog.FileName));
                c_Bell.SelectedIndex = c_Bell.Items.Count - 1;
                if (PlanSetting.Default.SoundFiles == null)
                {
                    PlanSetting.Default.SoundFiles = new StringCollection();
                }
                PlanSetting.Default.SoundFiles.Add(fileDialog.FileName);
                PlanSetting.Default.Save();
            }
            
        }

       

        private void AddPlan_FormClosing(object sender, FormClosingEventArgs e)
        {
            //t.Abort();
        }

        private void R_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (r_Yes.Checked)
            {
                c_Bell.Enabled = true;
                btn_BrowseFile.Enabled = true;
            }
            else
            {
                c_Bell.Enabled = false;
                btn_BrowseFile.Enabled = false;
            }
        }

        EventHandler d = null;
        EventHandler d2 = null;
        RepeatDays days = default;
        private void c_Condition1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Condition2.Click -= d;
            btn_Condition2.Click -= d2;
            if (c_Condition1.SelectedIndex == 0)
            {
                btn_Condition2.Enabled = false;
                btn_Condition2.Text = "每日";
            }
            else 
            {
                btn_Condition2.Text = "请选择";
                btn_Condition2.Enabled = true;

                if (c_Condition1.SelectedIndex == 1)
                {
                    d = (s, e1) => {
                        days = new RepeatDays(7,btn_Condition2.Text,btn_Condition2);
                        days.Show();
                    };
                    btn_Condition2.Click += d;
                }
                else
                {
                    d2 = (s, e1) => {
                        days = new RepeatDays(31, btn_Condition2.Text, btn_Condition2);
                        days.Show();
                    };
                    btn_Condition2.Click += d2;
                }

            }
        }

        public  void check_Repeat_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            if (check.Checked)
            {
                c_Condition1.Enabled = true;
                c_Condition1.SelectedIndex = 0;
            }
            else
            {
                c_Condition1.Enabled = false;
            }
        }

        private void btn_Condition2_Click(object sender, EventArgs e)
        {

            if (days != null && !days.IsDisposed && MessageBox.Show("已经打开了一个窗口,继续此操作将会关闭已打开的窗口，是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                days.Close();
            }
        }
    }
}
