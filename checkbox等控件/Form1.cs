using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox等控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strPop = "你选择的权限如下：";
            foreach (Control ctrl in this.Controls) //遍历窗体中的所有控件件
            {
                if (ctrl.GetType().Name=="CheckBox") //判断是否为checkbox
                {
                    CheckBox cBox = (CheckBox)ctrl; //判断checkbox对象
                    if (cBox.Checked)   //判断Checkbox控件是否选中
                    {
                        strPop += "\n" + cBox.Text; //获取checkbox控件的文本
                    }
                }
            }
            MessageBox.Show(strPop);
        }
    }
}
