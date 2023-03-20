namespace 数据库课程设计
{
    partial class frmSelectStu
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
            this.button1 = new System.Windows.Forms.Button();
            this.LbAd_Sno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStu_Sno = new System.Windows.Forms.TextBox();
            this.txtStu_Sname = new System.Windows.Forms.TextBox();
            this.txtStu_Sex = new System.Windows.Forms.TextBox();
            this.txtStu_Birth = new System.Windows.Forms.TextBox();
            this.txtStu_Addr = new System.Windows.Forms.TextBox();
            this.txtStu_Cl = new System.Windows.Forms.TextBox();
            this.txtStu_De = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbAd_Sno
            // 
            this.LbAd_Sno.AutoSize = true;
            this.LbAd_Sno.Location = new System.Drawing.Point(60, 48);
            this.LbAd_Sno.Name = "LbAd_Sno";
            this.LbAd_Sno.Size = new System.Drawing.Size(41, 12);
            this.LbAd_Sno.TabIndex = 1;
            this.LbAd_Sno.Text = "学号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "出生日期：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "系别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "班级：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "生源地：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStu_Sno);
            this.groupBox1.Controls.Add(this.LbAd_Sno);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(68, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtStu_Sno
            // 
            this.txtStu_Sno.Location = new System.Drawing.Point(126, 45);
            this.txtStu_Sno.Name = "txtStu_Sno";
            this.txtStu_Sno.Size = new System.Drawing.Size(165, 21);
            this.txtStu_Sno.TabIndex = 2;
            // 
            // txtStu_Sname
            // 
            this.txtStu_Sname.Location = new System.Drawing.Point(194, 163);
            this.txtStu_Sname.Name = "txtStu_Sname";
            this.txtStu_Sname.ReadOnly = true;
            this.txtStu_Sname.Size = new System.Drawing.Size(135, 21);
            this.txtStu_Sname.TabIndex = 3;
            // 
            // txtStu_Sex
            // 
            this.txtStu_Sex.Location = new System.Drawing.Point(505, 163);
            this.txtStu_Sex.Name = "txtStu_Sex";
            this.txtStu_Sex.ReadOnly = true;
            this.txtStu_Sex.Size = new System.Drawing.Size(135, 21);
            this.txtStu_Sex.TabIndex = 9;
            // 
            // txtStu_Birth
            // 
            this.txtStu_Birth.Location = new System.Drawing.Point(194, 248);
            this.txtStu_Birth.Name = "txtStu_Birth";
            this.txtStu_Birth.ReadOnly = true;
            this.txtStu_Birth.Size = new System.Drawing.Size(135, 21);
            this.txtStu_Birth.TabIndex = 10;
            // 
            // txtStu_Addr
            // 
            this.txtStu_Addr.Location = new System.Drawing.Point(505, 247);
            this.txtStu_Addr.Name = "txtStu_Addr";
            this.txtStu_Addr.ReadOnly = true;
            this.txtStu_Addr.Size = new System.Drawing.Size(135, 21);
            this.txtStu_Addr.TabIndex = 11;
            // 
            // txtStu_Cl
            // 
            this.txtStu_Cl.Location = new System.Drawing.Point(194, 336);
            this.txtStu_Cl.Name = "txtStu_Cl";
            this.txtStu_Cl.ReadOnly = true;
            this.txtStu_Cl.Size = new System.Drawing.Size(135, 21);
            this.txtStu_Cl.TabIndex = 12;
            // 
            // txtStu_De
            // 
            this.txtStu_De.Location = new System.Drawing.Point(505, 336);
            this.txtStu_De.Name = "txtStu_De";
            this.txtStu_De.ReadOnly = true;
            this.txtStu_De.Size = new System.Drawing.Size(135, 21);
            this.txtStu_De.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmSelectStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtStu_De);
            this.Controls.Add(this.txtStu_Cl);
            this.Controls.Add(this.txtStu_Addr);
            this.Controls.Add(this.txtStu_Birth);
            this.Controls.Add(this.txtStu_Sex);
            this.Controls.Add(this.txtStu_Sname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSelectStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LbAd_Sno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStu_Sno;
        private System.Windows.Forms.TextBox txtStu_Sname;
        private System.Windows.Forms.TextBox txtStu_Sex;
        private System.Windows.Forms.TextBox txtStu_Birth;
        private System.Windows.Forms.TextBox txtStu_Addr;
        private System.Windows.Forms.TextBox txtStu_Cl;
        private System.Windows.Forms.TextBox txtStu_De;
        private System.Windows.Forms.Button button2;
    }
}