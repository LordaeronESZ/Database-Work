
namespace 数据库课设
{
    partial class Admin_BManager_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_BNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_BNO = new System.Windows.Forms.Label();
            this.label_BNA = new System.Windows.Forms.Label();
            this.textBox_BNA = new System.Windows.Forms.TextBox();
            this.label_BPU = new System.Windows.Forms.Label();
            this.textBox_BPU = new System.Windows.Forms.TextBox();
            this.label_BDA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.numericUpDown_BNU = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_BCN = new System.Windows.Forms.NumericUpDown();
            this.comboBox_BDA_Year = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_BDA_Month = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_BDA_Day = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_BPL_2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_BPL_1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_BNO
            // 
            this.textBox_BNO.Location = new System.Drawing.Point(178, 121);
            this.textBox_BNO.MaxLength = 6;
            this.textBox_BNO.Name = "textBox_BNO";
            this.textBox_BNO.Size = new System.Drawing.Size(527, 27);
            this.textBox_BNO.TabIndex = 0;
            this.textBox_BNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_BNO_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("幼圆", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 99);
            this.label1.TabIndex = 1;
            this.label1.Text = "请 输 入 添 加 图 书 的 信 息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_BNO
            // 
            this.label_BNO.AutoSize = true;
            this.label_BNO.Font = new System.Drawing.Font("小米兰亭", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_BNO.Location = new System.Drawing.Point(59, 121);
            this.label_BNO.Name = "label_BNO";
            this.label_BNO.Size = new System.Drawing.Size(96, 24);
            this.label_BNO.TabIndex = 2;
            this.label_BNO.Text = "图书编号：";
            // 
            // label_BNA
            // 
            this.label_BNA.AutoSize = true;
            this.label_BNA.Font = new System.Drawing.Font("小米兰亭", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_BNA.Location = new System.Drawing.Point(59, 186);
            this.label_BNA.Name = "label_BNA";
            this.label_BNA.Size = new System.Drawing.Size(96, 24);
            this.label_BNA.TabIndex = 4;
            this.label_BNA.Text = "图书名称：";
            // 
            // textBox_BNA
            // 
            this.textBox_BNA.Location = new System.Drawing.Point(178, 186);
            this.textBox_BNA.MaxLength = 20;
            this.textBox_BNA.Name = "textBox_BNA";
            this.textBox_BNA.Size = new System.Drawing.Size(527, 27);
            this.textBox_BNA.TabIndex = 3;
            // 
            // label_BPU
            // 
            this.label_BPU.AutoSize = true;
            this.label_BPU.Font = new System.Drawing.Font("小米兰亭", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_BPU.Location = new System.Drawing.Point(58, 254);
            this.label_BPU.Name = "label_BPU";
            this.label_BPU.Size = new System.Drawing.Size(114, 24);
            this.label_BPU.TabIndex = 6;
            this.label_BPU.Text = "图书出版社：";
            // 
            // textBox_BPU
            // 
            this.textBox_BPU.Location = new System.Drawing.Point(178, 254);
            this.textBox_BPU.MaxLength = 20;
            this.textBox_BPU.Name = "textBox_BPU";
            this.textBox_BPU.Size = new System.Drawing.Size(527, 27);
            this.textBox_BPU.TabIndex = 5;
            // 
            // label_BDA
            // 
            this.label_BDA.AutoSize = true;
            this.label_BDA.Font = new System.Drawing.Font("小米兰亭", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_BDA.Location = new System.Drawing.Point(59, 321);
            this.label_BDA.Name = "label_BDA";
            this.label_BDA.Size = new System.Drawing.Size(132, 24);
            this.label_BDA.TabIndex = 7;
            this.label_BDA.Text = "图书出版日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("小米兰亭", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(59, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "图书存放位置：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("小米兰亭", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(58, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "图书总数量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("小米兰亭", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(404, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "图书剩余数量：";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(330, 495);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(108, 37);
            this.button_Add.TabIndex = 11;
            this.button_Add.Text = "添 加";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // numericUpDown_BNU
            // 
            this.numericUpDown_BNU.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_BNU.Location = new System.Drawing.Point(200, 437);
            this.numericUpDown_BNU.Name = "numericUpDown_BNU";
            this.numericUpDown_BNU.ReadOnly = true;
            this.numericUpDown_BNU.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown_BNU.TabIndex = 12;
            // 
            // numericUpDown_BCN
            // 
            this.numericUpDown_BCN.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_BCN.Location = new System.Drawing.Point(555, 437);
            this.numericUpDown_BCN.Name = "numericUpDown_BCN";
            this.numericUpDown_BCN.ReadOnly = true;
            this.numericUpDown_BCN.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown_BCN.TabIndex = 13;
            // 
            // comboBox_BDA_Year
            // 
            this.comboBox_BDA_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BDA_Year.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_BDA_Year.FormattingEnabled = true;
            this.comboBox_BDA_Year.IntegralHeight = false;
            this.comboBox_BDA_Year.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000"});
            this.comboBox_BDA_Year.Location = new System.Drawing.Point(197, 321);
            this.comboBox_BDA_Year.MaxDropDownItems = 12;
            this.comboBox_BDA_Year.Name = "comboBox_BDA_Year";
            this.comboBox_BDA_Year.Size = new System.Drawing.Size(117, 28);
            this.comboBox_BDA_Year.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "年";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(502, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "月";
            // 
            // comboBox_BDA_Month
            // 
            this.comboBox_BDA_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BDA_Month.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_BDA_Month.FormattingEnabled = true;
            this.comboBox_BDA_Month.IntegralHeight = false;
            this.comboBox_BDA_Month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox_BDA_Month.Location = new System.Drawing.Point(369, 321);
            this.comboBox_BDA_Month.MaxDropDownItems = 12;
            this.comboBox_BDA_Month.Name = "comboBox_BDA_Month";
            this.comboBox_BDA_Month.Size = new System.Drawing.Size(117, 28);
            this.comboBox_BDA_Month.TabIndex = 16;
            this.comboBox_BDA_Month.SelectedIndexChanged += new System.EventHandler(this.Combobox_Month_Changed);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(688, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "日";
            // 
            // comboBox_BDA_Day
            // 
            this.comboBox_BDA_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BDA_Day.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_BDA_Day.FormattingEnabled = true;
            this.comboBox_BDA_Day.IntegralHeight = false;
            this.comboBox_BDA_Day.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_BDA_Day.Location = new System.Drawing.Point(555, 321);
            this.comboBox_BDA_Day.MaxDropDownItems = 12;
            this.comboBox_BDA_Day.Name = "comboBox_BDA_Day";
            this.comboBox_BDA_Day.Size = new System.Drawing.Size(117, 28);
            this.comboBox_BDA_Day.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(688, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "号";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(502, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "柜";
            // 
            // comboBox_BPL_2
            // 
            this.comboBox_BPL_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BPL_2.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_BPL_2.FormattingEnabled = true;
            this.comboBox_BPL_2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08"});
            this.comboBox_BPL_2.Location = new System.Drawing.Point(369, 382);
            this.comboBox_BPL_2.Name = "comboBox_BPL_2";
            this.comboBox_BPL_2.Size = new System.Drawing.Size(117, 28);
            this.comboBox_BPL_2.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(330, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "楼";
            // 
            // comboBox_BPL_1
            // 
            this.comboBox_BPL_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BPL_1.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_BPL_1.FormattingEnabled = true;
            this.comboBox_BPL_1.Items.AddRange(new object[] {
            "1F",
            "2F",
            "3F",
            "4F"});
            this.comboBox_BPL_1.Location = new System.Drawing.Point(197, 382);
            this.comboBox_BPL_1.Name = "comboBox_BPL_1";
            this.comboBox_BPL_1.Size = new System.Drawing.Size(117, 28);
            this.comboBox_BPL_1.TabIndex = 20;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(555, 382);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(117, 27);
            this.numericUpDown1.TabIndex = 26;
            // 
            // Admin_BManager_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox_BPL_2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox_BPL_1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_BDA_Day);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_BDA_Month);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_BDA_Year);
            this.Controls.Add(this.numericUpDown_BCN);
            this.Controls.Add(this.numericUpDown_BNU);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_BDA);
            this.Controls.Add(this.label_BPU);
            this.Controls.Add(this.textBox_BPU);
            this.Controls.Add(this.label_BNA);
            this.Controls.Add(this.textBox_BNA);
            this.Controls.Add(this.label_BNO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_BNO);
            this.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin_BManager_Add";
            this.Text = "添加图书";
            this.Load += new System.EventHandler(this.Admin_BManager_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_BNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_BNO;
        private System.Windows.Forms.Label label_BNA;
        private System.Windows.Forms.TextBox textBox_BNA;
        private System.Windows.Forms.Label label_BPU;
        private System.Windows.Forms.TextBox textBox_BPU;
        private System.Windows.Forms.Label label_BDA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.NumericUpDown numericUpDown_BNU;
        private System.Windows.Forms.NumericUpDown numericUpDown_BCN;
        private System.Windows.Forms.ComboBox comboBox_BDA_Year;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_BDA_Month;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_BDA_Day;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_BPL_2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_BPL_1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}