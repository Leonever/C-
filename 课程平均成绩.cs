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
    public partial class avgCourse : Form
    {

        public string Sno;
        public void SetSno(string str)
        {
            Sno = str;
        }
        public int x;   //查询课程用户的类型1为管理员，2为学生，3为教师
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void Setbind()
        {
            try
            {
                if (x == 1)
                { //sql = "select distinct zjx_cname07 as 课程名,zjx_avg07 as 平均分 from zjx_kecheng07";
                    sql = "select distinct A.zjx_cname07 as 课程名,sum(A.zjx_avg07)/count(A.zjx_cname07) as 平均分 from zjx_kecheng07 A,zjx_kecheng07 B where A.zjx_cname07 = B.zjx_cname07 group by A.zjx_cname07";
                }
                else if (x == 2)
                { sql = "select zjx_cname07 as 课程名,zjx_avg07 as 平均分 from zjx_kecheng07  where zjx_sno07='" + Sno + "'"; }
                con.BindDataGridView(dataGridView12, sql);
                dataGridView12.ReadOnly = true;
                dataGridView12.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public avgCourse(int x1, string s1)
        {
            InitializeComponent();
            x = x1;
            Sno = s1;
            Setbind(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

