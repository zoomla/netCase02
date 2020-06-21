using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图形窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bit;//声明一个Bitmap位图对象
        private void Form1_Load(object sender, EventArgs e)
        {
            bit = new Bitmap("bccd.png");//从指定的图像初始化Bitmap对象
            bit.MakeTransparent(Color.Blue);//使用默认的透明颜色对Bitmap位图透明
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage((Image)bit, new Point(0, 0));//在窗体上绘制图片
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
