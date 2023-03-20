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
    public partial class frmClassCourse : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        public DataSet dt = new DataSet();
        private string sql;
        protected void ComBoxBind()
        {
            try
            {
                cmbClname.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTerm.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbClname.Items.Clear();
                cmbTerm.Items.Clear();

                ds = con.Getds("select zjx_clno07,zjx_clname07 from zhangjx_class07");
                cmbClname.DisplayMember = "zjx_clno07";
                cmbClname.ValueMember = "zjx_clno07";
                cmbClname.DataSource = ds.Tables[0];
                cmbClname.SelectedIndex = 0;
                dt = con.Getds("select distinct zjx_year07 from zhangjx_course07");
                cmbTerm.DisplayMember = "zjx_year07";
                cmbTerm.ValueMember = "zjx_year07";
                cmbTerm.DataSource = dt.Tables[0];
                cmbTerm.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void Setbind(string str1, string str2)
        {
            try
            {
                //sql = "select distinct zhangjx_course07.zjx.cno07 as 编号,zjx_clname07 as 班级,zjx_cname07 as 课程名,zjx_year07 as 学期,zjx_ctime07 as 学时,zjx_cform07 as 考查方式,zjx_ccredit07 as 学分,zjx_tname07 as 任课老师  from zhangjx_course07 ,zhangjx_teacher07,zhangjx_class07 ,zhangjx_courses07 where zhangjx_courses07.zjx_clno07='" + str1 + "'and zjx_year07='" + str2 + "'and zhangjx_teacher07.clno07=zhangjx_class07.clno07 and zhangjx_course07.zjx_cno07=zhangjx_courses07.zjx_cno07";
                sql = "select zjx_cno07 课程号,zjx_cname07 课程名 , zjx_cadd07 上课地点 ,zjx_tname07 任课教师 from zhangjx_clte107  where zjx_clno07 = '" + str1 + "'and zjx_year07 = '" + str2 + "'";
                con.BindDataGridView(dataGridView1, sql);
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmClassCourse()
        {
            InitializeComponent();
            ComBoxBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s1, s2;
                s1 = cmbClname.SelectedValue.ToString();
                s2 = cmbTerm.SelectedValue.ToString();
                Setbind(s1, s2);
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbClname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
