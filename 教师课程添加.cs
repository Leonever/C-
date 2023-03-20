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
    public partial class addCourse : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        public DataSet dc = new DataSet();
        public DataSet dt = new DataSet();
        public DataSet dco = new DataSet();

        private string sql;
        protected void ComBoxBindc1()
        {
            try
            {
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.Items.Clear();
                dco = con.Getds("select zjx_cono07,zjx_coname07 from zhangjx_college07");
                comboBox1.DisplayMember = "zjx_cono07";
                comboBox1.ValueMember = "zjx_cono07";
                comboBox1.DataSource = dco.Tables[0];
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void ComBoxBind1()
        {
            try
            {
                cmbCL1.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbCL1.Items.Clear();
                ds = con.Getds("select zjx_clno07 from zhangjx_class07");
                cmbCL1.DisplayMember = "zjx_clno07";
                cmbCL1.ValueMember = "zjx_clno07";
                cmbCL1.DataSource = ds.Tables[0];
                cmbCL1.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void ComBoxBindC()
        {
            try
            {
                cmbCname1.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbCname1.Items.Clear();
                dc = con.Getds("select zjx_cno07,zjx_cname07 from zhangjx_course07");
                cmbCname1.DisplayMember = "zjx_cno07";
                cmbCname1.ValueMember = "zjx_cno07";
                cmbCname1.DataSource = dc.Tables[0];
                cmbCname1.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作C！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void ComBoxBindT()
        {
            try
            {
                cmbTea1.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTea1.Items.Clear();
                dt = con.Getds("select  zjx_tno07,zjx_tname07 from zhangjx_teacher07 ");
                cmbTea1.DisplayMember = "zjx_tno07";
                cmbTea1.ValueMember = "zjx_tno07";
                cmbTea1.DataSource = dt.Tables[0];
                cmbTea1.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void SetBind()
        {
            try
            {
                sql = "select * from zhangjx_courses07";
                con.BindDataGridView(dataGridView12, sql);
                dataGridView12.Columns[0].ReadOnly = true;
                dataGridView12.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public addCourse()
        {
            InitializeComponent();
            ComBoxBind1();
            ComBoxBindC();
            ComBoxBindT();
            ComBoxBindc1();
            SetBind();
        }

        private void btnjia_Click(object sender, EventArgs e)
        {
            try
            {
                //sql = "insert into zhangjx_courses07 values('" + cmbCname1.SelectedValue.ToString() + "','" + cmbCL1.SelectedValue.ToString() + "','" + cmbTea1.SelectedValue.ToString() + "','" + textBox2.Text + "','" + comboBox1.SelectedValue.ToString() + "')";
                //sql = "insert into zhangjx_courses07 values('" + cmbCname1.SelectedValue.ToString() + "','" + cmbCL1.SelectedValue.ToString() + "','" + cmbTea1.SelectedValue.ToString() + "','"+textBox2.Text.ToString+ "','" + comboBox1.SelectedValue.ToString() + "')";
                //sql = "insert into zhangjx_courses07 values('" + cmbCname1.SelectedValue.ToString() + "','" + cmbCL1.SelectedValue.ToString() + "','" + cmbTea1.SelectedValue.ToString() + "','" + textBox2.Text + "','" + comboBox1.SelectedValue.ToString() + "')";
                sql = "insert into zhangjx_courses07 values('" + cmbCname1.SelectedValue.ToString() + "','" + cmbCL1.SelectedValue.ToString() + "','" + cmbTea1.SelectedValue.ToString() + "','" + textBox2.Text.ToString() + "','" + comboBox1.SelectedValue.ToString() + "')";
                con.OperateData(sql);
                SetBind();
                MessageBox.Show("插入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("插入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmbTea1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCL1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void cmbCname1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
