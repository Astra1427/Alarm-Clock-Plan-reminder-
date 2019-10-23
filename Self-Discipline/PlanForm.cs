using PlanControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Discipline
{
    /// <summary>
    /// 文件名:PlanForm
    /// 创建人：L
    /// 日期：2019-10-3 20:12
    /// 描述：主要实现修改Plan
    /// 版本：2.0
    /// 2019-10-07 新增删除功能
    /// </summary>
    public partial class PlanForm : Form
    {
        private int id, IsRemind;
        private string Title, Instruction,BellPath;
        private DateTime dateTime;
        private static bool isClose;
        private List<p_Plan> Plans = new List<p_Plan>();
        private List<string[]> PlanDatas = new List<string[]>();
        private FlowLayoutPanel flp_Plan;
        /// <summary>
        /// 检测窗体是否关闭
        /// </summary>
        public static bool IsClose{
            get {
                return isClose;
            }
            set
            {
                if (value is bool)
                {
                    isClose = value;
                }
            }
        }

        //int id,string _Title,DateTime _dateTime,string _Instruction,string _BellPath, int _IsRemind,
        public PlanForm(string[] datas, List<string[]> PlanDatas, List<p_Plan> Plans, FlowLayoutPanel flp_Plan)
        {
            InitializeComponent();
            Title = datas[1];
            IsRemind = int.Parse(datas[5]);
            dateTime = DateTime.Parse(datas[2]);
            Instruction = datas[3];
            BellPath = datas[4];

            this.id = int.Parse(datas[0]);
            t_title.Text = Title;
            r_No.Checked =  !(r_Yes.Checked = IsRemind == 0 ? false : true);
            rt_Instructions.Text = Instruction;
            dtp_DateTime.Value = dateTime;

            this.Plans = Plans;
            this.PlanDatas = PlanDatas;
            this.flp_Plan = flp_Plan;
            StartPosition = FormStartPosition.CenterScreen;

            if (int.Parse(datas[7]) > -1)
            {
                check_Repeat.Checked = true;
                c_Condition1.SelectedIndex = int.Parse(datas[7]);
                btn_Condition2.Text = datas[8];
            }


            ///加载音频文件
            Tools.LoadSound(c_Bell);

            if (IsRemind == 1)
            {
                c_Bell.SelectedItem = Path.GetFileName(BellPath);
            }

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            
        }


        private void Btn_BrowseFile_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = openFileDialog1;
            fileDialog.Title = "请选择音频文件";
            fileDialog.Filter = "音频文件(*.mp3、*.MPEG*、*.WAV、*.WMA、*.AAC)|*.mp3;*.MPEG;*.WAV;*.WMA;*.AAC|所有文件(*.*)|*.*";

            fileDialog.ShowDialog();
            if (fileDialog.CheckFileExists)
            {
                c_Bell.Items.Add(Path.GetFileName(fileDialog.FileName));
                c_Bell.SelectedIndex = c_Bell.Items.Count - 1;
                PlanSetting.Default.SoundFiles.Add(fileDialog.FileName);
                PlanSetting.Default.Save();
            }
        }

        private void PlanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClose = true;
        }

        private void PlanForm_Load(object sender, EventArgs e)
        {
            isClose = false;
        }

        private void PlanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //t.Abort();
            //todo
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定删除?","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SQLiteDB.Open();
                if(SQLiteDB.Run($"DELETE FROM PlanTB WHERE ID = {id};") > 0)
                {
                    MessageBox.Show("删除成功");
                    Tools.SearchForTodayPlan(PlanDatas, Plans, flp_Plan);
                    this.Close();

                }
                else
                {
                     MessageBox.Show("删除失败");
                }
                    
                SQLiteDB.Close();

            }
        }

        private void check_Repeat_CheckedChanged(object sender, EventArgs e)
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
                        days = new RepeatDays(7, btn_Condition2.Text, btn_Condition2);
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

        private void btn_Condition2_Click(object sender, EventArgs e)
        {

            if (days != null && !days.IsDisposed && MessageBox.Show("已经打开了一个窗口,继续此操作将会关闭已打开的窗口，是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                days.Close();
            }
        }

        private void R_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (r_Yes.Checked)
            {
                c_Bell.Enabled = true;
                btn_BrowseFile.Enabled = true;
                c_Bell.SelectedIndex = 0;
            }
            else
            {
                c_Bell.Enabled = false;
                btn_BrowseFile.Enabled = false;
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (t_title.Text.Length > 20)
            {
                MessageBox.Show("标题不能超过20个字");
                return;
            }
            else if (rt_Instructions.Text.Length > 200)
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

            DialogResult result = MessageBox.Show("确定保存更改吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);



            if (result == DialogResult.Yes)
            {
                int IsRemind = r_Yes.Checked ? 1 : 0;
                BellPath = PlanSetting.Default.SoundFiles[c_Bell.SelectedIndex];
                SQLiteDB.Open();
                int error = SQLiteDB.Run($"UPDATE PlanTB SET PlanName='{t_title.Text}',PlanDateTime='{dtp_DateTime.Value.ToString("yyyy-MM-dd HH:mm:ss")}',Instructions='{rt_Instructions.Text}',BellPath='{BellPath}',IsRemind={IsRemind},RepetitionPeriod={conds[0]},RepetitionDays='{conds[1]}' WHERE ID = {this.id}");
                SQLiteDB.Close();
                if (error > 0)
                {
                    MessageBox.Show("修改成功");

                    Tools.SearchForTodayPlan(PlanDatas, Plans, flp_Plan);


                }
                else if (error == 0)
                {
                    MessageBox.Show("什么都没有变动");
                }
                else
                {
                    MessageBox.Show("修改失败");

                }
            }
            
        }

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
    }
}
