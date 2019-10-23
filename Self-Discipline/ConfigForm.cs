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
    /// <summary>
    /// 文件名：AddPlan.cs
    /// 创建人：L
    /// 日期：2019-9-？？
    /// 描述：实现添加Plan
    /// 版本：1.0
    /// </summary>
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            check_AutoStart.Checked = PlanSetting.Default.AutoStart;
            check_RemindUncomplete.Checked = PlanSetting.Default.RemindUnComplete;
        }

        private void check_AutoStart_Click(object sender, EventArgs e)
        {
            if (Tools.Fun_AutoStart(check_AutoStart.Checked))
            {
                PlanSetting.Default.AutoStart = check_AutoStart.Checked;
                PlanSetting.Default.Save();
            }
            else
            {
                check_AutoStart.Checked = PlanSetting.Default.AutoStart;
            }
        }

        private void check_RemindUncomplete_Click(object sender, EventArgs e)
        {
            PlanSetting.Default.RemindUnComplete = check_RemindUncomplete.Checked;
            PlanSetting.Default.Save();
        }

    }
}
