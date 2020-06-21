using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); //创建form2窗体的对象
            frm2.MdiParent = this;  //设置mdiparent属性，将当前窗体作为父窗体
            frm2.Show();            //设置show方法打开窗体
            Form3 frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show(); 
            Form4 frm4 = new Form4();
            frm4.MdiParent = this;
            frm4.Show();

        }

        private void 垂直平鲜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical); //层叠排列

        }

        private void 加载子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal); //水平平铺

        }

        private void 层叠排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade); //层叠排列

        }
    }
}
