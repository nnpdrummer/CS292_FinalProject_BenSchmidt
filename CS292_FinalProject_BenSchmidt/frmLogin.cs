/*
 * Name: Ben Schmidt
 * Project: Final Project
 * Date:
 * Purpose:
 */

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
    public partial class frmLogin : Form
    {
        public frmLogin() { InitializeComponent(); }

        /// <summary>
        /// Initializes the controls in the login form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLoginUsername.Clear();
            txtLoginPassword.Clear();
            txtRegUsername.Clear();
            txtRegPassword.Clear();
            lblStatus.Text = "";
        }

        /// <summary>
        /// Closes this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackToMain_Click(object sender, EventArgs e) { Close(); }


        /// <summary>
        /// TODO: change implementation to check username and password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            




            frmOfficials officials = new frmOfficials();
            this.Hide();
            officials.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// TODO: change implementaton to check for a unique pair of username nad password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
