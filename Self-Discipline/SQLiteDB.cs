using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Discipline
{

    /// <summary>
    /// 文件名:SQLiteDB
    /// 创建人：L
    /// 日期：2019-9-？？
    /// 描述：操作SQLite数据库
    /// 版本：1.0
    /// </summary>
    class SQLiteDB
    {
        /// <summary>
        /// 创建数据库文件
        /// </summary>
        /// <param name="fileName">文件名</param>
        public static void CreateDBFile()
        {
            string path = Environment.CurrentDirectory + @"/Data/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string databaseFileName = path + "PlanDB.db";
            if (!File.Exists(databaseFileName))
            {
                SQLiteConnection.CreateFile(databaseFileName);
            }
        }
        /// <summary>
        /// 删除数据库
        /// </summary>
        /// <param name="fileName">文件名</param>
        public static void DeleteDBFile()
        {
            string path = Environment.CurrentDirectory + @"/Data/PlanDB.db";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        /// <summary>
        /// 创建连接字符串
        /// </summary>
        /// <returns></returns>
        public static string CreateSQLiteConnectionString()
        {
            SQLiteConnectionStringBuilder sqlcsb = new SQLiteConnectionStringBuilder
            {
                DataSource = @"data/PlanDB.db"
            };
            return sqlcsb.ConnectionString;
        }

        public static SQLiteConnection m_SQLiteConnection;

        /// <summary>
        /// 创建连接对象
        /// </summary>
        public static SQLiteConnection CreateSQLiteConnetion()
        {
            m_SQLiteConnection = new SQLiteConnection(CreateSQLiteConnectionString());
            return m_SQLiteConnection;
        }

        /// <summary>
        /// 打开连接
        /// </summary>
        public static int Open()
        {
            if (CreateSQLiteConnetion().State == ConnectionState.Closed)
            {
                try
                {
                    m_SQLiteConnection.Open();
                }
                catch
                {
                    return -1;
                }
            }
            return 1;
        }
        /// <summary>
        /// 关闭连接
        /// </summary>
        public static void Close()
        {
            if (m_SQLiteConnection.State == ConnectionState.Open)
            {
                try
                {
                    m_SQLiteConnection.Close();
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
        }

        public static SQLiteCommand cmd;
        /// <summary>
        /// 执行语句
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static int Run(string sqlstr)
        {
            try
            {

                cmd = new SQLiteCommand(sqlstr, m_SQLiteConnection);
                return cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Tools.LogError("SQLiteDB.cs > int Run()", e);

                return -1;
            }
            finally
            {
                Close();
            }
        }

        public static SQLiteDataReader sdr;
        /// <summary>
        /// 执行语句
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static List<string[]> Run(string sqlstr,Func<List<string[]>,List<string[]>> func,List<string[]> list)
        {
            try
            {

                cmd = new SQLiteCommand(sqlstr,m_SQLiteConnection);
                sdr = cmd.ExecuteReader();
                return func(list);
            }
            catch(Exception e)
            {
                Tools.LogError("SQLite.cs > List<string[]> Run(string sqlstr,Func<List<string[]>,List<string[]>> func,List<string[]> list)", e);

                return null;
            }
            finally
            {
                Close();
            }
        }

        /// <summary>
        /// 保存查询到的数据
        /// </summary>
        /// <returns></returns>
        public static List<string[]> SaveData(SQLiteDataReader sdr,List<string[]> list)
        {
            list.Clear();
            while (sdr.Read())
            {
                
                string[] strings = new string[sdr.FieldCount];
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    strings[i] = sdr[i].ToString();
                }
                list.Add(strings);
            }
            return list;
        }

        

    }
}
