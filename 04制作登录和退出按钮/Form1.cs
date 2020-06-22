using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04制作登录和退出按钮
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("系统登录");  //输出信息提示
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定退出？");  //输出信息提示
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox3.Text; //label控件显示的文字随文本框中的数据而改变
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("您选择的是管理员登录");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("您选择的是普通用户登录");
        }
    }
}
