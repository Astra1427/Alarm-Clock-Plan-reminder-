using PlanControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Self_Discipline
{
    public partial class Form1 : Form
    {
        private Tools tools = new Tools();
        private bool IsContinue = true;
        private Thread thread;
        public Form1()
        {
            InitializeComponent();
            Directory.GetCurrentDirectory();
            //创建数据库
            SQLiteDB.CreateDBFile();
            //创建表
                CreatePlanTB();
            if (!IsContinue)
            {
                return;
            }
            if(PlanSetting.Default.StartDate.Date == null)
            {
                PlanSetting.Default.StartDate = DateTime.Now.Date;
            }
            else if (PlanSetting.Default.StartDate.Date < DateTime.Now.Date)
            {
                int UnCompleteCount = Tools.GetUncomplete().Count;
                int RefreshPlans = Tools.RefreshRepeatPlan().Count;
                if (UnCompleteCount > 0 && PlanSetting.Default.RemindUnComplete)
                {
                    MessageBox.Show($"昨日有{UnCompleteCount}个计划未完成");
                }
                PlanSetting.Default.StartDate = DateTime.Now.Date;
            }
            PlanSetting.Default.Save();


            Tools.SearchForTodayPlan(PlanDatas, Plans, flp_Plan);
            
            //LoadJson();

            //ShowPlan(allText,DateTime.Now);
            //this.BackColor = Plan.Default.PlanBackColor;
            StartPosition = FormStartPosition.CenterScreen;
            ThreadStart threadStart = new ThreadStart(SetDateTime);
            thread = new Thread(threadStart);
            thread.IsBackground = true;
            thread.Start();
        }

        /// <summary>
        /// 创建或者追加
        /// </summary>
        /// <param name="JsonPath"></param>
        /// <param name="allText"></param>
        /// <param name="panel"></param>
        void CreatOrAppend(string JsonPath,string allText,dynamic plan)
        {
            #region 测试代码

            //var Panel1 = new
            //{
            //    PanlName = "pn1",
            //    PlanDateTime = "d1"
            //};
            //var Panel2 = new
            //{
            //    PanlName = "pn1",
            //    PlanDateTime = "d1"
            //};

            //JavaScriptSerializer Jss = new JavaScriptSerializer();
            //var _Plan1 = Jss.Serialize(Panel1);
            //var _Plan2 = Jss.Serialize(Panel2);
            #endregion


            using (StreamWriter sw = new StreamWriter(JsonPath))
            {
                //创建
                if (allText.Length == 0)
                {
                    sw.Write("{\"Plans\":[" + plan.ToString() + "]}");
                }
                else//追加
                {
                    sw.WriteLine(
                        allText.Insert(allText.LastIndexOf("]"),
                        "," + plan.ToString())
                        );
                }

            }
        }

        List<p_Plan> Plans = new List<p_Plan>();
        List<string[]> PlanDatas = new List<string[]>();

        void CreatePlanTB()
        {
            if (SQLiteDB.Open() == -1)
            {
                MessageBox.Show("SQLite数据库打开失败");
                IsContinue = false;
                return;
            }
            SQLiteDB.Run("CREATE TABLE  if not exists PlanTB(" +
                "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                "PlanName varchar(50)," +
                "PlanDateTime varchar(50)," +
                "Instructions varchar(255)," +
                "BellPath varchar(255)," +
                "IsRemind INTEGER," +
                "IsComplete integer," +
                "RepetitionPeriod integer," + 
                "RepetitionDays varchar(255)" +
                ")");
            SQLiteDB.Close();
        }

        





        private void Btn_RedBack_Click(object sender, EventArgs e)
        {
            PlanSetting.Default.PlanBackColor = Color.Red;
            PlanSetting.Default.Save();
            this.BackColor = PlanSetting.Default.PlanBackColor;

        }

        private void Btn_BlueBack_Click(object sender, EventArgs e)
        {
            PlanSetting.Default.PlanBackColor = Color.Blue;
            PlanSetting.Default.Save();
            this.BackColor = PlanSetting.Default.PlanBackColor;
        }
        AddPlan ap = null;
        private void Btn_AddPlan_Click(object sender, EventArgs e)
        {
            if (ap != null)
            {
                ap.Close(); 
            }

            ap = new AddPlan(PlanDatas, Plans, flp_Plan);
            ap.Show();
        }



        /// <summary>
        /// 设置主界面时间
        /// </summary>
        void SetDateTime()
        {
            while (true)
            {
                DateTime dt = DateTime.Now;
                try
                {

                    ///这样写解决了 
                    ///"在创建窗口句柄之前，不能在控件上调用 Invoke 或 BeginInvoke。"  错误
                    if (this.IsHandleCreated)
                    {
                        MethodInvoker meth = new MethodInvoker(delegate {
                            l_Date.Text = dt.ToString("yyyy年MM月dd日");
                            l_Time.Text = dt.ToString("HH时mm分ss秒");
                        });

                        this.BeginInvoke(meth);
                    }

                }
                catch(Exception e)
                {
                    Tools.LogError("Form1.cs > Void SetDateTime()", e);
                }
                

                try
                {
                    if (!Tools.PlanDataLock)
                    {
                        
                        //获取响铃的计划
                        IEnumerable<string[]> ind = from v in PlanDatas
                                                where dt.ToLongTimeString().Equals(DateTime.Parse(v[2]).ToLongTimeString()) && v[5] == "1"//dt - DateTime.Parse(v[2])).TotalSeconds >= 0 && (dt - DateTime.Parse(v[2])).TotalSeconds <= 1 
                                                select v;
                        //逐个响铃
                        foreach (string[] v in ind)
                        {
                            try
                            {
                                this.BeginInvoke(new EventHandler(delegate {

                                    BellWindow bw = new BellWindow(v);
                                    bw.ShowDialog();
                                }));
                            }
                            catch (Exception e)
                            {
                                Tools.LogError("Form1.cs > Void SetDateTime() > Foreach", e);
                            }

                            
                        }

                    }
                }
                catch (Exception e) { Tools.LogError("Form1.cs > Void SetDateTime()", e); }
                Thread.Sleep(1000);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
            BellWindow.bExit = true;
        }

        private void Btn_AllPlan_Click(object sender, EventArgs e)
        {
            PlanConsole planConsole = new PlanConsole();
            planConsole.Show();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Tools.SearchForTodayPlan(PlanDatas, Plans, flp_Plan);
        }

        private void Btn_BatchAdd_Click(object sender, EventArgs e)
        {

        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.Show();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.Show();
        }
    }
}
