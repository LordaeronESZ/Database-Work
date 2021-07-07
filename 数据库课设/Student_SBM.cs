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
    public partial class Student_SBM : UserControl
    {
        private string SNO;
        public Student_SBM()
        {
            InitializeComponent();
        }
        public Student_SBM(string SNO)
        {
            this.SNO = SNO;
            InitializeComponent();
        }

        private void Student_SBM_Load(object sender, EventArgs e)
        {
            DataGridView_Display();
        }
        /// <summary>
        /// 表格显示借阅信息
        /// </summary>
        private void DataGridView_Display()
        {
            dataGridView1.Rows.Clear();
            Database db = new Database();
            string sql = "select B.BNO,BNA,BPL,SB.BDA,RDA,PNU,SB.BNU from S,B,SB " +
                $"where B.BNO = SB.BNO and S.SNO = SB.SNO and S.SNO = '{SNO}'";
            SqlDataReader sqlDr = db.DatabaseRead(sql);
            string[] contents = new string[7];
            while (sqlDr.Read())
            {
                for (int i = 0; i < 7; i++)
                {
                    if (i == 5)
                        contents[i] = String.Format("{0:F}", Convert.ToDouble(sqlDr[i]));
                    else
                        contents[i] = sqlDr[i].ToString();
                }
                dataGridView1.Rows.Add(contents);
            }
            db.DatabaseClose();
        }
        /// <summary>
        /// 归还按钮
        /// </summary>
        private void Btn_Return_Click(object sender, EventArgs e)
        {
            Return_Func();
        }
        private void Return_Func()
        {
            Database db = new Database();
            string BNO = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string BDA = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //如果存在罚款则无法归还，需要先缴清罚款
            string sql = $"delete from SB where SNO='{SNO}' and BNO='{BNO}' and BDA='{BDA}'";
            try
            {
                string sql2 = $"select PNU from SB where SNO='{SNO}' and BNO='{BNO}' and BDA='{BDA}'";
                SqlDataReader sqlDr = db.DatabaseRead(sql2);
                while (sqlDr.Read())
                {
                    if (!sqlDr[0].ToString().Equals("0"))
                    {
                        MessageBox.Show("罚金未缴清，禁止归还！", "归还失败！",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //图书数量增加，可借数量增加
                string sql3 = $"update B set BCN = BCN + 1 where BNO = '{BNO}'";
                string sql4 = $"update S set SCN = SCN + 1 where SNO = '{SNO}'";
                db.DatabaseExecute(sql3);
                db.DatabaseExecute(sql4);
                //删除借阅关系表
                db.DatabaseExecute(sql);
                MessageBox.Show("归还成功！");
                DataGridView_Display();
            }
            catch (Exception)
            {
                MessageBox.Show("归还失败，请重试！", "归还失败！",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.DatabaseClose();
        }
        /// <summary>
        /// 续借按钮
        /// </summary>
        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            //先归还
            Return_Func();
            //再借阅
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
            if (n_month >= 11)
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
                MessageBox.Show("续借成功！");
                //图书剩余数量减少
                string sql3 = $"update B set BCN = BCN - 1 where BNO = '{BNO}'";
                db.DatabaseExecute(sql3);
            }
            catch (Exception)
            {
                MessageBox.Show("续借失败，请重试！", "借阅失败！",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.DatabaseClose();
        }
        /// <summary>
        /// 交罚款按钮
        /// </summary>
        private void Btn_Punish_Click(object sender, EventArgs e)
        {
            //弹窗交罚款二维码
            DialogResult dr = MessageBox.Show("确认要缴清罚款吗？", "确认",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            //将罚款数更改
            string BNO = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string BDA = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string sql = $"update SB set PNU=0 where SNO='{SNO}' and BNO='{BNO}' and BDA='{BDA}'";
            Database db = new Database();
            try
            {
                db.DatabaseExecute(sql);
                MessageBox.Show("交罚款成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("交罚款失败，请重试！", "失败！",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
