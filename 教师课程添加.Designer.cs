namespace 数据库课程设计
{
    partial class addCourse
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
            this.cmbTea1 = new System.Windows.Forms.ComboBox();
            this.cmbCL1 = new System.Windows.Forms.ComboBox();
            this.cmbCname1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnjia = new System.Windows.Forms.Button();
            this.dataGridView12 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTea1
            // 
            this.cmbTea1.FormattingEnabled = true;
            this.cmbTea1.Location = new System.Drawing.Point(230, 112);
            this.cmbTea1.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTea1.Name = "cmbTea1";
            this.cmbTea1.Size = new System.Drawing.Size(180, 26);
            this.cmbTea1.TabIndex = 0;
            this.cmbTea1.SelectedIndexChanged += new System.EventHandler(this.cmbTea1_SelectedIndexChanged);
            // 
            // cmbCL1
            // 
            this.cmbCL1.FormattingEnabled = true;
            this.cmbCL1.Location = new System.Drawing.Point(561, 112);
            this.cmbCL1.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCL1.Name = "cmbCL1";
            this.cmbCL1.Size = new System.Drawing.Size(180, 26);
            this.cmbCL1.TabIndex = 1;
            this.cmbCL1.SelectedIndexChanged += new System.EventHandler(this.cmbCL1_SelectedIndexChanged);
            // 
            // cmbCname1
            // 
            this.cmbCname1.FormattingEnabled = true;
            this.cmbCname1.Location = new System.Drawing.Point(849, 112);
            this.cmbCname1.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCname1.Name = "cmbCname1";
            this.cmbCname1.Size = new System.Drawing.Size(180, 26);
            this.cmbCname1.TabIndex = 2;
            this.cmbCname1.SelectedIndexChanged += new System.EventHandler(this.cmbCname1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "教师：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "班级：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(765, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "课程：";
            // 
            // btnjia
            // 
            this.btnjia.Location = new System.Drawing.Point(896, 180);
            this.btnjia.Margin = new System.Windows.Forms.Padding(4);
            this.btnjia.Name = "btnjia";
            this.btnjia.Size = new System.Drawing.Size(135, 46);
            this.btnjia.TabIndex = 6;
            this.btnjia.Text = "添加";
            this.btnjia.UseVisualStyleBackColor = true;
            this.btnjia.Click += new System.EventHandler(this.btnjia_Click);
            // 
            // dataGridView12
            // 
            this.dataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView12.Location = new System.Drawing.Point(142, 273);
            this.dataGridView12.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView12.Name = "dataGridView12";
            this.dataGridView12.RowHeadersWidth = 62;
            this.dataGridView12.RowTemplate.Height = 23;
            this.dataGridView12.Size = new System.Drawing.Size(888, 310);
            this.dataGridView12.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(896, 610);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "学院编号";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(561, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 28);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "地点";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(230, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 26);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView12);
            this.Controls.Add(this.btnjia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCname1);
            this.Controls.Add(this.cmbCL1);
            this.Controls.Add(this.cmbTea1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师课程添加";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTea1;
        private System.Windows.Forms.ComboBox cmbCL1;
        private System.Windows.Forms.ComboBox cmbCname1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnjia;
        private System.Windows.Forms.DataGridView dataGridView12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}