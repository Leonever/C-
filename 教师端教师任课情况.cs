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
    public partial class teaTeach : Form
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
        protected void Setbind(string str2)
        {
            try
            {
                txtTeach_Tno.Text = Tno;
                sql = "select zjx_tno07 as 编号,zjx_tname07 as 姓名,zjx_cno as 课程号,zjx_cadd07 as 班级 from zhangjx_teach07 where zjx_tno07='" + Tno + "'";
                con.BindDataGridView(dataGridView1, sql);
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;

                sql1 = "select zjx_tno07 as 编号,zjx_tname07 as 姓名,zjx_cno as 课程名,zjx_cadd07 as 班级 from zhangjx_teach07 where zjx_tno07='" + Tno + "'";
                ds = con.Getds(sql1);
                if (ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    txtTeach_Tname.Text = ds.Tables[0].Rows[0][1].ToString();
                    string s1 = txtTeach_Tno.Text;
                }
                else
                    MessageBox.Show("您今年没有上课！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public teaTeach(string s)
        {
            InitializeComponent();
            Tno = s;
            Setbind(s);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTeach_Tname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTeach_Tno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
