using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            var from = new frmBai1();
            from.ShowDialog();
        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            var from = new frmBai1();
            from.ShowDialog();
        }

        private void tsmiBai2_Click_1(object sender, EventArgs e)
        {
            var from = new frmBai2();
            from.ShowDialog();
        }
    }
}
