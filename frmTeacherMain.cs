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
    public partial class frmTeacherMain : Form
    {
        public string Tno;
        public void SetTno(string str)
        {
            Tno = str;
        }
        public string getTno()
        {
            return Tno;
        }
        public frmTeacherMain()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePsw fChange2 = new frmChangePsw();
            fChange2.setNum(Tno);
            fChange2.setx(3);
            fChange2.Show();
        }

        private void 个人信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selfInform f1 = new selfInform(Tno);
            f1.SetTno1(Tno);
            f1.Show();
        }

        private void 班级课表查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassCourse f2 = new frmClassCourse();
            f2.Show();
        }

        private void 课程平均成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgCourse f3 = new avgCourse(1, Tno);
            f3.Show();
        }

        private void 任课课程成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select f4 = new select(Tno);

            f4.Show();
        }

        private void 教师任课情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teaTeach f5 = new teaTeach(Tno);
            f5.Show();
        }

        private void 学生成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            教师成绩录入 f6 = new 教师成绩录入(Tno);
            f6.Show();

        }
    }
}
