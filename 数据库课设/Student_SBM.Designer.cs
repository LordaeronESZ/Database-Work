
namespace 数据库课设
{
    partial class Student_SBM
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
            this.Column_BNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_RDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PNU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BNU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_return = new System.Windows.Forms.Button();
            this.button_continue = new System.Windows.Forms.Button();
            this.button_punish = new System.Windows.Forms.Button();
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
            this.Column_BNO,
            this.Column_BNA,
            this.Column_BPL,
            this.dataGridViewTextBoxColumn1,
            this.Column_RDA,
            this.Column_PNU,
            this.Column_BNU});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(930, 599);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column_BNO
            // 
            this.Column_BNO.HeaderText = "图书编号";
            this.Column_BNO.MinimumWidth = 6;
            this.Column_BNO.Name = "Column_BNO";
            this.Column_BNO.ReadOnly = true;
            this.Column_BNO.Width = 125;
            // 
            // Column_BNA
            // 
            this.Column_BNA.HeaderText = "图书名";
            this.Column_BNA.MinimumWidth = 6;
            this.Column_BNA.Name = "Column_BNA";
            this.Column_BNA.ReadOnly = true;
            this.Column_BNA.Width = 125;
            // 
            // Column_BPL
            // 
            this.Column_BPL.HeaderText = "存放位置";
            this.Column_BPL.MinimumWidth = 6;
            this.Column_BPL.Name = "Column_BPL";
            this.Column_BPL.ReadOnly = true;
            this.Column_BPL.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "借阅日期";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Column_RDA
            // 
            this.Column_RDA.HeaderText = "归还日期";
            this.Column_RDA.MinimumWidth = 6;
            this.Column_RDA.Name = "Column_RDA";
            this.Column_RDA.ReadOnly = true;
            this.Column_RDA.Width = 125;
            // 
            // Column_PNU
            // 
            this.Column_PNU.HeaderText = "罚款数";
            this.Column_PNU.MinimumWidth = 6;
            this.Column_PNU.Name = "Column_PNU";
            this.Column_PNU.ReadOnly = true;
            this.Column_PNU.Width = 125;
            // 
            // Column_BNU
            // 
            this.Column_BNU.HeaderText = "借阅数目";
            this.Column_BNU.MinimumWidth = 6;
            this.Column_BNU.Name = "Column_BNU";
            this.Column_BNU.ReadOnly = true;
            this.Column_BNU.Width = 125;
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(1006, 65);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(100, 46);
            this.button_return.TabIndex = 2;
            this.button_return.Text = "归还图书";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // button_continue
            // 
            this.button_continue.Location = new System.Drawing.Point(1006, 202);
            this.button_continue.Name = "button_continue";
            this.button_continue.Size = new System.Drawing.Size(100, 46);
            this.button_continue.TabIndex = 3;
            this.button_continue.Text = "续借图书";
            this.button_continue.UseVisualStyleBackColor = true;
            this.button_continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // button_punish
            // 
            this.button_punish.Location = new System.Drawing.Point(1006, 339);
            this.button_punish.Name = "button_punish";
            this.button_punish.Size = new System.Drawing.Size(100, 46);
            this.button_punish.TabIndex = 4;
            this.button_punish.Text = "交罚款";
            this.button_punish.UseVisualStyleBackColor = true;
            this.button_punish.Click += new System.EventHandler(this.Btn_Punish_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(1006, 467);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(100, 46);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "刷新表格";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Student_SBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_punish);
            this.Controls.Add(this.button_continue);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Student_SBM";
            this.Size = new System.Drawing.Size(1182, 599);
            this.Load += new System.EventHandler(this.Student_SBM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_continue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_RDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PNU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BNU;
        private System.Windows.Forms.Button button_punish;
        private System.Windows.Forms.Button button_update;
    }
}
