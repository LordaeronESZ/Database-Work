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
    public partial class Admin_BManager_Search : Form
    {
        public Admin_BManager_Search()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 图书编号限制输入英文和数字
        /// </summary>
        private void Textbox_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            int k = e.KeyChar;
            if ((k < '0' || k > '9') && k != '\b' && (k < 'a' || k > 'z') && (k < 'A' || k > 'Z'))
                e.Handled = true;
        }
        /// <summary>
        /// 查找按钮
        /// </summary>
        private void Btn_Search(object sender, EventArgs e)
        {
            Database db = new Database();
            string sql = $"select * from B where BNO='{textBox_input.Text}'";
            try
            {
                SqlDataReader sqlDr = db.DatabaseRead(sql);
                string[] contents = new string[7];
                if (!sqlDr.HasRows)
                    label2.Text = "未查询到任何图书信息！";
                while (sqlDr.Read())
                {
                    for (int i = 0; i < 7; i++)
                    {
                        contents[i] = sqlDr[i].ToString();
                    }
                    string str = $"图书编号：{sqlDr[0].ToString()}，图书名称：{sqlDr[1].ToString()}，" +
                        $"出版日期：{sqlDr[2].ToString()}，图书出版社：{sqlDr[3].ToString()}，" +
                        $"图书存放位置：{sqlDr[4].ToString()}，图书总数量：{sqlDr[5].ToString()}，图书剩余数量：{sqlDr[6].ToString()}";
                    label2.Text = str;
                }
            }
            catch (Exception)
            {
                label2.Text = "查询失败！";
            }
            db.DatabaseClose();
        }
    }
}
