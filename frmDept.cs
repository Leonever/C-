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
    public partial class frmDept : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select zjx_spno07 as 系号,zjx_spname07 as 系名,zjx_cono07 as 学院编号 from zhangjx_speciality07";
                con.BindDataGridView(dataGView_DIn, sql);
                dataGView_DIn.Columns[0].ReadOnly = true;
                dataGView_DIn.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmDept()
        {
            InitializeComponent();
            SetBind();
        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into zhangjx_speciality07 values('" + txtDnoIn.Text + "','" + txtDnameIn.Text + "','" + textBox1.Text + "')";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_D_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from zhangjx_speciality07 where zjx_spno07='" + dataGView_DIn.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnChange_D_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update zhangjx_speciality07 set zjx_spno07='" + dataGView_DIn.CurrentRow.Cells[1].Value.ToString() + "' where zjx_spno07='" + dataGView_DIn.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();

            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_D_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDnameIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDnoIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
