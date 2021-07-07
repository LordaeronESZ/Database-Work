using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 数据库课设
{
    public partial class Admin_BManager_Delete : Form
    {
        public Admin_BManager_Delete()
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
        /// 删除按钮
        /// </summary>
        private void Btn_Delete_CLick(object sender, EventArgs e)
        {
            Database db = new Database();
            string sql = $"delete from B where BNO='{textBox_input.Text}'";
            try
            {
                db.DatabaseExecute(sql);
                MessageBox.Show("删除成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("删除失败，请检查后重试！", "删除失败！",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.DatabaseClose();
        }
    }
}
