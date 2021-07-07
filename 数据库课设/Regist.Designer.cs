
namespace 数据库课设
{
    partial class Regist
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_dept = new System.Windows.Forms.Label();
            this.label_profession = new System.Windows.Forms.Label();
            this.label_sno = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_sno = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.comboBox_dept = new System.Windows.Forms.ComboBox();
            this.comboBox_profession = new System.Windows.Forms.ComboBox();
            this.button_regist = new System.Windows.Forms.Button();
            this.label_surePwd = new System.Windows.Forms.Label();
            this.textBox_surePwd = new System.Windows.Forms.TextBox();
            this.label_snoInfo = new System.Windows.Forms.Label();
            this.checkBox_seePwd1 = new System.Windows.Forms.CheckBox();
            this.checkBox_seePwd2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(-2, -1);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(781, 160);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "欢 迎 注 册 图 书 借 阅 账 号";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(46, 208);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(72, 27);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "姓名 ：";
            // 
            // label_dept
            // 
            this.label_dept.AutoSize = true;
            this.label_dept.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_dept.Location = new System.Drawing.Point(258, 210);
            this.label_dept.Name = "label_dept";
            this.label_dept.Size = new System.Drawing.Size(72, 27);
            this.label_dept.TabIndex = 2;
            this.label_dept.Text = "系别 ：";
            // 
            // label_profession
            // 
            this.label_profession.AutoSize = true;
            this.label_profession.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_profession.Location = new System.Drawing.Point(526, 210);
            this.label_profession.Name = "label_profession";
            this.label_profession.Size = new System.Drawing.Size(72, 27);
            this.label_profession.TabIndex = 3;
            this.label_profession.Text = "专业 ：";
            // 
            // label_sno
            // 
            this.label_sno.AutoSize = true;
            this.label_sno.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_sno.Location = new System.Drawing.Point(46, 288);
            this.label_sno.Name = "label_sno";
            this.label_sno.Size = new System.Drawing.Size(72, 27);
            this.label_sno.TabIndex = 4;
            this.label_sno.Text = "学号 ：";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_password.Location = new System.Drawing.Point(46, 346);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(72, 27);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "密码 ：";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(117, 210);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(120, 27);
            this.textBox_name.TabIndex = 6;
            this.textBox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_Name_ValueChanged);
            // 
            // textBox_sno
            // 
            this.textBox_sno.Location = new System.Drawing.Point(168, 290);
            this.textBox_sno.MaxLength = 10;
            this.textBox_sno.Name = "textBox_sno";
            this.textBox_sno.Size = new System.Drawing.Size(469, 27);
            this.textBox_sno.TabIndex = 7;
            this.textBox_sno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Sno_ValueChanged);
            this.textBox_sno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_Sno_KeyUp);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(168, 346);
            this.textBox_password.MaxLength = 20;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(469, 27);
            this.textBox_password.TabIndex = 8;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_Pwd_KeyPress);
            // 
            // comboBox_dept
            // 
            this.comboBox_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dept.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_dept.FormattingEnabled = true;
            this.comboBox_dept.Items.AddRange(new object[] {
            "食品学院",
            "生物工程学院",
            "物联网工程学院",
            "机械工程学院",
            "化学与材料工程学院",
            "设计学院",
            "商学院",
            "纺织科学与工程学院",
            "环境与土木工程学院",
            "法学院",
            "外国语学院",
            "理学院",
            "人文学院",
            "医学院",
            "人工智能与计算机学院"});
            this.comboBox_dept.Location = new System.Drawing.Point(328, 210);
            this.comboBox_dept.Name = "comboBox_dept";
            this.comboBox_dept.Size = new System.Drawing.Size(175, 28);
            this.comboBox_dept.TabIndex = 9;
            this.comboBox_dept.SelectedIndexChanged += new System.EventHandler(this.Combobox_Dept_ValueChanged);
            // 
            // comboBox_profession
            // 
            this.comboBox_profession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_profession.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_profession.FormattingEnabled = true;
            this.comboBox_profession.Items.AddRange(new object[] {
            "食品科学与工程",
            "食品质量与安全"});
            this.comboBox_profession.Location = new System.Drawing.Point(601, 210);
            this.comboBox_profession.Name = "comboBox_profession";
            this.comboBox_profession.Size = new System.Drawing.Size(175, 28);
            this.comboBox_profession.TabIndex = 9;
            // 
            // button_regist
            // 
            this.button_regist.Font = new System.Drawing.Font("小米兰亭", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_regist.Location = new System.Drawing.Point(310, 480);
            this.button_regist.Name = "button_regist";
            this.button_regist.Size = new System.Drawing.Size(132, 39);
            this.button_regist.TabIndex = 10;
            this.button_regist.Text = "注 册";
            this.button_regist.UseVisualStyleBackColor = true;
            this.button_regist.Click += new System.EventHandler(this.Btn_Regist_Click);
            // 
            // label_surePwd
            // 
            this.label_surePwd.AutoSize = true;
            this.label_surePwd.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_surePwd.Location = new System.Drawing.Point(25, 396);
            this.label_surePwd.Name = "label_surePwd";
            this.label_surePwd.Size = new System.Drawing.Size(112, 27);
            this.label_surePwd.TabIndex = 5;
            this.label_surePwd.Text = "确认密码 ：";
            // 
            // textBox_surePwd
            // 
            this.textBox_surePwd.Location = new System.Drawing.Point(168, 396);
            this.textBox_surePwd.MaxLength = 20;
            this.textBox_surePwd.Name = "textBox_surePwd";
            this.textBox_surePwd.Size = new System.Drawing.Size(469, 27);
            this.textBox_surePwd.TabIndex = 8;
            this.textBox_surePwd.UseSystemPasswordChar = true;
            this.textBox_surePwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_Pwd_KeyPress);
            // 
            // label_snoInfo
            // 
            this.label_snoInfo.AutoSize = true;
            this.label_snoInfo.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_snoInfo.ForeColor = System.Drawing.Color.Red;
            this.label_snoInfo.Location = new System.Drawing.Point(652, 293);
            this.label_snoInfo.Name = "label_snoInfo";
            this.label_snoInfo.Size = new System.Drawing.Size(0, 20);
            this.label_snoInfo.TabIndex = 11;
            // 
            // checkBox_seePwd1
            // 
            this.checkBox_seePwd1.AutoSize = true;
            this.checkBox_seePwd1.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_seePwd1.Location = new System.Drawing.Point(652, 349);
            this.checkBox_seePwd1.Name = "checkBox_seePwd1";
            this.checkBox_seePwd1.Size = new System.Drawing.Size(91, 24);
            this.checkBox_seePwd1.TabIndex = 12;
            this.checkBox_seePwd1.Text = "显示密码";
            this.checkBox_seePwd1.UseVisualStyleBackColor = true;
            this.checkBox_seePwd1.CheckedChanged += new System.EventHandler(this.Checkbox_SeePwd1_Choosed);
            // 
            // checkBox_seePwd2
            // 
            this.checkBox_seePwd2.AutoSize = true;
            this.checkBox_seePwd2.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_seePwd2.Location = new System.Drawing.Point(652, 400);
            this.checkBox_seePwd2.Name = "checkBox_seePwd2";
            this.checkBox_seePwd2.Size = new System.Drawing.Size(91, 24);
            this.checkBox_seePwd2.TabIndex = 12;
            this.checkBox_seePwd2.Text = "显示密码";
            this.checkBox_seePwd2.UseVisualStyleBackColor = true;
            this.checkBox_seePwd2.CheckedChanged += new System.EventHandler(this.Checkbox_SeePwd2_Choosed);
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.checkBox_seePwd2);
            this.Controls.Add(this.checkBox_seePwd1);
            this.Controls.Add(this.label_snoInfo);
            this.Controls.Add(this.button_regist);
            this.Controls.Add(this.comboBox_profession);
            this.Controls.Add(this.comboBox_dept);
            this.Controls.Add(this.textBox_surePwd);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_sno);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_surePwd);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_sno);
            this.Controls.Add(this.label_profession);
            this.Controls.Add(this.label_dept);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Regist";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.Regist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_dept;
        private System.Windows.Forms.Label label_profession;
        private System.Windows.Forms.Label label_sno;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_sno;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.ComboBox comboBox_dept;
        private System.Windows.Forms.ComboBox comboBox_profession;
        private System.Windows.Forms.Button button_regist;
        private System.Windows.Forms.Label label_surePwd;
        private System.Windows.Forms.TextBox textBox_surePwd;
        private System.Windows.Forms.Label label_snoInfo;
        private System.Windows.Forms.CheckBox checkBox_seePwd1;
        private System.Windows.Forms.CheckBox checkBox_seePwd2;
    }
}