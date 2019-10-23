using PlanControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Self_Discipline
{
    /// <summary>
    /// 文件名：PlanConsole.cs
    /// 创建人：L
    /// 创建时间:2019-10-6
    /// 描述:查看全部计划,管理全部计划
    /// </summary>
    public partial class PlanConsole : Form
    {
        List<p_Plan> p_Plans = new List<p_Plan>();
        List<string[]> PlanDatas = new List<string[]>();
        public PlanConsole()
        {
            InitializeComponent();
            PlanDatas = Tools.SearchPlan();
            SQLiteDB.Close();
            StartPosition = FormStartPosition.CenterScreen;
            if (PlanDatas == null)
            {
                return;
            }

            Tools.ShowPlans(PlanDatas, p_Plans, flp_Plan);
            c_IsRemind.SelectedIndex = 0;
            c_IsComplete.SelectedIndex = 0;
        }





        /// <summary>
        /// 按条件获取plan
        /// </summary>
        /// <param name="_title"></param>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <param name="_remind"></param>
        /// <param name="_complete"></param>
        void GetPlan(string _title, DateTime dt1, DateTime dt2, int _remind, int _complete)
        {
            IEnumerable<string[]> plans = null;
            if (_remind == 2 && _complete == 2)//所有 所有
            {
                plans = from v in PlanDatas
                        where v[1].StartsWith(_title) && DateTime.Parse(v[2]) >= dt1 && DateTime.Parse(v[2]) <= dt2
                        select v;
            }
            else if (_remind == 2)
            {
                plans = from v in PlanDatas
                        where v[1].StartsWith(_title) && DateTime.Parse(v[2]) >= dt1 && DateTime.Parse(v[2]) <= dt2 && int.Parse(v[6]) == _complete
                        select v;
            }
            else if (_complete == 2)
            {
                plans = from v in PlanDatas
                        where v[1].StartsWith(_title) && DateTime.Parse(v[2]) >= dt1 && DateTime.Parse(v[2]) <= dt2 && int.Parse(v[5]) == _remind
                        select v;
            }
            else
            {
                plans = from v in PlanDatas
                        where v[1].StartsWith(_title) && DateTime.Parse(v[2]) >= dt1 && DateTime.Parse(v[2]) <= dt2 && int.Parse(v[5]) == _remind && int.Parse(v[6]) == _complete
                        select v;
            }




            if (plans != null)
            {
                Tools.ShowPlans(plans.ToList(), p_Plans, flp_Plan);
            }

        }

        /// <summary>
        /// 刷新
        /// </summary>
        void refresh()
        {

            DateTime dt1 = dtp1.Value.Date;
            DateTime dt2 = dtp2.Value.Date.AddDays(1);
            
            if (!check_BeginRange.Checked)
            {
                dt1 = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            }
            if (!check_Range.Checked)
            {
                dt2 = new DateTime(9999, 12, 30, 01, 01, 01);
            }


            if (dt1 >= dt2.Date.AddDays(1).AddSeconds(-1))
            {
                MessageBox.Show("起始时间不能小于或等于结束时间哦!");
                return;
            }
            int remind, complete;
            remind = c_IsRemind.SelectedIndex == 0 ? 2 : (c_IsRemind.SelectedIndex == 1 ? 1 : 0);
            complete = c_IsComplete.SelectedIndex == 0 ? 2 : (c_IsComplete.SelectedIndex == 1 ? 1 : (c_IsComplete.SelectedIndex == 2 ? -1 : 0));
            GetPlan(t_Title.Text, dt1, dt2, remind, complete);
        }

        private void t_Title_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void Check_BeginRange_Click(object sender, EventArgs e)
        {
            dtp1.Enabled = check_BeginRange.Checked;
        }

        private void Check_Range_Click(object sender, EventArgs e)
        {
            dtp2.Enabled = check_Range.Checked;
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            PlanDatas.Clear();
            PlanDatas = Tools.SearchPlan();
            SQLiteDB.Close();
            refresh();
        }

        private void Dtp1_ValueChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            t_Title.Clear();
            c_IsComplete.SelectedIndex = 0;
            c_IsRemind.SelectedIndex = 0;
            check_BeginRange.Checked = false;
            check_Range.Checked = false;
            dtp1.Value = DateTime.Now;
            dtp2.Value = dtp1.Value;
        }
        private void Dtp1_CloseUp(object sender, EventArgs e)
        {
        }
    }



}
