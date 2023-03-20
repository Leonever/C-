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
    public partial class frmteach : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void Setbind(string str)
        {
            try
            {
                con.BindDataGridView(dataGridView1, sql);
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmteach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sql = "select zhangjx_teacher07.zjx_tno07 as 编号,zjx_tname07 as 姓名,zhangjx_courses07.zjx_cno07 as 课程编号,zhangjx_courses07.zjx_clno07 as 班级 from zhangjx_teacher07,zhangjx_courses07 where zhangjx_teacher07.zjx_tno07='" + txtTeach_Tno.Text + "'and zhangjx_teacher07.zjx_tno07=zhangjx_courses07.zjx_tno07";
            ds = con.Getds(sql);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                txtTeach_Tname.Text = ds.Tables[0].Rows[0][1].ToString();
                string s1 = txtTeach_Tno.Text;
                Setbind(s1);
            }
            else
                MessageBox.Show("不存在该教师！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
