using System;
namespace 数据库课设
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lable_login = new System.Windows.Forms.Label();
            this.label_account = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.radioButton_student = new System.Windows.Forms.RadioButton();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_login = new System.Windows.Forms.Button();
            this.button_regist = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lable_login
            // 
            this.lable_login.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lable_login.Location = new System.Drawing.Point(0, -2);
            this.lable_login.Name = "lable_login";
            this.lable_login.Size = new System.Drawing.Size(783, 171);
            this.lable_login.TabIndex = 2;
            this.lable_login.Text = "欢 迎 登 录 图 书 借 阅 管 理 系 统";
            this.lable_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_account.Location = new System.Drawing.Point(61, 176);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(72, 27);
            this.label_account.TabIndex = 3;
            this.label_account.Text = "账号 ：";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_password.Location = new System.Drawing.Point(61, 264);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(72, 27);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "密码 ：";
            // 
            // textBox_account
            // 
            this.textBox_account.Location = new System.Drawing.Point(167, 173);
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.Size = new System.Drawing.Size(508, 34);
            this.textBox_account.TabIndex = 5;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(167, 261);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(508, 34);
            this.textBox_password.TabIndex = 6;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // radioButton_student
            // 
            this.radioButton_student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_student.AutoSize = true;
            this.radioButton_student.Checked = true;
            this.radioButton_student.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_student.Location = new System.Drawing.Point(118, 15);
            this.radioButton_student.Name = "radioButton_student";
            this.radioButton_student.Size = new System.Drawing.Size(73, 31);
            this.radioButton_student.TabIndex = 7;
            this.radioButton_student.TabStop = true;
            this.radioButton_student.Text = "学生";
            this.radioButton_student.UseVisualStyleBackColor = true;
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_admin.Location = new System.Drawing.Point(415, 15);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(93, 31);
            this.radioButton_admin.TabIndex = 8;
            this.radioButton_admin.Text = "管理员";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.47368F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton_admin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_student, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(78, 326);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 62);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_login.Location = new System.Drawing.Point(179, 429);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(94, 36);
            this.button_login.TabIndex = 10;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // button_regist
            // 
            this.button_regist.Font = new System.Drawing.Font("小米兰亭", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_regist.Location = new System.Drawing.Point(475, 429);
            this.button_regist.Name = "button_regist";
            this.button_regist.Size = new System.Drawing.Size(94, 36);
            this.button_regist.TabIndex = 11;
            this.button_regist.Text = "注册";
            this.button_regist.UseVisualStyleBackColor = true;
            this.button_regist.Click += new System.EventHandler(this.Btn_Regist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.button_regist);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_account);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_account);
            this.Controls.Add(this.lable_login);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable_login;
        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_account;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.RadioButton radioButton_student;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_regist;
    }
}

