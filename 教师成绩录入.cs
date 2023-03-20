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
    public partial class 教师成绩录入 : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        public DataSet dt = new DataSet();
        private string sql;
        private string sql1;
        public string Tno = "";
        public string Cno = "";
        public void SetTno_C(string s1)
        {
            Tno = s1;
        }
        protected void ComBoxBind()
        {
            try
            {
                cmb11.DropDownStyle = ComboBoxStyle.DropDownList;
                cmb11.Items.Clear();
                dt = con.Getds("select distinct zjx_cname07 from zhangjx_courses07,zhangjx_course07 where zjx_tno07='" + Tno + "'and zhangjx_courses07.zjx_cno07=zhangjx_course07.zjx_cno07");
                cmb11.DisplayMember = "zjx_cname07";
                cmb11.ValueMember = "zjx_cname07";
                cmb11.DataSource = dt.Tables[0];
                cmb11.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public 教师成绩录入(string s)
        {
            InitializeComponent();
            Tno = s;
            ComBoxBind();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        protected void Setbind(string str2)
        {
            try
            {
                //sql = "select sunqc_Learn08.sqc_Sno08 as 学号,sqc_Sname08 as 姓名,sqc_Score08 as 分数 from sunqc_Learn08,sunqc_Students08 where sqc_Tno08='" + Tno + "'and sunqc_Students08.sqc_Sno08=sunqc_Learn08.sqc_Sno08 and sqc_Cno08=(select sqc_Cno08 from sunqc_Courses08 where sqc_Cname08='" + c+ "') order by sqc_Score08 desc";
                //sql = "select * from zhangjx_classachi07 where zjx_tno07='" + Tno + "'and zjx_cname07='" + str2 + "'";
                sql = "select zjx_sno07 学号, zjx_sname07 姓名,zjx_achievement07 成绩,zjx_jpa07 绩点07 from zhangjx_classachi07 where zjx_tno07='" + Tno + "'and zjx_cname07='" + str2 + "'";
                con.BindDataGridView(dataGridView111, sql);
                dataGridView111.Columns[0].ReadOnly = true;
                dataGridView111.Columns[1].ReadOnly = true;
                dataGridView111.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string s3 = cmb11.SelectedValue.ToString();
            Setbind(s3);
            sql1 = "select zjx_cno07,zjx_year07,zjx_ctime07 from zhangjx_course07 where zjx_cname07='" + s3 + "'";
            ds = con.Getds(sql1);
            txtYear.Text = ds.Tables[0].Rows[0][1].ToString();
            txtTime.Text = ds.Tables[0].Rows[0][2].ToString();
            Cno = ds.Tables[0].Rows[0][0].ToString();
            // MessageBox.Show(Cno, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            try
            {
                
                int a = int.Parse(dataGridView111.CurrentRow.Cells[2].Value.ToString());
                sql = "update zhangjx_student07 set zjx_scredit07+=" + a/16 + "where zjx_sno07='" + dataGridView111.CurrentRow.Cells[0].Value.ToString() + "')";
                con.OperateData(sql);
                string ss3 = cmb11.SelectedValue.ToString();
                Setbind(ss3);

            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string s4 = cmb11.SelectedValue.ToString();
                //int b = int.Parse(txtGrade.Text.ToString());
                //  dt = con.Getds("select sqc_Cno08 from sunqc_Courses08 where sqc_Cname='" + cmb11.SelectedValue.ToString() + "'");

                //string str0 = "2020.2";
                //sql = "insert into zhangjx_choose07 values('" + txtSno.Text.ToString() + "','" + Cno + "'," + txtGrade.Text + ",'" + txtYear.Text.ToString() + "','" + Tno + "')";
                sql = "update  zhangjx_choose07 set zjx_achievement07="+ txtGrade.Text + " where zjx_sno07='"+ txtSno.Text.ToString()+"' and zjx_cno07 in (select zjx_cno07 from zhangjx_classachi07 where zjx_tno07='"+Tno+"' and zjx_cname07='"+s4+"') and zjx_year07='"+ txtYear.Text.ToString() + "'";
                con.OperateData(sql);
                string sss = cmb11.SelectedValue.ToString();
                Setbind(sss);
                MessageBox.Show("插入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {

                MessageBox.Show(txtYear.Text.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmb11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
