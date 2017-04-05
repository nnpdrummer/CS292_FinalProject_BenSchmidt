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
    public partial class frmStartScreen : Form
    {
        public frmStartScreen() { InitializeComponent(); }

        /// <summary>
        /// Initializes all controls on the start screen form and displays
        /// a welcome message to the user through the status label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStartScreen_Load(object sender, EventArgs e)
        {
            resetControls();
            chkEnableSearchFilter.Checked = false;
            lblStatus.Text = "Welcome to the High School Football Stats Tracker!";
        }

        /// <summary>
        /// Makes the search filter group box either visible or invisible depending 
        /// on the status of the enable search filter check box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkEnableSearchFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableSearchFilter.Checked)
            {
                grpSearchFilter.Visible = true;
                return;
            }
            grpSearchFilter.Visible = false;
        }

        /// <summary>
        /// Yet to be implemented.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search for players with information in controls.
        }

        /// <summary>
        /// Clears all of the controls in the search filter group box.
        /// Displays a confirmation message to the status label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            resetControls();
            lblStatus.Text = "Search Filters cleared!";
        }

        /// <summary>
        /// Displays the login form. Once the login form is closed,
        /// redisplays the start screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOfficialLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Visible = false;
            login.ShowDialog();
            resetControls();
            this.Visible = true;
        }

        /// <summary>
        /// Re-initializes all controls on the start screen form.
        /// </summary>
        private void resetControls()
        {
            cboPosition.SelectedItem = -1;
            cboSchool.SelectedItem = -1;
            txtSearchPlayerName.Text = "";
            radExactMatch.Select();
        }

        /// <summary>
        /// Exits the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) { Close(); }
    }
}
