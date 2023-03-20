using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 数据库课程设计
{
    public partial class 学生端课表查询 : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        public DataSet dt = new DataSet();
        private string sql;
        public string Sno = "";
        public void SetSno_C(string s1)
        {
            Sno = s1;
        }
        protected void ComBoxBind()
        {
            try
            {
                cmbTerm1.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTerm1.Items.Clear();
                dt = con.Getds("select distinct zjx_year07 from zjx_stucla07");
                cmbTerm1.DisplayMember = "zjx_year07";
                cmbTerm1.ValueMember = "zjx_year07";
                cmbTerm1.DataSource = dt.Tables[0];
                cmbTerm1.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public 学生端课表查询()
        {
            InitializeComponent();
            ComBoxBind();
        }
        protected void Setbind(string str2, string str3)
        {
            try
            {
                //sql = "select sqc_Cname08 as 课程名,sqc_Ctime08 as 学时,sqc_Ctestway08 as 考查方式,sqc_Ccredit08 as 学分,sqc_Tname08 as 任课老师  from sunqc_classcourse08 where sqc_Clno08=(select sqc_Clno08 from sunqc_Students08 where sqc_Sno08='" + Sno + "')and sqc_Cterm08='" + str2 + "'";
                //sql = "select * from zjx_stucla07 where zjx_year07='" + str2 + "'and zjx_sno07='" + Sno + "'";
                sql = "select zjx_cno07 课程号, zjx_cname07 课程名,zjx_cadd07 上课地点,zjx_tno07 教师编号 from zjx_stucla07 where zjx_year07='" + str2 + "'and zjx_sno07='" + str3 + "'";
                con.BindDataGridView(dataGridView1, sql);
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmbTerm1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s3 = cmbTerm1.SelectedValue.ToString();
            Setbind(s3, Sno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}

