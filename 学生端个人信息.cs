using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 数据库课程设计
{
    public partial class 学生端个人信息 : Form
    {
        public string Num;
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        public void SetSno1(string s1)
        {
            Num = s1;
        }
        public void setbind(string s1)
        {

            if (con.conn.State == ConnectionState.Closed) con.conn.Open();
            sql = "select* from zhangjx_student07 where zjx_sno07='" + s1 + "'";
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = sql;
            sqlcom.CommandType = CommandType.Text;
            sqlcom.Connection = con.conn;
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (reader.Read())
            {
                txtStu_Sno.Text = reader["zjx_sno07"].ToString();
                txtStu_Sname.Text = reader["zjx_sname07"].ToString();
                txtStu_Sex.Text = reader["zjx_ssex07"].ToString();
                txtStu_Birth.Text = reader["zjx_sbirth07"].ToString();
                txtStu_Cl.Text = reader["zjx_clno07"].ToString();
                txtStu_Addr.Text = reader["zjx_sadd07"].ToString();
                txtStu_De.Text = reader["zjx_sstart07"].ToString();
                txtScredit1.Text = reader["zjx_scredit07"].ToString();
                textBox1.Text = reader["zjx_speople07"].ToString();
                textBox2.Text = reader["zjx_spassword07"].ToString();

            }
            else
            {
                MessageBox.Show("不存在该学生或学号输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.closeConnect();



        }
        public 学生端个人信息(string s1)
        {
            InitializeComponent();
            setbind(s1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
