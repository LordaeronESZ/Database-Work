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
    public partial class Admin_BManager : UserControl
    {
        public Admin_BManager()
        {
            InitializeComponent();
        }
        private void Admin_BManager_Load(object sender, EventArgs e)
        {
            //加载窗口时显示图书数据到表格
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
                for(int i = 0; i < 7; i++)
                {
                    contents[i] = sqlDr[i].ToString();
                }
                dataGridView1.Rows.Add(contents);
            }
            db.DatabaseClose();
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            Admin_BManager_Add admin_BManager_Add = new Admin_BManager_Add();
            admin_BManager_Add.ShowDialog();
        }
        /// <summary>
        /// 修改按钮
        /// </summary>
        private void Btn_Modify_Click(object sender, EventArgs e)
        {
            string BNO = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string BNA = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string BDA = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string BPU = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string BNL = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            int BNU = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
            int BCN = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
            Admin_BManager_Modify admin_BManager_Modify = new Admin_BManager_Modify(
                BNO, BNA, BDA, BPU, BNL, BNU, BCN);
            admin_BManager_Modify.ShowDialog();
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Admin_BManager_Delete admin_BManager_Delete = new Admin_BManager_Delete();
            admin_BManager_Delete.ShowDialog();
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
        /// 刷新按钮
        /// </summary>
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DataGridView_Display();
        }
    }
}
