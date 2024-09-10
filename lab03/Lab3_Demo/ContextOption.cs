using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
    public partial class ContextOption : Form
    {
        public string infor = "";
        public int type = 0;

        public ContextOption()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckType()
        {
            if (rdID.Checked)
            {
                type = 0;
                this.DialogResult = DialogResult.OK;
            }
            else if (rdName.Checked)
            {
                type = 1;
                this.DialogResult = DialogResult.OK;
            }
            else if (rdDateOfBirth.Checked)
            {
                type = 2;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            infor = txtInfor.Text;
            CheckType();
        }

        private void ContextOption_Load(object sender, EventArgs e)
        {

        }

        private void txtInfor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.btnFind_Click(this, null);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            CheckType();
        }
    }
}
