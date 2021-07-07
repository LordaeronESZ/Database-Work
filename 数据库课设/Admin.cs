using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 数据库课设
{
    public partial class Admin : Form
    {
        private Form1 mainForm;
        private Admin_BManager BManager;
        private Admin_SManager SManager;
        public Admin(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            form1.Hide();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            BManager = new Admin_BManager();
            SManager = new Admin_SManager();
            //默认显示图书管理
            BManager.Show();
            panel1.Controls.Add(BManager);
        }
        /// <summary>
        /// 窗口关闭后将登录窗口关闭
        /// </summary>
        private void Admin_Close(object sender, EventArgs e)
        {
            mainForm.Close();
        }
        /// <summary>
        /// 菜单栏点击图书管理
        /// </summary>
        private void MenuTrip_BManager_Click(object sender, EventArgs e)
        {
            BManager.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(BManager);
        }
        /// <summary>
        /// 菜单栏点击学生管理
        /// </summary>
        private void MenuTrip_SManager_Click(object sender, EventArgs e)
        {
            SManager.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(SManager);
        }
        /// <summary>
        /// 菜单栏点击帮助
        /// </summary>
        private void MenuTrip_Help_Click(object sender, EventArgs e)
        {
            Admin_Help admin_Help = new Admin_Help();
            admin_Help.ShowDialog();
        }
    }
}
