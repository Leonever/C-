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
    public partial class frmChangePsw : Form
    {
        public string number;   //用户名
        public int x = 0; //账号类型类型      1为管理员  2为学生  3为教师
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        public void setx(int i)
        {
            x = i;
        }
        public void setNum(string str)
        {
            number = str;
        }

        public frmChangePsw()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                if (con.conn.State == ConnectionState.Closed) con.conn.Open();
                string sql = "select * from zhangjx_meaasger07 where zjx_mno07='" + number + "' and zjx_mpassword07='" + txtPswOld.Text + "'";
                SqlCommand com = new SqlCommand(sql, con.conn);
                SqlDataReader sread = com.ExecuteReader();
                if (!sread.Read())
                    MessageBox.Show("原密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    con.closeConnect();
                    if (MessageBox.Show("确认要更改为该密码吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string sql1 = "update zhangjx_meaasger07 set zjx_mpassword07='" + txtPswNew.Text + "'where zjx_mno07='" + number + "'";
                        con.OperateData(sql1);
                        MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                sread.Dispose();
                con.closeConnect();
            }
            else if (x == 2)
            {
                if (con.conn.State == ConnectionState.Closed) con.conn.Open();
                string sql = "select * from zhangjx_student07 where zjx_sno07='" + number + "' and zjx_spassword07='" + txtPswOld.Text + "'";
                SqlCommand com = new SqlCommand(sql, con.conn);
                SqlDataReader sread = com.ExecuteReader();
                if (!sread.Read())
                    MessageBox.Show("原密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    con.closeConnect();
                    if (MessageBox.Show("确认要更改为该密码吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string sql1 = "update zhangjx_student07 set zjx_spassword07='" + txtPswNew.Text + "'where zjx_sno07='" + number + "'";
                        con.OperateData(sql1);
                        MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                sread.Dispose();
                con.closeConnect();
            }
            else if (x == 3)
            {
                if (con.conn.State == ConnectionState.Closed) con.conn.Open();
                string sql = "select * from zhangjx_teacher07 where zjx_tno07='" + number + "' and zjx_tpassword07='" + txtPswOld.Text + "'";
                SqlCommand com = new SqlCommand(sql, con.conn);
                SqlDataReader sread = com.ExecuteReader();
                if (!sread.Read())
                    MessageBox.Show("原密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    con.closeConnect();
                    if (MessageBox.Show("确认要更改为该密码吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string sql1 = "update zhangjx_teacher07 set zjx_tpassword07='" + txtPswNew.Text + "'where zjx_tno07='" + number + "'";
                        con.OperateData(sql1);
                        MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                sread.Dispose();
                con.closeConnect();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.closeConnect();
            this.Close();

        }

        private void txtPswOld_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
