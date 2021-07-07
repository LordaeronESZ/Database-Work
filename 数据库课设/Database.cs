using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace 数据库课设
{
    class Database
    {
        //数据库连接信息
        private string connectInfo = "server=DESKTOP-KIKMEQH;database=Library;uid=sa;pwd=123";
        public string ConnectInfo
        {
            get { return connectInfo; }
            set { connectInfo = value; }
        }
        SqlConnection sqlConn;
        /// <summary>
        /// 数据库开启
        /// </summary>
        public SqlConnection DatabaseOpen()
        {
            sqlConn = new SqlConnection(ConnectInfo);
            sqlConn.Open();
            return sqlConn;
        }
        /// <summary>
        /// 数据库命令
        /// </summary>
        public SqlCommand DatabaseCommand(string sql)
        {
            SqlCommand sqlCmd = new SqlCommand(sql, DatabaseOpen());
            return sqlCmd;
        }
        /// <summary>
        /// 数据库操作
        /// </summary>
        public int DatabaseExecute(string sql)
        {
            return DatabaseCommand(sql).ExecuteNonQuery();
        }
        /// <summary>
        /// 数据库查询
        /// </summary>
        public SqlDataReader DatabaseRead(string sql)
        {
            return DatabaseCommand(sql).ExecuteReader();
        }
        /// <summary>
        /// 数据库关闭
        /// </summary>
        public void DatabaseClose()
        {
            sqlConn.Close();
        }
    }
}
