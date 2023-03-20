namespace 数据库课程设计
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.laName = new System.Windows.Forms.Label();
            this.laPwd = new System.Windows.Forms.Label();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnStu = new System.Windows.Forms.RadioButton();
            this.rbtnTeacher = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(478, 478);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(124, 56);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(670, 478);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 56);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(333, 300);
            this.laName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(80, 18);
            this.laName.TabIndex = 2;
            this.laName.Text = "用户名：";
            this.laName.Click += new System.EventHandler(this.label1_Click);
            // 
            // laPwd
            // 
            this.laPwd.AutoSize = true;
            this.laPwd.Location = new System.Drawing.Point(333, 364);
            this.laPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laPwd.Name = "laPwd";
            this.laPwd.Size = new System.Drawing.Size(62, 18);
            this.laPwd.TabIndex = 3;
            this.laPwd.Text = "密码：";
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(306, 201);
            this.rbtnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(87, 22);
            this.rbtnAdmin.TabIndex = 6;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "管理员";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            this.rbtnAdmin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnStu
            // 
            this.rbtnStu.AutoSize = true;
            this.rbtnStu.Location = new System.Drawing.Point(538, 201);
            this.rbtnStu.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnStu.Name = "rbtnStu";
            this.rbtnStu.Size = new System.Drawing.Size(69, 22);
            this.rbtnStu.TabIndex = 7;
            this.rbtnStu.TabStop = true;
            this.rbtnStu.Text = "学生";
            this.rbtnStu.UseVisualStyleBackColor = true;
            this.rbtnStu.CheckedChanged += new System.EventHandler(this.rbtnStu_CheckedChanged);
            // 
            // rbtnTeacher
            // 
            this.rbtnTeacher.AutoSize = true;
            this.rbtnTeacher.Location = new System.Drawing.Point(753, 201);
            this.rbtnTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnTeacher.Name = "rbtnTeacher";
            this.rbtnTeacher.Size = new System.Drawing.Size(69, 22);
            this.rbtnTeacher.TabIndex = 8;
            this.rbtnTeacher.TabStop = true;
            this.rbtnTeacher.Text = "教师";
            this.rbtnTeacher.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(478, 286);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(313, 28);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(478, 364);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(4);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '*';
            this.txtPsw.Size = new System.Drawing.Size(313, 28);
            this.txtPsw.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文琥珀", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(254, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "欢迎登陆高校成绩管理系统";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(999, 638);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 668);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rbtnTeacher);
            this.Controls.Add(this.rbtnStu);
            this.Controls.Add(this.rbtnAdmin);
            this.Controls.Add(this.laPwd);
            this.Controls.Add(this.laName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎登陆";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Label laPwd;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.RadioButton rbtnStu;
        private System.Windows.Forms.RadioButton rbtnTeacher;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}