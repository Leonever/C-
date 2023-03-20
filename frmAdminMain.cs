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
    public partial class frmAdminMain : Form
    {
        public string Ano = "";
        public void SetAno(string str)
        {
            Ano = str;
        }
        public string getAno()
        {
            return Ano;
        }
        public frmAdminMain()
        {
            InitializeComponent();
        }

        private void 教师ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTeacherIn f4 = new frmTeacherIn();
            f4.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 系别输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDept fDept = new frmDept();
            fDept.Show();
        }

        private void 修改密码ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmChangePsw fChange = new frmChangePsw();
            fChange.setx(1);
            fChange.setNum(Ano);
            fChange.Show();
        }

        private void 课程表导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourseIn frmCIn = new frmCourseIn();
            frmCIn.Show();
        }

        private void 学生个人信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectStu fs = new frmSelectStu();
            fs.Show();
        }

        private void 新生信息导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInStu f2 = new frmInStu();
            f2.Show();
        }

        private void 教师基本信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectTe f3 = new frmSelectTe();
            f3.Show();

        }

        private void 教师任课情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmteach f5 = new frmteach();
            f5.Show();
        }

        private void 班级课表查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassCourse f6 = new frmClassCourse();
            f6.Show();
        }

        private void 生源人数统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            souStudent f7 = new souStudent();
            f7.Show();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgCourse f8 = new avgCourse(1, Ano);
            f8.Show();
        }

        private void 教师教课添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCourse f9 = new addCourse();
            f9.Show();
        }

        private void 教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 公共查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
