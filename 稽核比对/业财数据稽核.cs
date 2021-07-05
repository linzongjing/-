using System;

using System.Windows.Forms;
using 中谷业务系统页面设计.稽核比对;

namespace 中谷业务系统页面设计
{
    public partial class 业财数据稽核 : Form
    {
        public 业财数据稽核()
        {
            InitializeComponent();
        }

        private void 提交项配置_Click(object sender, EventArgs e)
        {
            提交项配置 v1 = new 提交项配置();
            v1.Show();
        }

        private void 稽核比对管理_Click(object sender, EventArgs e)
        {
            稽核比对管理 v1 = new 稽核比对管理();
            v1.Show();
        }

        private void 航线实算剔税利润表_Click(object sender, EventArgs e)
        {
            航线实算剔税利润表 v1 = new 航线实算剔税利润表();
            v1.Show();
        }
    }
}
