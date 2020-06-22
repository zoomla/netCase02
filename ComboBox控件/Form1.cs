using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; //设置comboBox1的下拉框样式
            string[] str = new string[] { "总经理", "副总经理", "人事部经理", "财务部经理", "部门经理", "普通职员" };
            comboBox1.DataSource = str; //指定comboBox1的数据源
            comboBox1.SelectedIndex = 0; //指定默认的第一项
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "您选择的职位为：" + comboBox1.SelectedItem; //获取comboBox1中的选中项
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;
            listBox1.ScrollAlwaysVisible = true;

            listBox1.Items.Add("品牌电脑");
            listBox1.Items.Add("iphone6");
            listBox1.Items.Add("引擎耳机");
            listBox1.Items.Add("逐浪充电宝");
            listBox1.Items.Remove("逐浪充电宝");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
