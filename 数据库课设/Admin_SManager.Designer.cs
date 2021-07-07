
namespace 数据库课设
{
    partial class Admin_SManager
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_SNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column__SSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_SNA,
            this.Column_SDE,
            this.Column__SSP,
            this.Column_SUP,
            this.Column_SCN,
            this.Column_SNO,
            this.Column_SPW});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(928, 599);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column_SNA
            // 
            this.Column_SNA.HeaderText = "学生姓名";
            this.Column_SNA.MinimumWidth = 6;
            this.Column_SNA.Name = "Column_SNA";
            this.Column_SNA.ReadOnly = true;
            this.Column_SNA.Width = 125;
            // 
            // Column_SDE
            // 
            this.Column_SDE.HeaderText = "学生系别";
            this.Column_SDE.MinimumWidth = 6;
            this.Column_SDE.Name = "Column_SDE";
            this.Column_SDE.ReadOnly = true;
            this.Column_SDE.Width = 125;
            // 
            // Column__SSP
            // 
            this.Column__SSP.HeaderText = "所学专业";
            this.Column__SSP.MinimumWidth = 6;
            this.Column__SSP.Name = "Column__SSP";
            this.Column__SSP.ReadOnly = true;
            this.Column__SSP.Width = 125;
            // 
            // Column_SUP
            // 
            this.Column_SUP.HeaderText = "借书上限";
            this.Column_SUP.MinimumWidth = 6;
            this.Column_SUP.Name = "Column_SUP";
            this.Column_SUP.ReadOnly = true;
            this.Column_SUP.Width = 125;
            // 
            // Column_SCN
            // 
            this.Column_SCN.HeaderText = "当前可借";
            this.Column_SCN.MinimumWidth = 6;
            this.Column_SCN.Name = "Column_SCN";
            this.Column_SCN.ReadOnly = true;
            this.Column_SCN.Width = 125;
            // 
            // Column_SNO
            // 
            this.Column_SNO.HeaderText = "借书证号";
            this.Column_SNO.MinimumWidth = 6;
            this.Column_SNO.Name = "Column_SNO";
            this.Column_SNO.ReadOnly = true;
            this.Column_SNO.Width = 125;
            // 
            // Column_SPW
            // 
            this.Column_SPW.HeaderText = "借书密码";
            this.Column_SPW.MinimumWidth = 6;
            this.Column_SPW.Name = "Column_SPW";
            this.Column_SPW.ReadOnly = true;
            this.Column_SPW.Width = 125;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(1007, 277);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 46);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "删除学生";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(1007, 138);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(100, 46);
            this.button_modify.TabIndex = 5;
            this.button_modify.Text = "修改学生";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.Btn_Modify_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(1007, 407);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(100, 46);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "刷新表格";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Admin_SManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Admin_SManager";
            this.Size = new System.Drawing.Size(1182, 599);
            this.Load += new System.EventHandler(this.Admin_SManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column__SSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SPW;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_update;
    }
}
