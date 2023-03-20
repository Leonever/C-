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
    public partial class frmCourseIn : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select zjx_cno07 as 课程号,zjx_cname07 as 课程名,zjx_year07 as 开课学期,zjx_ctime07 as 学时,zjx_cform07 as 考查方式,zjx_ccredit07 as 学分 from zhangjx_course07";
                con.BindDataGridView(dataGview1, sql);
                dataGview1.Columns[0].ReadOnly = true;
                dataGview1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmCourseIn()
        {
            InitializeComponent();
            SetBind();
        }

        private void btnIn_C_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into zhangjx_course07 values('" + txtCnoIn.Text + "','" + txtCnameIn.Text + "'," + txtCcreditIn.Text + "," + txtTime_C.Text + ",'" + txtTestw_C.Text + "','" + txtTerm_C.Text + "')";
                con.OperateData(sql);
                SetBind();
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
                    sql = "delete from zhangjx_course07 where zjx_cno07='" + dataGview1.CurrentRow.Cells[0].Value.ToString() + "'";
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

        private void btnChange_C_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update zhangjx_course07 set zjx_cname07='" + dataGview1.CurrentRow.Cells[1].Value.ToString() + "',zjx_year07='" + dataGview1.CurrentRow.Cells[2].Value.ToString() + "',zjx_ctime07=" + dataGview1.CurrentRow.Cells[3].Value + ",zjx_cform07='" + dataGview1.CurrentRow.Cells[4].Value.ToString() + "',zjx_ccredit07=" + dataGview1.CurrentRow.Cells[5].Value + " where zjx_cno07='" + dataGview1.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();

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

        private void txtCnoIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
