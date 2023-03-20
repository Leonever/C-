namespace 数据库课程设计
{
    partial class frmDept
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
            this.txtDno = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.btnInsert_D = new System.Windows.Forms.Button();
            this.txtDnameIn = new System.Windows.Forms.TextBox();
            this.txtDnoIn = new System.Windows.Forms.TextBox();
            this.dataGView_DIn = new System.Windows.Forms.DataGridView();
            this.btnDelete_D = new System.Windows.Forms.Button();
            this.btnChange_D = new System.Windows.Forms.Button();
            this.btnCancel_D = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView_DIn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDno
            // 
            this.txtDno.AutoSize = true;
            this.txtDno.Location = new System.Drawing.Point(48, 66);
            this.txtDno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDno.Name = "txtDno";
            this.txtDno.Size = new System.Drawing.Size(44, 18);
            this.txtDno.TabIndex = 0;
            this.txtDno.Text = "系号";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(279, 66);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(44, 18);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "系别";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.label1);
            this.Gbox.Controls.Add(this.textBox1);
            this.Gbox.Controls.Add(this.btnInsert_D);
            this.Gbox.Controls.Add(this.txtDnameIn);
            this.Gbox.Controls.Add(this.txtDnoIn);
            this.Gbox.Controls.Add(this.txtDno);
            this.Gbox.Controls.Add(this.txtName);
            this.Gbox.Location = new System.Drawing.Point(58, 57);
            this.Gbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gbox.Name = "Gbox";
            this.Gbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gbox.Size = new System.Drawing.Size(1088, 142);
            this.Gbox.TabIndex = 2;
            this.Gbox.TabStop = false;
            // 
            // btnInsert_D
            // 
            this.btnInsert_D.Location = new System.Drawing.Point(806, 58);
            this.btnInsert_D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert_D.Name = "btnInsert_D";
            this.btnInsert_D.Size = new System.Drawing.Size(112, 34);
            this.btnInsert_D.TabIndex = 4;
            this.btnInsert_D.Text = "插入";
            this.btnInsert_D.UseVisualStyleBackColor = true;
            this.btnInsert_D.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDnameIn
            // 
            this.txtDnameIn.Location = new System.Drawing.Point(331, 62);
            this.txtDnameIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDnameIn.Name = "txtDnameIn";
            this.txtDnameIn.Size = new System.Drawing.Size(192, 28);
            this.txtDnameIn.TabIndex = 3;
            this.txtDnameIn.TextChanged += new System.EventHandler(this.txtDnameIn_TextChanged);
            // 
            // txtDnoIn
            // 
            this.txtDnoIn.Location = new System.Drawing.Point(100, 62);
            this.txtDnoIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDnoIn.Name = "txtDnoIn";
            this.txtDnoIn.Size = new System.Drawing.Size(170, 28);
            this.txtDnoIn.TabIndex = 2;
            this.txtDnoIn.TextChanged += new System.EventHandler(this.txtDnoIn_TextChanged);
            // 
            // dataGView_DIn
            // 
            this.dataGView_DIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView_DIn.Location = new System.Drawing.Point(58, 262);
            this.dataGView_DIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGView_DIn.Name = "dataGView_DIn";
            this.dataGView_DIn.RowHeadersWidth = 62;
            this.dataGView_DIn.RowTemplate.Height = 23;
            this.dataGView_DIn.Size = new System.Drawing.Size(1088, 285);
            this.dataGView_DIn.TabIndex = 3;
            // 
            // btnDelete_D
            // 
            this.btnDelete_D.Location = new System.Drawing.Point(632, 600);
            this.btnDelete_D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete_D.Name = "btnDelete_D";
            this.btnDelete_D.Size = new System.Drawing.Size(112, 34);
            this.btnDelete_D.TabIndex = 4;
            this.btnDelete_D.Text = "删除";
            this.btnDelete_D.UseVisualStyleBackColor = true;
            this.btnDelete_D.Click += new System.EventHandler(this.btnDelete_D_Click);
            // 
            // btnChange_D
            // 
            this.btnChange_D.Location = new System.Drawing.Point(832, 600);
            this.btnChange_D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChange_D.Name = "btnChange_D";
            this.btnChange_D.Size = new System.Drawing.Size(112, 34);
            this.btnChange_D.TabIndex = 5;
            this.btnChange_D.Text = "保存";
            this.btnChange_D.UseVisualStyleBackColor = true;
            this.btnChange_D.Click += new System.EventHandler(this.btnChange_D_Click);
            // 
            // btnCancel_D
            // 
            this.btnCancel_D.Location = new System.Drawing.Point(1034, 600);
            this.btnCancel_D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel_D.Name = "btnCancel_D";
            this.btnCancel_D.Size = new System.Drawing.Size(112, 34);
            this.btnCancel_D.TabIndex = 6;
            this.btnCancel_D.Text = "退出";
            this.btnCancel_D.UseVisualStyleBackColor = true;
            this.btnCancel_D.Click += new System.EventHandler(this.btnCancel_D_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(596, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 28);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "学院";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.btnCancel_D);
            this.Controls.Add(this.btnChange_D);
            this.Controls.Add(this.btnDelete_D);
            this.Controls.Add(this.dataGView_DIn);
            this.Controls.Add(this.Gbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系别信息维护窗口";
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView_DIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtDno;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.TextBox txtDnoIn;
        private System.Windows.Forms.TextBox txtDnameIn;
        private System.Windows.Forms.DataGridView dataGView_DIn;
        private System.Windows.Forms.Button btnInsert_D;
        private System.Windows.Forms.Button btnDelete_D;
        private System.Windows.Forms.Button btnChange_D;
        private System.Windows.Forms.Button btnCancel_D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}