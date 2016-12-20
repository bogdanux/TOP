using System;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmConectareUser : Form
    {
        public frmConectareUser()
        {
            InitializeComponent();
            txtParolaUser.Enabled = false;
            btnConectare.Enabled = false;
        }

        private void txtIdUser_TextChanged(object sender, EventArgs e)
        {
            if (txtIdUser.Text != string.Empty)
            {
                txtParolaUser.Enabled = true;
            }
            else
            {
                txtParolaUser.Enabled = false;
                txtParolaUser.Clear();
                btnConectare.Enabled = false;
            }
        }

        private void txtParolaUser_TextChanged(object sender, EventArgs e)
        {
            if (txtParolaUser.Text != string.Empty)
            {
                btnConectare.Enabled = true;
            }
            else
            {
                btnConectare.Enabled = false;
            }
        }
    }
}
