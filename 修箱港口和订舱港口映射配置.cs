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
    public partial class 修箱港口和订舱港口映射配置 : Form
    {
        public 修箱港口和订舱港口映射配置()
        {
            InitializeComponent();
        }

        private void 修箱港口和订舱港口映射配置_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            修箱港口和订舱港口映射配置_新增 v1 = new 修箱港口和订舱港口映射配置_新增();
            v1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
