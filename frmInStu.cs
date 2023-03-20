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
    public partial class frmInStu : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void Setbind()
        {
            try
            {
                //sql = "select zjx_sno07 as 学号,zjx_sname07 as 姓名,zjx_ssex07 as 性别,zjx_sbirth07 as 出生日期,zjx_clno07 as 班级,zjx_sadd07 as 生源地,zjx_scredit07 as 学分,zjx_sstart07 as 入学时间,zjx_speople07 as 民族,zjx_spassword07 as 账户密码 from zhangjx_student07";
                sql = "select zjx_sno07 学号, zjx_clno07 所在班级, zjx_sname07 学生姓名 , zjx_ssex07 性别 ,zjx_sbirth07 出生日期,zjx_sadd07 生源地址 ,zjx_scredit07 已修学分 ,zjx_sstart07 入学时间 ,zjx_speople07 民族, zjx_spassword07 账户密码 from zhangjx_student07";
                con.BindDataGridView(dataGview2, sql);
                dataGview2.Columns[0].ReadOnly = true;
                dataGview2.Columns[6].ReadOnly = true;
                dataGview2.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void ComBoxBind()
        {
            try
            {
                cmbCl.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbCl.Items.Clear();
                ds = con.Getds("select zjx_clno07 from zhangjx_class07");
                cmbCl.DisplayMember = "zjx_clno07";
                cmbCl.ValueMember = "zjx_clno07";
                cmbCl.DataSource = ds.Tables[0];
                cmbCl.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmInStu()
        {
            InitializeComponent();
            Setbind();
            ComBoxBind();
        }

        private void txtSin_Psw_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIn_C_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into zhangxj_students07 values('" + txtSin_Sno.Text.ToString() + "','" + cmbCl.SelectedValue.ToString() + "','" + txtSnameIn.Text.ToString() + "','" + txtSin_Sex.Text.ToString() + "'," + txtSin_Birth.Text + ",'" + txtSIn_Ad.Text.ToString() + "'," + txtSin_Credit.Text + "," + textBox2.Text + ",'" + textBox1.Text.ToString() + "','" + txtSin_Psw.Text.ToString() + "')";
                con.OperateData(sql);
                Setbind();
                MessageBox.Show("插入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDel_C_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from zhangjx_student07 where zjx_sno07='" + dataGview2.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateData(sql);
                    Setbind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnChange_C_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update zhangjx_student07 set zjx_sname07='" + dataGview2.CurrentRow.Cells[1].Value.ToString() + "',zjx_ssex07='" + dataGview2.CurrentRow.Cells[2].Value.ToString() + "',zjx_clno07='" + dataGview2.CurrentRow.Cells[4].Value.ToString() + "',zjx_sadd07='" + dataGview2.CurrentRow.Cells[5].Value.ToString() + "',zjx_spassword07='" + dataGview2.CurrentRow.Cells[7].Value.ToString() + "' where zjx_sno07='" + dataGview2.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateData(sql);
                Setbind();

            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_C_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
