
namespace 数据库课设
{
    partial class Admin_BManager
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
            this.button_add = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
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
            this.dataGridView1.TabIndex = 0;
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
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(999, 49);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 46);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "添加图书";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(999, 164);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(100, 46);
            this.button_modify.TabIndex = 2;
            this.button_modify.Text = "修改图书";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.Btn_Modify_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(999, 274);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 46);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "删除图书";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(999, 387);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 46);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "查找图书";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(999, 492);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(100, 46);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "刷新表格";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Admin_BManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Admin_BManager";
            this.Size = new System.Drawing.Size(1182, 599);
            this.Load += new System.EventHandler(this.Admin_BManager_Load);
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
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_update;
    }
}
