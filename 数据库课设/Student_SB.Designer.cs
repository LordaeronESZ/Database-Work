
namespace 数据库课设
{
    partial class Student_SB
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
            this.Column_BDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BNU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_borrow = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
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
            this.Column_BDA,
            this.Column_BPU,
            this.Column_BPL,
            this.Column_BNU,
            this.Column_BCN});
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
            // Column_BDA
            // 
            this.Column_BDA.HeaderText = "出版日期";
            this.Column_BDA.MinimumWidth = 6;
            this.Column_BDA.Name = "Column_BDA";
            this.Column_BDA.ReadOnly = true;
            this.Column_BDA.Width = 125;
            // 
            // Column_BPU
            // 
            this.Column_BPU.HeaderText = "出版社";
            this.Column_BPU.MinimumWidth = 6;
            this.Column_BPU.Name = "Column_BPU";
            this.Column_BPU.ReadOnly = true;
            this.Column_BPU.Width = 125;
            // 
            // Column_BPL
            // 
            this.Column_BPL.HeaderText = "存放位置";
            this.Column_BPL.MinimumWidth = 6;
            this.Column_BPL.Name = "Column_BPL";
            this.Column_BPL.ReadOnly = true;
            this.Column_BPL.Width = 125;
            // 
            // Column_BNU
            // 
            this.Column_BNU.HeaderText = "总数量";
            this.Column_BNU.MinimumWidth = 6;
            this.Column_BNU.Name = "Column_BNU";
            this.Column_BNU.ReadOnly = true;
            this.Column_BNU.Width = 125;
            // 
            // Column_BCN
            // 
            this.Column_BCN.HeaderText = "剩余数量";
            this.Column_BCN.MinimumWidth = 6;
            this.Column_BCN.Name = "Column_BCN";
            this.Column_BCN.ReadOnly = true;
            this.Column_BCN.Width = 125;
            // 
            // button_borrow
            // 
            this.button_borrow.Location = new System.Drawing.Point(1001, 75);
            this.button_borrow.Name = "button_borrow";
            this.button_borrow.Size = new System.Drawing.Size(100, 46);
            this.button_borrow.TabIndex = 2;
            this.button_borrow.Text = "借阅图书";
            this.button_borrow.UseVisualStyleBackColor = true;
            this.button_borrow.Click += new System.EventHandler(this.Btn_Borrow_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(1001, 271);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 46);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "查找图书";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(1001, 451);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(100, 46);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "刷新表格";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Student_SB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_borrow);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Student_SB";
            this.Size = new System.Drawing.Size(1182, 599);
            this.Load += new System.EventHandler(this.Student_SB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BNU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BCN;
        private System.Windows.Forms.Button button_borrow;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_update;
    }
}
