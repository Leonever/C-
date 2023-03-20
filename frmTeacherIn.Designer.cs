namespace 数据库课程设计
{
    partial class frmTeacherIn
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
            this.btnExit_C = new System.Windows.Forms.Button();
            this.btnChange_C = new System.Windows.Forms.Button();
            this.btnDel_C = new System.Windows.Forms.Button();
            this.dataGview3 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTIn_Tel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTin_Age = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTin_Tno = new System.Windows.Forms.TextBox();
            this.btnIn_C = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTin_Psw = new System.Windows.Forms.TextBox();
            this.txtSin_Sname = new System.Windows.Forms.Label();
            this.txtTnameIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGview3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit_C
            // 
            this.btnExit_C.Location = new System.Drawing.Point(974, 608);
            this.btnExit_C.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit_C.Name = "btnExit_C";
            this.btnExit_C.Size = new System.Drawing.Size(112, 34);
            this.btnExit_C.TabIndex = 21;
            this.btnExit_C.Text = "取消";
            this.btnExit_C.UseVisualStyleBackColor = true;
            this.btnExit_C.Click += new System.EventHandler(this.btnExit_C_Click);
            // 
            // btnChange_C
            // 
            this.btnChange_C.Location = new System.Drawing.Point(789, 608);
            this.btnChange_C.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange_C.Name = "btnChange_C";
            this.btnChange_C.Size = new System.Drawing.Size(112, 34);
            this.btnChange_C.TabIndex = 20;
            this.btnChange_C.Text = "保存";
            this.btnChange_C.UseVisualStyleBackColor = true;
            this.btnChange_C.Click += new System.EventHandler(this.btnChange_C_Click);
            // 
            // btnDel_C
            // 
            this.btnDel_C.Location = new System.Drawing.Point(592, 608);
            this.btnDel_C.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel_C.Name = "btnDel_C";
            this.btnDel_C.Size = new System.Drawing.Size(112, 34);
            this.btnDel_C.TabIndex = 19;
            this.btnDel_C.Text = "删除";
            this.btnDel_C.UseVisualStyleBackColor = true;
            this.btnDel_C.Click += new System.EventHandler(this.btnDel_C_Click);
            // 
            // dataGview3
            // 
            this.dataGview3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGview3.Location = new System.Drawing.Point(112, 302);
            this.dataGview3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGview3.Name = "dataGview3";
            this.dataGview3.RowHeadersWidth = 62;
            this.dataGview3.RowTemplate.Height = 23;
            this.dataGview3.Size = new System.Drawing.Size(975, 267);
            this.dataGview3.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTIn_Tel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTin_Age);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTin_Tno);
            this.groupBox1.Controls.Add(this.btnIn_C);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTin_Psw);
            this.groupBox1.Controls.Add(this.txtSin_Sname);
            this.groupBox1.Controls.Add(this.txtTnameIn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(112, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(975, 232);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(766, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "学院";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "班级";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTIn_Tel
            // 
            this.txtTIn_Tel.Location = new System.Drawing.Point(158, 180);
            this.txtTIn_Tel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTIn_Tel.Name = "txtTIn_Tel";
            this.txtTIn_Tel.Size = new System.Drawing.Size(186, 28);
            this.txtTIn_Tel.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "电话";
            // 
            // txtTin_Age
            // 
            this.txtTin_Age.Location = new System.Drawing.Point(536, 83);
            this.txtTin_Age.Margin = new System.Windows.Forms.Padding(4);
            this.txtTin_Age.Name = "txtTin_Age";
            this.txtTin_Age.Size = new System.Drawing.Size(186, 28);
            this.txtTin_Age.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "职称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "出生日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "性别";
            // 
            // txtTin_Tno
            // 
            this.txtTin_Tno.Location = new System.Drawing.Point(158, 30);
            this.txtTin_Tno.Margin = new System.Windows.Forms.Padding(4);
            this.txtTin_Tno.Name = "txtTin_Tno";
            this.txtTin_Tno.Size = new System.Drawing.Size(186, 28);
            this.txtTin_Tno.TabIndex = 3;
            // 
            // btnIn_C
            // 
            this.btnIn_C.Location = new System.Drawing.Point(811, 164);
            this.btnIn_C.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn_C.Name = "btnIn_C";
            this.btnIn_C.Size = new System.Drawing.Size(112, 34);
            this.btnIn_C.TabIndex = 6;
            this.btnIn_C.Text = "插入";
            this.btnIn_C.UseVisualStyleBackColor = true;
            this.btnIn_C.Click += new System.EventHandler(this.btnIn_C_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号";
            // 
            // txtTin_Psw
            // 
            this.txtTin_Psw.Location = new System.Drawing.Point(536, 125);
            this.txtTin_Psw.Margin = new System.Windows.Forms.Padding(4);
            this.txtTin_Psw.Name = "txtTin_Psw";
            this.txtTin_Psw.Size = new System.Drawing.Size(186, 28);
            this.txtTin_Psw.TabIndex = 5;
            this.txtTin_Psw.TextChanged += new System.EventHandler(this.txtTin_Psw_TextChanged);
            // 
            // txtSin_Sname
            // 
            this.txtSin_Sname.AutoSize = true;
            this.txtSin_Sname.Location = new System.Drawing.Point(454, 34);
            this.txtSin_Sname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSin_Sname.Name = "txtSin_Sname";
            this.txtSin_Sname.Size = new System.Drawing.Size(44, 18);
            this.txtSin_Sname.TabIndex = 1;
            this.txtSin_Sname.Text = "姓名";
            // 
            // txtTnameIn
            // 
            this.txtTnameIn.Location = new System.Drawing.Point(536, 31);
            this.txtTnameIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtTnameIn.Name = "txtTnameIn";
            this.txtTnameIn.Size = new System.Drawing.Size(186, 28);
            this.txtTnameIn.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "账户密码";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(817, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 26);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(158, 84);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 26);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(536, 180);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(186, 26);
            this.comboBox4.TabIndex = 24;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // frmTeacherIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.btnExit_C);
            this.Controls.Add(this.btnChange_C);
            this.Controls.Add(this.btnDel_C);
            this.Controls.Add(this.dataGview3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTeacherIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师信息维护界面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGview3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit_C;
        private System.Windows.Forms.Button btnChange_C;
        private System.Windows.Forms.Button btnDel_C;
        private System.Windows.Forms.DataGridView dataGview3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTIn_Tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTin_Age;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTin_Tno;
        private System.Windows.Forms.Button btnIn_C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTin_Psw;
        private System.Windows.Forms.Label txtSin_Sname;
        private System.Windows.Forms.TextBox txtTnameIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}