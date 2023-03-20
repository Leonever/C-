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
    public partial class frmTeacherIn : Form
    {

        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        public DataSet ds0 = new DataSet();
        public DataSet ds1 = new DataSet();
        public DataSet ds2 = new DataSet();
        public DataSet ds3 = new DataSet();
        private string sql;
        protected void Setbind()
        {
            try
            {
                sql = "select zjx_tno07  编号,zjx_clno07 班级,zjx_cono07 学院,zjx_tname07  姓名,zjx_tssex07  性别,zjx_tbirth07 出生年月,zjx_ttitle07 as 职称,zjx_ttphone07 as 电话,zjx_tpassword07 as 账户密码 from zhangjx_teacher07" +
                    "";
                con.BindDataGridView(dataGview3, sql);
                dataGview3.Columns[0].ReadOnly = true;
                dataGview3.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void ComBoxBindco()
        {
            try
            {
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.Items.Clear();
                ds0 = con.Getds("select zjx_cono07 from zhangjx_college07");
                comboBox1.DisplayMember = "zjx_cono07";
                comboBox1.ValueMember = "zjx_cono07";
                comboBox1.DataSource = ds0.Tables[0];
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void ComBoxBindti()
        {
            try
            {
                comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox2.Items.Clear();
                ds1 = con.Getds("select distinct zjx_ttitle07 from zhangjx_teacher07");
                comboBox2.DisplayMember = "zjx_ttitle07";
                comboBox2.ValueMember = "zjx_ttitle07";
                comboBox2.DataSource = ds1.Tables[0];
                comboBox2.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void ComBoxBindse()
        {
            try
            {
                comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox3.Items.Clear();
                ds2 = con.Getds("select distinct zjx_tssex07 from zhangjx_teacher07");
                comboBox3.DisplayMember = "zjx_tssex07";
                comboBox3.ValueMember = "zjx_tssex07";
                comboBox3.DataSource = ds2.Tables[0];
                comboBox3.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void ComBoxBindcl()
        {
            try
            {
                comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox4.Items.Clear();
                ds3 = con.Getds("select zjx_clno07 from zhangjx_class07");
                comboBox4.DisplayMember = "zjx_clno07";
                comboBox4.ValueMember = "zjx_clno07";
                comboBox4.DataSource = ds3.Tables[0];
                comboBox4.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmTeacherIn()
        {
            InitializeComponent();
            ComBoxBindco();
            ComBoxBindti();
            ComBoxBindse();
            ComBoxBindcl();
            Setbind();
        }

        private void btnIn_C_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into zhangjx_teacher07 values('" + txtTin_Tno.Text + "','" + comboBox4.SelectedValue.ToString() + "','" + comboBox1.SelectedValue.ToString()+ "','" + txtTnameIn.Text + "','" + comboBox3.SelectedValue.ToString() + "','" + txtTin_Age.Text + "','" + comboBox2.SelectedValue.ToString() + "','" + txtTIn_Tel.Text + "','" + txtTin_Psw.Text + "')";
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
                    sql = "delete from zhangjx_teacher07 where zjx_tno07='" + dataGview3.CurrentRow.Cells[0].Value.ToString() + "'";
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
                sql = "update zhangjx_teacher07 set zjx_tname07='" + dataGview3.CurrentRow.Cells[1].Value.ToString() + "',zjx_tsex07='" + dataGview3.CurrentRow.Cells[2].Value.ToString() + "',zjx_tbirth07='" + dataGview3.CurrentRow.Cells[3].Value.ToString() + "',zjx_tbirth07='" + dataGview3.CurrentRow.Cells[4].Value.ToString() + "',zjx_ttitle07='" + dataGview3.CurrentRow.Cells[5].Value.ToString() + "',zjx_tpassword07='" + dataGview3.CurrentRow.Cells[6].Value.ToString() + "' where zjx_tno07='" + dataGview3.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateData(sql);
                Setbind();

            }
            catch
            {
                MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_C_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTin_Psw_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
