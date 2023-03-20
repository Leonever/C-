namespace 数据库课程设计
{
    partial class frmTeacherMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师任课情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.任课班级成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级课表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.任课课程成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程平均成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.教师任课情况ToolStripMenuItem,
            this.学生成绩录入ToolStripMenuItem,
            this.任课班级成绩ToolStripMenuItem,
            this.个人信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 教师任课情况ToolStripMenuItem
            // 
            this.教师任课情况ToolStripMenuItem.Name = "教师任课情况ToolStripMenuItem";
            this.教师任课情况ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.教师任课情况ToolStripMenuItem.Text = "教师任课情况";
            this.教师任课情况ToolStripMenuItem.Click += new System.EventHandler(this.教师任课情况ToolStripMenuItem_Click);
            // 
            // 学生成绩录入ToolStripMenuItem
            // 
            this.学生成绩录入ToolStripMenuItem.Name = "学生成绩录入ToolStripMenuItem";
            this.学生成绩录入ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.学生成绩录入ToolStripMenuItem.Text = "学生成绩录入";
            this.学生成绩录入ToolStripMenuItem.Click += new System.EventHandler(this.学生成绩录入ToolStripMenuItem_Click);
            // 
            // 任课班级成绩ToolStripMenuItem
            // 
            this.任课班级成绩ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班级课表查询ToolStripMenuItem,
            this.任课课程成绩查询ToolStripMenuItem,
            this.课程平均成绩查询ToolStripMenuItem});
            this.任课班级成绩ToolStripMenuItem.Name = "任课班级成绩ToolStripMenuItem";
            this.任课班级成绩ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.任课班级成绩ToolStripMenuItem.Text = "任课班级";
            // 
            // 班级课表查询ToolStripMenuItem
            // 
            this.班级课表查询ToolStripMenuItem.Name = "班级课表查询ToolStripMenuItem";
            this.班级课表查询ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.班级课表查询ToolStripMenuItem.Text = "班级课表查询";
            this.班级课表查询ToolStripMenuItem.Click += new System.EventHandler(this.班级课表查询ToolStripMenuItem_Click);
            // 
            // 任课课程成绩查询ToolStripMenuItem
            // 
            this.任课课程成绩查询ToolStripMenuItem.Name = "任课课程成绩查询ToolStripMenuItem";
            this.任课课程成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.任课课程成绩查询ToolStripMenuItem.Text = "任课课程成绩查询";
            this.任课课程成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.任课课程成绩查询ToolStripMenuItem_Click);
            // 
            // 课程平均成绩查询ToolStripMenuItem
            // 
            this.课程平均成绩查询ToolStripMenuItem.Name = "课程平均成绩查询ToolStripMenuItem";
            this.课程平均成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.课程平均成绩查询ToolStripMenuItem.Text = "课程平均成绩查询";
            this.课程平均成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.课程平均成绩查询ToolStripMenuItem_Click);
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息查询ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            // 
            // 个人信息查询ToolStripMenuItem
            // 
            this.个人信息查询ToolStripMenuItem.Name = "个人信息查询ToolStripMenuItem";
            this.个人信息查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.个人信息查询ToolStripMenuItem.Text = "个人信息查询";
            this.个人信息查询ToolStripMenuItem.Click += new System.EventHandler(this.个人信息查询ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正兰亭超细黑简体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(188, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "老师欢迎您登陆！";
            // 
            // frmTeacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTeacherMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师任课情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 任课班级成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级课表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 任课课程成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程平均成绩查询ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}