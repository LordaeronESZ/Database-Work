using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 数据库课设
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 登录
        /// </summary>
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            //学生登录
            if (radioButton_student.Checked)
            {
                Database db = new Database();
                SqlDataReader sqlDr = db.DatabaseRead("" +
                    "select SNO,SPW from S");
                string iAccount = textBox_account.Text;
                string iPassword = textBox_password.Text;
                bool isSuccess = false;
                while (sqlDr.Read())
                {
                    if(sqlDr["SNO"].ToString().Equals(iAccount)
                        && sqlDr["SPW"].ToString().Equals(iPassword))
                    {
                        MessageBox.Show("登录成功！");
                        isSuccess = true;
                        //关闭当前窗口，弹出学生界面
                        string SNO = iAccount;
                        Student student = new Student(this, SNO);
                        student.Show();
                    }
                }
                if (!isSuccess)
                {
                    MessageBox.Show("登陆失败，请重试！", "登陆失败！",
                        MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                db.DatabaseClose();
            }
            //管理员登录
            else if (radioButton_admin.Checked)
            {
                Database db = new Database();
                SqlDataReader sqlDr = db.DatabaseRead("" +
                    "select * from A");
                string iAccount = textBox_account.Text;
                string iPassword = textBox_password.Text;
                bool isSuccess = false;
                while (sqlDr.Read())
                {
                    if(sqlDr["ANO"].ToString().Equals(iAccount) 
                        && sqlDr["APW"].ToString().Equals(iPassword))
                    {
                        MessageBox.Show("登录成功！");
                        isSuccess = true;
                        //关闭当前窗口，弹出管理员界面
                        Admin admin = new Admin(this);
                        admin.Show();
                    }
                }
                if (!isSuccess)
                {
                    MessageBox.Show("登陆失败，请重试！", "登陆失败！",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.DatabaseClose();
            }
        }
        /// <summary>
        /// 注册
        /// </summary>
        private void Btn_Regist_Click(object sender, EventArgs e)
        {
            Regist regist = new Regist();
            regist.ShowDialog();
        }
    }
}
