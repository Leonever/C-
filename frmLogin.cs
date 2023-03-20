using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace 数据库课程设计
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string psw = txtPsw.Text;

            if (rbtnAdmin.Checked == false && rbtnStu.Checked == false && rbtnTeacher.Checked == false)
                MessageBox.Show("用户类型需要选择！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (name == "" || psw == "")
                    MessageBox.Show("用户名或者密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (rbtnAdmin.Checked == true)
                    {
                        sqlConnect con = new sqlConnect();
                        string sql = "select * from zhangjx_meaasger07 where zjx_mno07='" + name + "' and zjx_mpassword07='" + psw + "'";
                        SqlCommand com = new SqlCommand(sql, con.conn);
                        SqlDataReader sread = com.ExecuteReader();
                        try
                        {
                            if (sread.Read())
                            {
                                MessageBox.Show("登陆成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmAdminMain frmAd = new frmAdminMain();
                                frmAd.SetAno(name);
                                frmAd.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("请输入正确的用户名和密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception msg)
                        {
                            throw new Exception(msg.ToString());

                        }
                        finally
                        {
                            con.closeConnect();
                            sread.Dispose();
                        }

                    }
                    if (rbtnStu.Checked == true)
                    {
                        sqlConnect con = new sqlConnect();
                        string sql = "select * from zhangjx_student07 where zjx_sno07='" + name + "' and zjx_spassword07='" + psw + "'";
                        SqlCommand com = new SqlCommand(sql, con.conn);
                        SqlDataReader sread = com.ExecuteReader();
                        try
                        {
                            if (sread.Read())
                            {
                                MessageBox.Show("登陆成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmStudentMain frmSt = new frmStudentMain();
                                frmSt.SetSno(name);
                                frmSt.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("请输入正确的用户名和密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception msg)
                        {
                            throw new Exception(msg.ToString());

                        }
                        finally
                        {
                            con.closeConnect();
                            sread.Dispose();
                        }
                    }
                    if (rbtnTeacher.Checked == true)
                    {
                        sqlConnect con = new sqlConnect();
                        string sql = "select * from zhangjx_teacher07 where zjx_tno07='" + name + "' and zjx_tpassword07='" + psw + "'";
                        SqlCommand com = new SqlCommand(sql, con.conn);
                        SqlDataReader sread = com.ExecuteReader();
                        try
                        {
                            if (sread.Read())
                            {
                                MessageBox.Show("登陆成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmTeacherMain frmT = new frmTeacherMain();
                                frmT.SetTno(name);
                                frmT.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("请输入正确的用户名和密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception msg)
                        {
                            throw new Exception(msg.ToString());

                        }
                        finally
                        {
                            con.closeConnect();
                            sread.Dispose();
                        }

                    }

                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rbtnStu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

