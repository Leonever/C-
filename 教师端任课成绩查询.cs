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
    public partial class select : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        public DataSet dt = new DataSet();
        private string sql;
        private string sql1;
        public string Tno = "";
        public void SetTno_C(string s1)
        {
            Tno = s1;
        }
        protected void ComBoxBind()
        {
            try
            {
                cmbCname.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbCname.Items.Clear();
                dt = con.Getds("select distinct zjx_cname07,zjx_cno07 from zjx_kecheng07 where zjx_tno07='" + Tno + "'");
                cmbCname.DisplayMember = "zjx_cname07";
                cmbCname.ValueMember = "zjx_cname07";
                cmbCname.DataSource = dt.Tables[0];
                cmbCname.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public select(string s)
        {
            InitializeComponent();
            Tno = s;
            ComBoxBind();
        }
        protected void Setbind(string str2)
        {
            try
            {
                //sql = "select sunqc_Learn08.sqc_Sno08 as 学号,sqc_Sname08 as 姓名,sqc_Score08 as 分数 from sunqc_Learn08,sunqc_Students08 where sqc_Tno08='" + Tno + "'and sunqc_Students08.sqc_Sno08=sunqc_Learn08.sqc_Sno08 and sqc_Cno08=(select sqc_Cno08 from sunqc_Courses08 where sqc_Cname08='" + str2 + "') order by sqc_Score08 desc";
                sql = "select zjx_cno07 课程编号, zjx_sno07 学生学号, zjx_sname07 学生姓名,zjx_achievemnet07 学生成绩 from zjx_kecheng07 where zjx_cname07='" + str2 + "'and zjx_tno07='" + Tno + "' order by zjx_achievemnet07 desc";
                con.BindDataGridView(dataGridView1, sql);
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string s3 = cmbCname.SelectedValue.ToString();
            Setbind(s3);
            //sql = "select sqc_Avggrade08 from sunqc_courseAvgGrade08 where sqc_Cname08='" + s3 + "'";
            sql = "select distinct A.zjx_cname07 as 课程名,sum(A.zjx_avg07)/count(A.zjx_cname07) as 平均分 from zjx_kecheng07 A,zjx_kecheng07 B where A.zjx_cname07='" + s3 + "' and A.zjx_cname07 = B.zjx_cname07 group by A.zjx_cname07";
            ds = con.Getds(sql);

            //txtCgrade.Text = ds.Tables[0].Rows[0][1].ToString();
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtCgrade.Text = ds.Tables[0].Rows[0][1].ToString();
            }
            else txtCgrade.Text = "null";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCgrade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
