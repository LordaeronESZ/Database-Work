using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace 数据库课设
{
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
        }
        private void Regist_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 专业下拉框
        /// </summary>
        private void Combobox_Dept_ValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            comboBox_profession.Items.Clear();
            switch (comboBox.SelectedIndex)
            {
                case 0: comboBox_profession.Items.AddRange(new object[]
                {
                    "食品科学与工程",
                    "食品质量与安全"
                }); break;
                case 1:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "生物工程",
                    "生物技术",
                    "酿酒工程"
                }); break;
                case 2:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "微电子科学与工程",
                    "电气工程及其自动化",
                    "自动化",
                    "通信工程",
                    "物联网工程"
                }); break;
                case 3:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "过程装备与控制工程",
                    "机械工程",
                    "包装工程",
                    "机械电子工程",
                    "应用化学"
                }); break;
                case 4:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "高分子材料与工程",
                    "化学工程与工艺"
                }); break;
                case 5:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "视觉传达设计",
                    "环境设计",
                    "产品设计",
                    "工业设计",
                    "美术学",
                    "公共艺术",
                    "服装设计与工程",
                    "服装与服饰设计",
                    "数字媒体艺术",
                    "表演"
                }); break;
                case 6:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "国际经济与贸易",
                    "金融学",
                    "工业工程",
                    "工商管理",
                    "会计学"
                }); break;
                case 7:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "轻化工程",
                    "纺织工程"
                }); break;
                case 8:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "土木工程",
                    "环境工程",
                    "工程管理"
                }); break;
                case 9:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "法学",
                    "社会工作"
                }); break;
                case 10:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "英语",
                    "日语"
                }); break;
                case 11:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "信息与计算科学",
                    "光电信息科学工程"
                }); break;
                case 12:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "汉语言文学",
                    "教育技术学",
                    "小学教育",
                    "音乐学",
                    "舞蹈编导"
                }); break;
                case 13:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "制药工程",
                    "药学",
                    "护理学",
                    "临床医学"
                }); break;
                case 14:
                    comboBox_profession.Items.AddRange(new object[]
                {
                    "计算机科学与技术",
                    "数字媒体技术"
                }); break;
                default: 
                    break;
            }
            comboBox_profession.SelectedIndex = 0;
        }
        /// <summary>
        /// 姓名框限制输入汉字
        /// </summary>
        private void Textbox_Name_ValueChanged(object sender, KeyPressEventArgs e)
        {
            Regex rg = new Regex("^[\u4e00-\u9fa5]$");  //正则表达式
            if (!rg.IsMatch(e.KeyChar.ToString()) && e.KeyChar != '\b') //'\b'是退格键
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// 学号框限制输入10位，且为数字
        /// </summary>
        private void Text_Sno_ValueChanged(object sender, KeyPressEventArgs e)
        {
            int k = e.KeyChar;
            if ((k < '0' || k > '9') && k != '\b')
                e.Handled = true;
        }
        private void Text_Sno_KeyUp(object sender, EventArgs e)
        {
            if (textBox_sno.TextLength < 10)
            {
                label_snoInfo.Text = "学号必须为10位！";
            }
            else
                label_snoInfo.Text = "";
        }
        /// <summary>
        /// 查看密码选项
        /// </summary>
        private void Checkbox_SeePwd1_Choosed(object sender, EventArgs e)
        {
            if (checkBox_seePwd1.Checked)
                textBox_password.UseSystemPasswordChar = false;
            else
                textBox_password.UseSystemPasswordChar = true;
        }
        private void Checkbox_SeePwd2_Choosed(object sender, EventArgs e)
        {
            if (checkBox_seePwd2.Checked)
                textBox_surePwd.UseSystemPasswordChar = false;
            else
                textBox_surePwd.UseSystemPasswordChar = true;
        }
        /// <summary>
        /// 注册按钮，检查学号、密码是否正确，正确则插入数据库
        /// </summary>
        private void Btn_Regist_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string dept = comboBox_dept.Text;
            string profession = comboBox_profession.Text;
            string sno = textBox_sno.Text;
            string password = textBox_password.Text;
            Database db = new Database();
            //姓名是否为空
            if (textBox_name.TextLength == 0)
            {
                MessageBox.Show("姓名不能为空！", "注册失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //学号是否为10位
            if (textBox_sno.TextLength < 10)
            {
                MessageBox.Show("学号必须为10位！", "注册失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //学号是否已被注册
            SqlDataReader sqlDr = db.DatabaseRead("select SNO from S");
            while (sqlDr.Read())
            {
                if (sqlDr["SNO"].ToString().Equals(sno))
                {
                    MessageBox.Show("该学号已被注册！", "注册失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //检测密码是否正确
            if (!textBox_password.Text.Equals(textBox_surePwd.Text))
            {
                MessageBox.Show("两次密码不一致！", "注册失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = String.Format("insert into S values('{0}','{1}','{2}',20,20,'{3}','{4}')",
                name, dept, profession, sno, password);
            //插入注册账号
            try
            {
                db.DatabaseExecute(sql);
                MessageBox.Show("已完成注册！", "注册成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("注册未完成，请重试！", "注册失败！", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            db.DatabaseClose();
        }
        /// <summary>
        /// 密码框限制输入字母和数字
        /// </summary>
        private void Textbox_Pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            int k = e.KeyChar;
            if ((k < '0' || k > '9') && k != '\b' && (k < 'a' || k > 'z') && (k < 'A' || k > 'Z'))
                e.Handled = true;
        }
    }
}
