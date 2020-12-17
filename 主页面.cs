using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 中谷业务系统页面设计
{
    public partial class 主页面 : Form
    {
        public 主页面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            修箱港口和订舱港口映射配置 v1 = new 修箱港口和订舱港口映射配置();
            v1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            保证金管理收 v1 = new 保证金管理收();
            v1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            保证金管理付 v1 = new 保证金管理付();
            v1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            成本堆存费 v1 = new 成本堆存费();
            v1.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {

            成本堆存费账单 v1 = new 成本堆存费账单();
            v1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            成本堆存费费率维护 v1 = new 成本堆存费费率维护();
            v1.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {

            成本堆存费费率查看 v1 = new 成本堆存费费率查看();
            v1.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            修箱pti管理 v1 = new 修箱pti管理();
            v1.Show();
        }
    }
}
