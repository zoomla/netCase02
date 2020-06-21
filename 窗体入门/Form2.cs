using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 打开窗体一_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void 打开窗体一_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("行，鼠标在我上面");
        }

        private void 打开窗体一_Move(object sender, EventArgs e)
        {
            MessageBox.Show("行，鼠标在我上面");

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("行，鼠标在我上面");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //使用if语句判断是否单击了“是”按钮
            if (MessageBox.Show("是否查看窗体","",MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.Yes)
            {

            }
        }
    }
}
