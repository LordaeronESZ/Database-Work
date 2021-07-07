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
    public partial class Student : Form
    {
        private Form1 mainForm;
        private string SNO;
        private Student_SB student_SB;
        private Student_SBM student_SBM;
        public Student()
        {
            InitializeComponent();
        }
        public Student(Form1 form1, string SNO)
        {
            InitializeComponent();
            mainForm = form1;
            this.SNO = SNO;
            mainForm.Hide();
        }
        private void Student_Load(object sender, EventArgs e)
        {
            student_SB = new Student_SB(SNO);
            student_SBM = new Student_SBM(SNO);
            //默认显示已借图书
            student_SBM.Show();
            panel_display.Controls.Add(student_SBM);
            //将罚金数据更新
            Database db = new Database();
            string sql = $"select RDA,SNO,BNO,BDA from SB where SNO='{SNO}'";
            SqlDataReader sqlDr = db.DatabaseRead(sql);
            DateTime now = System.DateTime.Now;
            while (sqlDr.Read())
            {
                string year = sqlDr[0].ToString().Substring(0, 4);
                string month = sqlDr[0].ToString().Substring(5, 2);
                string day = sqlDr[0].ToString().Substring(7, 2);
                TimeSpan timeSpan = now - DateTime.Parse($"{year}-{month}-{day}");
                double pastDays = timeSpan.TotalDays;
                if(pastDays > 0)
                {
                    double punish = pastDays* 0.02;
                    string sql2 = $"update SB set PNU={punish} where SNO='{sqlDr[1].ToString()}' " +
                        $"and BNO='{sqlDr[2].ToString()}' and BDA='{sqlDr[3].ToString()}'";
                    try
                    {
                        db.DatabaseExecute(sql2);
                    }
                    catch (Exception)
                    {
                        
                    }
                }
            }
            db.DatabaseClose();
        }
        /// <summary>
        /// 窗口关闭后将登录窗口关闭
        /// </summary>
        private void Student_Form_Close(object sender, EventArgs e)
        {
            mainForm.Close();
        }
        /// <summary>
        /// 菜单栏点击已借图书
        /// </summary>
        private void Student_SBM_Click(object sender, EventArgs e)
        {
            student_SBM.Show();
            panel_display.Controls.Clear();
            panel_display.Controls.Add(student_SBM);
        }
        /// <summary>
        /// 菜单栏点击图书借阅
        /// </summary>
        private void Student_SB_Click(object sender, EventArgs e)
        {
            student_SB.Show();
            panel_display.Controls.Clear();
            panel_display.Controls.Add(student_SB);
        }
        /// <summary>
        /// 菜单栏点击关于按钮
        /// </summary>
        private void Student_About_Click(object sender, EventArgs e)
        {
            Admin_Help admin_Help = new Admin_Help();
            admin_Help.ShowDialog();
        }
    }
}
