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
    public partial class Admin_SManager : UserControl
    {
        public Admin_SManager()
        {
            InitializeComponent();
        }

        private void Admin_SManager_Load(object sender, EventArgs e)
        {
            DataGridView_Display();
        }
        /// <summary>
        /// 表格显示学生信息，按学号排序
        /// </summary>
        private void DataGridView_Display()
        {
            dataGridView1.Rows.Clear();
            Database db = new Database();
            string sql = "select * from S";
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
        /// 删除按钮
        /// </summary>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string SNO = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            string sql = $"delete from S where SNO='{SNO}'";
            try
            {
                DialogResult dr = MessageBox.Show("确认要删除学生吗？", "确认",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
                db.DatabaseExecute(sql);
                MessageBox.Show("删除完成！");
                DataGridView_Display();
            }
            catch (Exception)
            {
                MessageBox.Show("删除失败，请重试！", "删除失败！",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.DatabaseClose();
        }
        /// <summary>
        /// 修改按钮
        /// </summary>
        private void Btn_Modify_Click(object sender, EventArgs e)
        {
            string SNA = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string SDE = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string SSP = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string SNO = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            string SPW = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Admin_SManager_Modify admin_SManager_Modify = new Admin_SManager_Modify(
                SNA, SDE, SSP, SNO, SPW);
            admin_SManager_Modify.ShowDialog();
        }

    }
}
