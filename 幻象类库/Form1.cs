using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using Cjing.Net;

using static Cjing.Net.常量;
namespace 幻象类库
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = int.TryParse("123-123", out _);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.Write(小数型.新建(12.35).四舍五入(1));


            decimal 目标变量 = 0;
            逻辑型 变量 = 逻辑型.新建();
            if (变量 == 真)
            {

            }

            整数型 测试变量1 = 整数型.新建(666);
            整数型 测试变量2 = 整数型.新建("777");

            目标变量 = 测试变量2.内容;



            目标变量 = (测试变量1 + 目标变量).内容;
        }
    }
}
