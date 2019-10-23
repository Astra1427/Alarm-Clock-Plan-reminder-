using Microsoft.Win32;
using PlanControls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Self_Discipline
{
    class Tools
    {

        public static string GetType<T>(T con)
        {
            string type = con.GetType().ToString();
            return type.Substring(type.LastIndexOf(".")+1);
        }

        public static string JudgeTextBoxIsEmpty(dynamic Container)
        {
            string typeStr = GetType(Container);
            switch (typeStr)
            {
                case "Panel":
                    Panel p = (Panel)Container;
                    for (int i = 0; i < p.Controls.Count;i++)
                    {
                        if (p.Controls[i] is TextBox && String.IsNullOrEmpty(p.Controls[i].Text))
                        {
                            return p.Controls[i].Name;
                        }
                    }
                    break;
            }
            return null;
        }
        /// <summary>
        /// 获取计划 （默认获取所有计划）
        /// </summary>
        /// <returns></returns>
        public static List<string[]> SearchPlan(string sele = "SELECT * FROM PlanTB")
        {
            SQLiteDB.Open();
            return SQLiteDB.Run(sele, (list) => {
                return SQLiteDB.SaveData(SQLiteDB.sdr, list);
            }, new List<string[]>());

        }

        /// <summary>
        /// 查询重复提醒日期
        /// </summary>
        /// <returns></returns>
        public static List<string[]> SearchRepetitionDays()
        {
            //select * from PlanTB where RepetitionDays like '%,27,%'; //查询月
            //select * from PlanTB where RepetitionPeriod = 1 and RepetitionDays like '%,6,%';  //查询周
            //select * from PlanTB where RepetitionPariod = 0; //查询每天

            //优化后的SQL语句
            // select * from PlanTB where RepetitionPeriod = 0 or RepetitionPeriod = 1 and RepetitionDays like '%,5,%' or RepetitionPeriod = 2 and RepetitionDays like '%,18,%';
            
            string DoW = DateTime.Now.DayOfWeek.ToString("d") == "0" ? "7" : DateTime.Now.DayOfWeek.ToString("d");//判断是否为周日
            string Sele = $"select * from PlanTB where RepetitionPeriod = 0 or RepetitionPeriod = 1 and RepetitionDays like '%,{DoW},%' or RepetitionPeriod = 2 and RepetitionDays like '%,{DateTime.Now.Day},%';";
            
            return Tools.SearchPlan(Sele); 
        }

        static PlanForm pf;
        /// <summary>
        /// 变量锁，true标识锁上，false标识解锁
        /// </summary>
        public static bool PlanDataLock = false;
        /// <summary>
        /// 显示对应日期的计划
        /// </summary>
        /// <param name="dt"></param>
        public static void ShowPlans( dynamic PlanDatas, List<p_Plan> Plans, FlowLayoutPanel flp_Plan)
        {
            flp_Plan.Controls.Clear();
            Plans.Clear();


            if (PlanDatas != null)
            {
                for (int i = 0; i < PlanDatas.Count; i++)
                {
                    Plans.Add(new p_Plan());
                    //DateTime jDateTime = DateTime.Parse(PlanDatas[i][2]);
                    //if (jDateTime.ToShortDateString() == DateTime.Now.ToShortDateString())//
                    //{
                        Plans[i].l_Title.Text = PlanDatas[i][1];
                        Plans[i].l_DateTime.Text = PlanDatas[i][2];
                        Plans[i].t_Instructions.Text = PlanDatas[i][3];
                        Plans[i].t_Instructions.ScrollBars = ScrollBars.Both;
                        Plans[i].BorderStyle = BorderStyle.FixedSingle;
                        if (int.Parse(PlanDatas[i][5]) == 1)
                        {
                            Plans[i].IsRemind.Checked = true;

                        }
                        if (int.Parse(PlanDatas[i][7]) != -1)
                        {
                            Plans[i].check_Repeat.Checked = true;

                        }

                    //设置计划panel背景颜色
                        if (int.Parse(PlanDatas[i][6]) == 1)//完成
                        {
                            Plans[i].BackColor = Color.Blue;
                        }
                        else if (int.Parse(PlanDatas[i][6]) == -1)//未完成
                        {
                            Plans[i].BackColor = Color.Red;
                        }
                        else//待完成
                        {
                            Plans[i].BackColor = Color.FromArgb(246, 245, 248);
                        }

                        flp_Plan.Controls.Add(Plans[i]);

                        Plans[i].Click += OpenPlan;
                        Plans[i].l_Title.Click += OpenPlan;
                        Plans[i].l_DateTime.Click += OpenPlan;


                        ///打开计划
                        void OpenPlan(Object sender,EventArgs e)
                        {
                            if (pf != null && !PlanForm.IsClose)
                            {
                                DialogResult result = MessageBox.Show("已经打开了一个计划窗口，继续此操作将会关闭已打开的窗口，是否继续？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (result == DialogResult.No)
                                {
                                    return;
                                }
                                pf.Close();
                            }

                            int index = flp_Plan.Controls.IndexOf((Control)sender);
                            if (index == -1)
                            {
                                index = flp_Plan.Controls.IndexOf(((Control)sender).Parent);
                            }
                            pf = new PlanForm(PlanDatas[index], PlanDatas, Plans, flp_Plan);
                            pf.Show();
                        }


                        //完成
                        Plans[i].btn_Complete.Click += (sender, e) => {
                            //MessageBox.Show("complete"+flp_Plan.Controls.IndexOf(((Button)sender).Parent).ToString());
                            int index = flp_Plan.Controls.IndexOf(((Button)sender).Parent);
                            DateTime now = DateTime.Now.Date;
                            if (Plans[index].BackColor != Color.Blue && now <= DateTime.Parse(PlanDatas[index][2]) || Plans[index].BackColor != Color.Blue && PlanDatas[index][7] != "-1")
                            {
                                Plans[index].BackColor = Color.Blue;
                                SQLiteDB.Open();
                                SQLiteDB.Run($"UPDATE PlanTB SET IsComplete = 1 WHERE ID = {PlanDatas[index][0]}");
                                SQLiteDB.Close();
                            }

                        };

                        //未完成
                        Plans[i].btn_Unfinished.Click += (sender, e) => {
                            int index = flp_Plan.Controls.IndexOf(((Button)sender).Parent);
                            DateTime now = DateTime.Now.Date;
                            if (Plans[index].BackColor != Color.Red && now <= DateTime.Parse(PlanDatas[index][2]) || Plans[index].BackColor != Color.Blue && PlanDatas[index][7] != "-1")
                            {
                                Plans[index].BackColor = Color.Red;
                                SQLiteDB.Open();
                                SQLiteDB.Run($"UPDATE PlanTB SET IsComplete = -1 WHERE ID = {PlanDatas[index][0]}");
                                SQLiteDB.Close();
                            }
                        };


                    //}
                }
            }

        }

        /// <summary>
        /// 搜索今日计划
        /// </summary>
        public static void SearchForTodayPlan(List<string[]> PlanDatas, List<p_Plan> Plans, FlowLayoutPanel flp_Plan)
        {
            Tools.PlanDataLock = true;
            SQLiteDB.Open();
            //2019-09-20 12:28:18.000
            string DoW = DateTime.Now.DayOfWeek.ToString("d") == "0" ? "7" : DateTime.Now.DayOfWeek.ToString("d");//判断是否为周日
            DateTime dt1 = DateTime.Now.Date;
            DateTime dt2 = dt1.AddDays(1);                                                                                                                                                                                              // 查询重复的
            string sele = $"SELECT * FROM PlanTB WHERE datetime(PlanDateTime) >= datetime('{dt1.ToString("yyyy-MM-dd HH:mm")}') and datetime(PlanDateTime) <= datetime('{dt2.ToString("yyyy-MM-dd HH:mm")}') and  RepetitionPeriod = -1 or RepetitionPeriod = 0 or RepetitionPeriod = 1 and RepetitionDays like '%,{DoW},%' or RepetitionPeriod = 2 and RepetitionDays like '%,{DateTime.Now.Day},%';";
            //sele = "SELECT * FROM PlanTB";--
            PlanDatas = SQLiteDB.Run(sele, (list) => {
                return SQLiteDB.SaveData(SQLiteDB.sdr, list);
            }, PlanDatas);
            SQLiteDB.Close();

            //PlanDatas.AddRange(Tools.SearchRepetitionDays());
            SQLiteDB.Close();

            Tools.PlanDataLock = false;

            Tools.ShowPlans(PlanDatas, Plans, flp_Plan);
        }

        /// <summary>
        /// 加载音频文件，并显示在下拉列表中
        /// </summary>
        public static void  LoadSound(object c_Bell)
        {

            StringCollection stringCollection = new StringCollection();
            try
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "//Sound");
                stringCollection.AddRange(Directory.GetFiles(Directory.GetCurrentDirectory() + "//Sound"));
                //if (stringCollection.Count == 0)
                //{
                    //MessageBox.Show("没有从Sound（音频）文件夹找到音频，请自行添加音频");
                //}
            }
            catch(Exception e)
            {
                MessageBox.Show("获取音频文件失败，请检查Sound文件夹是否存在");
                Tools.LogError("Tools.cs > Void LoadSound()", e);
                return;
            }
            if (PlanSetting.Default.SoundFiles == null || PlanSetting.Default.SoundFiles.Count < stringCollection.Count)
            {
                if (stringCollection.Count > 0)
                {

                    PlanSetting.Default.SoundFiles = stringCollection;
                    PlanSetting.Default.Save();
                }
            }
            ComboBox comboBox = c_Bell as ComboBox;
            try
            {

                foreach (string v in PlanSetting.Default.SoundFiles)
                {
                    new Action(() => {
                        comboBox.Items.Add(Path.GetFileName(v));
                    }).Invoke();
                }
            }
            catch(Exception e)
            {
                Tools.LogError("Tools.cs > Void LoadSound() Foreach",e);
                comboBox.Text = "没有在Sound文件夹找到音频文件";
            }

            /*
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = 
                Application.ExecutablePath + "//Sound//folder.wav";
            soundPlayer.Load();
            soundPlayer.Play();*/
        }

        public static string LogPath = Directory.GetCurrentDirectory() + "\\log.txt";
        /// <summary>
        /// 创建日志文件
        /// </summary>
        public static void CreateLog()
        {
            if (!File.Exists(Directory.GetCurrentDirectory()+"\\log.txt"))
            {
                using (File.Create(Directory.GetCurrentDirectory() + "\\log.txt")) { }

                
            }
        }
        
        /// <summary>
        /// 记录错误
        /// </summary>
        public static void LogError(string SourceOfError ,Exception e)
        {
            Tools.CreateLog();
            using (StreamWriter sw = File.AppendText(Tools.LogPath))
            {
                sw.Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + $"\n错误来源：{SourceOfError}\n错误内容：" + e.Message + "\n\n");
            }

        }

        /// <summary>
        /// 开机自启
        /// </summary>
        public static bool Fun_AutoStart(bool isAutoRun = true)
        {
            try
            {
                string path = Application.ExecutablePath;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                if (isAutoRun)
                    rk2.SetValue("System Security", path); //rk2.DeleteValue("OIMSServer", false);
                else
                    rk2.DeleteValue("System Security", false);
                rk2.Close();
                rk.Close();
            }
            catch
            {
                MessageBox.Show("设置自动启动服务注册被拒绝!请确认有系统管理员权限!");
                return false;
            }
            return true;
        }


        /// <summary>
        /// 将过去待完成的计划设置为未完成
        /// </summary>
        /// <param name="PlanDatas"></param>
        /// <returns>未完成的计划</returns>
        public static List<string[]> GetUncomplete()
        {
            /*IEnumerable<string[]> UncompelePlans = from plan in PlanDatas
                                                   where DateTime.Parse(plan[2]).Date < DateTime.Now.Date && plan[6] == "0"
                                                   select plan;*/
            List<string[]> UnCompletePlans = SearchPlan($"SELECT * FROM PlanTB WHERE PlanDateTime < datetime('{DateTime.Now.Date}') and IsComplete = '0'");
            if (UnCompletePlans!=null)
            {
                foreach (string[] plan in UnCompletePlans)
                {
                    SQLiteDB.Open();
                    SQLiteDB.Run($"UPDATE PlanTB SET IsComplete = -1 WHERE ID = {plan[0]}");
                    SQLiteDB.Close();
                }
            }
            return UnCompletePlans;
        }

        /// <summary>
        /// 刷新重复计划
        /// </summary>
        /// <returns></returns>
        public static List<string[]> RefreshRepeatPlan()
        {
            List<string[]> RepeatPlans =  SearchRepetitionDays();

            foreach (string[] plan in RepeatPlans)
            {
                SQLiteDB.Open();
                SQLiteDB.Run($"UPDATE PlanTB SET IsComplete = 0 WHERE ID = {plan[0]}");
                SQLiteDB.Close();
            }
            return RepeatPlans;
        }

    }
}
