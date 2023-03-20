namespace 数据库课程设计
{
    partial class frmCourseIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCnoIn = new System.Windows.Forms.TextBox();
            this.txtCnameIn = new System.Windows.Forms.TextBox();
            this.txtCcreditIn = new System.Windows.Forms.TextBox();
            this.btnIn_C = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTime_C = new System.Windows.Forms.TextBox();
            this.txtTestw_C = new System.Windows.Forms.TextBox();
            this.txtTerm_C = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGview1 = new System.Windows.Forms.DataGridView();
            this.btnDel_C = new System.Windows.Forms.Button();
            this.btnChange_C = new System.Windows.Forms.Button();
            this.btnExit_C = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGview1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "学分";
            // 
            // txtCnoIn
            // 
            this.txtCnoIn.Location = new System.Drawing.Point(158, 30);
            this.txtCnoIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCnoIn.Name = "txtCnoIn";
            this.txtCnoIn.Size = new System.Drawing.Size(186, 28);
            this.txtCnoIn.TabIndex = 3;
            this.txtCnoIn.TextChanged += new System.EventHandler(this.txtCnoIn_TextChanged);
            // 
            // txtCnameIn
            // 
            this.txtCnameIn.Location = new System.Drawing.Point(573, 30);
            this.txtCnameIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCnameIn.Name = "txtCnameIn";
            this.txtCnameIn.Size = new System.Drawing.Size(186, 28);
            this.txtCnameIn.TabIndex = 4;
            // 
            // txtCcreditIn
            // 
            this.txtCcreditIn.Location = new System.Drawing.Point(573, 123);
            this.txtCcreditIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCcreditIn.Name = "txtCcreditIn";
            this.txtCcreditIn.Size = new System.Drawing.Size(186, 28);
            this.txtCcreditIn.TabIndex = 5;
            // 
            // btnIn_C
            // 
            this.btnIn_C.Location = new System.Drawing.Point(814, 81);
            this.btnIn_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn_C.Name = "btnIn_C";
            this.btnIn_C.Size = new System.Drawing.Size(112, 34);
            this.btnIn_C.TabIndex = 6;
            this.btnIn_C.Text = "插入";
            this.btnIn_C.UseVisualStyleBackColor = true;
            this.btnIn_C.Click += new System.EventHandler(this.btnIn_C_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTime_C);
            this.groupBox1.Controls.Add(this.txtTestw_C);
            this.groupBox1.Controls.Add(this.txtTerm_C);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCnoIn);
            this.groupBox1.Controls.Add(this.btnIn_C);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCcreditIn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCnameIn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(92, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(975, 188);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtTime_C
            // 
            this.txtTime_C.Location = new System.Drawing.Point(573, 81);
            this.txtTime_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTime_C.Name = "txtTime_C";
            this.txtTime_C.Size = new System.Drawing.Size(186, 28);
            this.txtTime_C.TabIndex = 12;
            // 
            // txtTestw_C
            // 
            this.txtTestw_C.Location = new System.Drawing.Point(158, 130);
            this.txtTestw_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTestw_C.Name = "txtTestw_C";
            this.txtTestw_C.Size = new System.Drawing.Size(186, 28);
            this.txtTestw_C.TabIndex = 11;
            // 
            // txtTerm_C
            // 
            this.txtTerm_C.Location = new System.Drawing.Point(158, 86);
            this.txtTerm_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTerm_C.Name = "txtTerm_C";
            this.txtTerm_C.Size = new System.Drawing.Size(186, 28);
            this.txtTerm_C.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "考查方式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "学时";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "开课学期";
            // 
            // dataGview1
            // 
            this.dataGview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGview1.Location = new System.Drawing.Point(92, 303);
            this.dataGview1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGview1.Name = "dataGview1";
            this.dataGview1.RowHeadersWidth = 62;
            this.dataGview1.RowTemplate.Height = 23;
            this.dataGview1.Size = new System.Drawing.Size(975, 267);
            this.dataGview1.TabIndex = 8;
            // 
            // btnDel_C
            // 
            this.btnDel_C.Location = new System.Drawing.Point(572, 609);
            this.btnDel_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel_C.Name = "btnDel_C";
            this.btnDel_C.Size = new System.Drawing.Size(112, 34);
            this.btnDel_C.TabIndex = 9;
            this.btnDel_C.Text = "删除";
            this.btnDel_C.UseVisualStyleBackColor = true;
            this.btnDel_C.Click += new System.EventHandler(this.btnDel_C_Click);
            // 
            // btnChange_C
            // 
            this.btnChange_C.Location = new System.Drawing.Point(768, 609);
            this.btnChange_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChange_C.Name = "btnChange_C";
            this.btnChange_C.Size = new System.Drawing.Size(112, 34);
            this.btnChange_C.TabIndex = 10;
            this.btnChange_C.Text = "保存";
            this.btnChange_C.UseVisualStyleBackColor = true;
            this.btnChange_C.Click += new System.EventHandler(this.btnChange_C_Click);
            // 
            // btnExit_C
            // 
            this.btnExit_C.Location = new System.Drawing.Point(952, 609);
            this.btnExit_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit_C.Name = "btnExit_C";
            this.btnExit_C.Size = new System.Drawing.Size(112, 34);
            this.btnExit_C.TabIndex = 11;
            this.btnExit_C.Text = "取消";
            this.btnExit_C.UseVisualStyleBackColor = true;
            this.btnExit_C.Click += new System.EventHandler(this.btnExit_C_Click);
            // 
            // frmCourseIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 675);
            this.Controls.Add(this.btnExit_C);
            this.Controls.Add(this.btnChange_C);
            this.Controls.Add(this.btnDel_C);
            this.Controls.Add(this.dataGview1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCourseIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程信息输入";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCnoIn;
        private System.Windows.Forms.TextBox txtCnameIn;
        private System.Windows.Forms.TextBox txtCcreditIn;
        private System.Windows.Forms.Button btnIn_C;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGview1;
        private System.Windows.Forms.Button btnDel_C;
        private System.Windows.Forms.Button btnChange_C;
        private System.Windows.Forms.Button btnExit_C;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTime_C;
        private System.Windows.Forms.TextBox txtTestw_C;
        private System.Windows.Forms.TextBox txtTerm_C;
    }
}