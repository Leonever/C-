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
    public partial class frmSelectTe : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        public frmSelectTe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.conn.State == ConnectionState.Closed) con.conn.Open();
            sql = "select* from zhangjx_teacher07 where zjx_tno07='" + txtTea_Tno.Text + "'";
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = sql;
            sqlcom.CommandType = CommandType.Text;
            sqlcom.Connection = con.conn;
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (reader.Read())
            {
                txtTea_Tname.Text = reader["zjx_tname07"].ToString();
                txtTea_Sex.Text = reader["zjx_tssex07"].ToString();
                txtTea_Age.Text = reader["zjx_tbirth07"].ToString();
                txtTea_Tel.Text = reader["zjx_ttphone07"].ToString();
                txtTea_Title.Text = reader["zjx_ttitle07"].ToString();
                textBox1.Text = reader["zjx_clno07"].ToString();


            }
            else
            {
                MessageBox.Show("不存在该教师或编号输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.closeConnect();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTea_Title_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
