using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 数据库课设
{
    public partial class Student_SB : UserControl
    {
        private string SNO;
        public Student_SB()
        {
            InitializeComponent();
        } 
        public Student_SB(string SNO)
        {
            this.SNO = SNO;
            InitializeComponent();
        }
        private void Student_SB_Load(object sender, EventArgs e)
        {
            DataGridView_Display();
        }
        /// <summary>
        /// 表格显示图书信息，按学号排序
        /// </summary>
        private void DataGridView_Display()
        {
            dataGridView1.Rows.Clear();
            Database db = new Database();
            string sql = "select * from B";
            SqlDataReader sqlDr = db.DatabaseRead(sql);
            string[] contents = new string[7];
            while (sqlDr.Read())
            {
                for (int i = 0; i < 7; i++)
                {
                    contents[i] = sqlDr[i].ToString();
                }
                dataGridView1.Rows.Add(contents);
            }
            db.DatabaseClose();
        }
        /// <summary>
        /// 刷新按钮
        /// </summary>
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DataGridView_Display();
        }
        /// <summary>
        /// 查找按钮
        /// </summary>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Admin_BManager_Search admin_BManager_Search = new Admin_BManager_Search();
            admin_BManager_Search.ShowDialog();
        }
        /// <summary>
        /// 借阅按钮
        /// </summary>
        private void Btn_Borrow_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string BNO = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //获取系统时间并格式转化
            DateTime now = System.DateTime.Now;
            int n_year = Convert.ToInt32(now.Year);
            int n_month = Convert.ToInt32(now.Month);
            int n_day = Convert.ToInt32(now.Day);
            int n_hour = Convert.ToInt32(now.Hour);
            int n_minute = Convert.ToInt32(now.Minute);
            int n_second = Convert.ToInt32(now.Second);
            string BDA = String.Format("{0:D4}-{1:D2}{2:D2}-{3:D2}{4:D2}{5:D2}",
                n_year, n_month, n_day, n_hour, n_minute, n_second);
            if(n_month >= 11)
            {
                n_month = (n_month + 2) % 12;
                n_year += 1;
            }
            else
                n_month += 2;
            string RDA = String.Format("{0:D4}-{1:D2}{2:D2}-{3:D2}{4:D2}{5:D2}",
                n_year, n_month, n_day, n_hour, n_minute, n_second);
            float PNU = 0;
            int BNU = 1;
            string sql = $"insert into SB values('{SNO}','{BNO}','{BDA}','{RDA}',{PNU},{BNU})";
            try
            {
                //如果书籍已被借完
                string sql6 = $"select BCN from B where BNO='{BNO}'";
                SqlDataReader sqlDr3 = db.DatabaseRead(sql6);
                while (sqlDr3.Read())
                {
                    if(Convert.ToInt32(sqlDr3[0]) <= 0)
                    {
                        MessageBox.Show("书籍已被借完，借阅失败！", "借阅失败！",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //如果超过借书上限，则无法借阅
                string sql5 = $"select SCN from S where SNO = '{SNO}'";
                SqlDataReader sqlDr2 = db.DatabaseRead(sql5);
                while (sqlDr2.Read())
                {
                    if(Convert.ToInt32(sqlDr2[0]) <= 0)
                    {
                        MessageBox.Show("超过借书上限，借阅失败！", "借阅失败！",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //如果存在罚金未缴，则无法借阅
                string sql2 = $"select PNU from SB where SNO='{SNO}'";
                SqlDataReader sqlDr = db.DatabaseRead(sql2);
                while (sqlDr.Read())
                {
                    if (!sqlDr[0].ToString().Equals("0"))
                    {
                        MessageBox.Show("罚金未缴清，禁止借阅！", "借阅失败！",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //将借阅关系插入表中
                db.DatabaseExecute(sql);
                MessageBox.Show("借阅成功！");
                //图书剩余数量减少，可借书籍数量减少
                string sql3 = $"update B set BCN = BCN - 1 where BNO = '{BNO}'";
                string sql4 = $"update S set SCN = SCN - 1 where SNO = '{SNO}'";
                db.DatabaseExecute(sql3);
                db.DatabaseExecute(sql4);
                DataGridView_Display();
            }
            catch (Exception)
            {
                MessageBox.Show("借阅失败，请重试！", "借阅失败！",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.DatabaseClose();
        }
    }
}
