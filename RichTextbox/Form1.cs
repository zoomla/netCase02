using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Multiline = true; //将Multiline属性设置为true，实现多行显示 
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical; //只显示垂直滚动条
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "欢迎访问逐浪CMSP官网http://www.z01.com平台";
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.SelectionBullet = true;
        }
    }
}
