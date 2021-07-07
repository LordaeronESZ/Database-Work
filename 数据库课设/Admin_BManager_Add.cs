using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 数据库课设
{
    public partial class Admin_BManager_Add : Form
    {
        public Admin_BManager_Add()
        {
            InitializeComponent();
        }

        private void Admin_BManager_Add_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 图书编号限制输入英文和数字
        /// </summary>
        private void Textbox_BNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            int k = e.KeyChar;
            if ((k < '0' || k > '9') && k != '\b' && (k < 'a' || k > 'z') && (k < 'A' || k > 'Z'))
                e.Handled = true;
        }
        /// <summary>
        /// 根据年份和月份更改天数
        /// </summary>
        private void Combobox_Month_Changed(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            comboBox_BDA_Day.Items.Clear();
            switch (comboBox.SelectedIndex)
            {
                case 0:
                case 2:
                case 4:
                case 6:
                case 7:
                case 9:
                case 11:
                    comboBox_BDA_Day.Items.AddRange(new object[]{
                        "1","2","3","4","5","6","7","8","9","10","11","12","13","14",
                        "15","16","17","18","19","20","21","22","23","24","25","26","27",
                        "28","29","30","31"
                    }); break;
                case 1:
                    if (comboBox_BDA_Year.SelectedIndex == 0 || comboBox_BDA_Year.SelectedIndex == 4 ||
                        comboBox_BDA_Year.SelectedIndex == 8 || comboBox_BDA_Year.SelectedIndex == 12 ||
                        comboBox_BDA_Year.SelectedIndex == 16 || comboBox_BDA_Year.SelectedIndex == 20)
                        comboBox_BDA_Day.Items.AddRange(new object[]{
                        "1","2","3","4","5","6","7","8","9","10","11","12","13","14",
                        "15","16","17","18","19","20","21","22","23","24","25","26","27",
                        "28","29"
                        });
                    else
                        comboBox_BDA_Day.Items.AddRange(new object[]{
                        "1","2","3","4","5","6","7","8","9","10","11","12","13","14",
                        "15","16","17","18","19","20","21","22","23","24","25","26","27",
                        "28"
                        }); break;
                default:
                    comboBox_BDA_Day.Items.AddRange(new object[]{
                        "1","2","3","4","5","6","7","8","9","10","11","12","13","14",
                        "15","16","17","18","19","20","21","22","23","24","25","26","27",
                        "28","29","30"
                        });
                    break;
            }
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //combobox未选择
            if(comboBox_BDA_Day.SelectedIndex == -1 || comboBox_BDA_Month.SelectedIndex == -1
                || comboBox_BDA_Year.SelectedIndex == -1 || comboBox_BPL_1.SelectedIndex == -1
                || comboBox_BPL_2.SelectedIndex == -1)
            {
                MessageBox.Show("下拉框必须全部选中！", "添加失败！",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //剩余数量大于总数量
            if(numericUpDown_BCN.Value > numericUpDown_BNU.Value)
            {
                MessageBox.Show("剩余数量不能大于总数量！", "添加失败！",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Database db = new Database();
            string BNO = textBox_BNO.Text;
            string BNA = textBox_BNA.Text;
            string BPU = textBox_BPU.Text;
            string BDA = comboBox_BDA_Year.Text + "-" + comboBox_BDA_Month.Text + "-" + comboBox_BDA_Day.Text;
            string BPL_3 = String.Format("{0:D4}", Convert.ToInt32(numericUpDown1.Value));
            string BPL = comboBox_BPL_1.Text + "/" + comboBox_BPL_2.Text + "/" + BPL_3;
            int BNU = Convert.ToInt32(numericUpDown_BNU.Value);
            int BCN = Convert.ToInt32(numericUpDown_BCN.Value);
            string sql = $"insert into B values('{BNO}','{BNA}'," +
                $"'{BDA}','{BPU}','{BPL}','{BNU}','{BCN}')";
            try
            {
                db.DatabaseExecute(sql);
                MessageBox.Show("添加成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("添加失败，图书编号可能重复！", "添加失败！",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.DatabaseClose();
        }
    }
}
