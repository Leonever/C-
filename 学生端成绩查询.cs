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

    public partial class 学生端成绩查询 : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        public DataSet dt = new DataSet();
        private string sql;
        private string sql1;
        public string Sno = "";
        public void SetSno_C(string s1)
        {
            Sno = s1;
        }
        protected void ComBoxBind()
        {
            try
            {
                cmbterm.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbterm.Items.Clear();
                dt = con.Getds("select distinct zjx_year07 from zhangjx_stujpa07");
                cmbterm.DisplayMember = "zjx_year07";
                cmbterm.ValueMember = "zjx_year07";
                cmbterm.DataSource = dt.Tables[0];
                cmbterm.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public 学生端成绩查询()
        {
            InitializeComponent();
            ComBoxBind();
        }
        protected void Setbind(string str2, string str0)
        {
            try
            {
                //sql = "select sqc_Cname08 as 课程名,sqc_Score08 as 分数,sqc_Ccredit08 as 学分,sqc_GPA08 as 课程绩点 from sunqc_stuNNNgrade08 where sqc_Sno08='" + Sno + "'and sqc_Cterm08='" + str2 + "'";
                //sql = "select * from zjx_kecheng07  where zjx_sno07='" + str0 + "'";
                sql = "select zjx_tname07 教师 ,zjx_cno07 课程号, zjx_cname07 课程名, zjx_achievemnet07 课程成绩 from zjx_kecheng07  where zjx_sno07='" + str0 + "'";
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
            string s3 = cmbterm.SelectedValue.ToString();
            Setbind(s3, Sno);
            //sql= "select sqc_Avggpa08 from sunqc_Gpa08 where sqc_Sno08='"+Sno+"'and sqc_Cterm08 = '" + s3 + "'";
            sql = "select zjx_jpa07 from zhangjx_stujpa07 where zjx_year07='" + s3 + "'and zjx_sno07='" + Sno + "'";
            ds = con.Getds(sql);
            string gpa;

            gpa = ds.Tables[0].Rows[0][0].ToString();
            txtStugpa.Text = ds.Tables[0].Rows[0][0].ToString();

            // sql1 = "select count(*) from sunqc_Gpa08 where " + ds.Tables[0].Rows[0][0] + "  <= sqc_Avggpa08 and sqc_Cterm08 = '" + s3 + "'";
            sql1 = "select zjx_rank07 from zhangjx_sturank07 where zjx_sno07='" + Sno + "'and zjx_year07='" + s3 + "'";
            dt = con.Getds(sql1);
            txtStuseat.Text = dt.Tables[0].Rows[0][0].ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
