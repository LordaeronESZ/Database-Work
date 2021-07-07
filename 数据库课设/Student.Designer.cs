
namespace 数据库课设
{
    partial class Student
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SBStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SBMStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_display = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem,
            this.helpStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SBStripMenuItem,
            this.SBMStripMenuItem});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem.Text = "工具";
            // 
            // SBStripMenuItem
            // 
            this.SBStripMenuItem.Name = "SBStripMenuItem";
            this.SBStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.SBStripMenuItem.Text = "图书借阅";
            this.SBStripMenuItem.Click += new System.EventHandler(this.Student_SB_Click);
            // 
            // SBMStripMenuItem
            // 
            this.SBMStripMenuItem.Name = "SBMStripMenuItem";
            this.SBMStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.SBMStripMenuItem.Text = "已借图书";
            this.SBMStripMenuItem.Click += new System.EventHandler(this.Student_SBM_Click);
            // 
            // helpStripMenuItem
            // 
            this.helpStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutStripMenuItem});
            this.helpStripMenuItem.Name = "helpStripMenuItem";
            this.helpStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpStripMenuItem.Text = "帮助";
            // 
            // aboutStripMenuItem
            // 
            this.aboutStripMenuItem.Name = "aboutStripMenuItem";
            this.aboutStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.aboutStripMenuItem.Text = "关于";
            this.aboutStripMenuItem.Click += new System.EventHandler(this.Student_About_Click);
            // 
            // panel_display
            // 
            this.panel_display.Location = new System.Drawing.Point(0, 31);
            this.panel_display.Name = "panel_display";
            this.panel_display.Size = new System.Drawing.Size(1182, 599);
            this.panel_display.TabIndex = 2;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.panel_display);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Student";
            this.Text = "学生";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_Form_Close);
            this.Load += new System.EventHandler(this.Student_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SBStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SBMStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStripMenuItem;
        private System.Windows.Forms.Panel panel_;
        private System.Windows.Forms.Panel panel_display;
    }
}