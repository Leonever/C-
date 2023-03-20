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
    public partial class frmSelectStu : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        public frmSelectStu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.conn.State == ConnectionState.Closed) con.conn.Open();
            sql = "select* from zhangjx_student07 where zjx_sno07='" + txtStu_Sno.Text + "'";
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = sql;
            sqlcom.CommandType = CommandType.Text;
            sqlcom.Connection = con.conn;
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (reader.Read())
            {
                txtStu_Sname.Text = reader["zjx_sname07"].ToString();
                txtStu_Sex.Text = reader["zjx_ssex07"].ToString();
                txtStu_Birth.Text = reader["zjx_sbirth07"].ToString();
                txtStu_Cl.Text = reader["zjx_clno07"].ToString();
                txtStu_Addr.Text = reader["zjx_sadd07"].ToString();

            }
            else
            {
                MessageBox.Show("不存在该学生或学号输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.closeConnect();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
