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
    public partial class frmStudentMain : Form
    {
        public string Sno;
        public void SetSno(string str)
        {
            Sno = str;
        }
        public string getSno()
        {
            return Sno;
        }
        public frmStudentMain()
        {
            InitializeComponent();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePsw fChange1 = new frmChangePsw();
            fChange1.setNum(Sno);
            fChange1.setx(2);
            fChange1.Show();
        }

        private void 个人信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            学生端个人信息 f1 = new 学生端个人信息(Sno);
            f1.SetSno1(Sno);
            f1.Show();
        }

        private void 课表查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            学生端课表查询 f2 = new 学生端课表查询();
            f2.SetSno_C(Sno);
            f2.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 课程平均成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgCourse f3 = new avgCourse(2, Sno);
            f3.Show();
        }

        private void 个人成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            学生端成绩查询 f4 = new 学生端成绩查询();
            f4.SetSno_C(Sno);
            f4.Show();

        }

        private void 个人总成绩打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
