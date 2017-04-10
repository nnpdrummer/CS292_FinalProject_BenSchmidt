using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS292_FinalProject_BenSchmidt
{
    public partial class frmAdditionalPlayerInfo : Form
    {
        public frmAdditionalPlayerInfo()
        {
            InitializeComponent();
        }

        private void frmAdditionalPlayerInfo_Load(object sender, EventArgs e)
        {
            btnClear_Click(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)// TODO: fix this
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox) c.Text = "";
            }
            MessageBox.Show("Did it go through?");
        }

    private void btnAddEditPlayer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
