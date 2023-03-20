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
    public partial class souStudent : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void Setbind()
        {
            try
            {
                //sql = "select distinct zjx_sadd07 as 地区,count(zjx_sadd07) as 人数 from zhangjx_student07";
                sql = "select * from zjx_stusourse07";
                con.BindDataGridView(dataGridView11, sql);
                dataGridView11.ReadOnly = true;
                dataGridView11.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public souStudent()
        {
            InitializeComponent();
            Setbind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
