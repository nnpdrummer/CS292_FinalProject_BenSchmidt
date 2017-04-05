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
    public partial class frmOfficials : Form
    {
        public frmOfficials()
        {
            InitializeComponent();
        }

        private void frmOfficials_Load(object sender, EventArgs e)
        {
            //clear controls
        }

        private void radSearch_CheckedChanged(object sender, EventArgs e)
        {
            cboPosition.Enabled = true;
            cboSchool.Enabled = true;
            txtPlayerID.Enabled = true;
            txtSearchPlayerName.Enabled = true;
            chkExactMatch.Enabled = true;
            btnPlayerInfoCRUD.Text = "Search for player(s)";
        }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            cboPosition.Enabled = true;
            cboSchool.Enabled = true;
            txtPlayerID.Enabled = true;
            txtSearchPlayerName.Enabled = true;
            chkExactMatch.Enabled = false;
            btnPlayerInfoCRUD.Text = "Add new player";
        }

        private void radEdit_CheckedChanged(object sender, EventArgs e)
        {
            cboPosition.Enabled = true;
            cboSchool.Enabled = true;
            txtPlayerID.Enabled = true;
            txtSearchPlayerName.Enabled = true;
            chkExactMatch.Enabled = false;
            btnPlayerInfoCRUD.Text = "Edit existing player";
        }

        private void radRemove_CheckedChanged(object sender, EventArgs e)
        {
            cboPosition.Enabled = false;
            cboSchool.Enabled = false;
            txtPlayerID.Enabled = true;
            txtSearchPlayerName.Enabled = false;
            btnPlayerInfoCRUD.Text = "Remove existing player";
        }

        private void btnPlayerInfoCRUD_Click(object sender, EventArgs e)
        {
            if(radSearch.Checked)
            {
                searchDatabase();
            }
            else if(radAdd.Checked)
            {
                addToDatabase();
            }
            else if(radEdit.Checked)
            {
                editDatabase();
            }
            else
            {
                removeFromDatabase();
            }
        }

        private void searchDatabase()
        {
            lblStatus.Text = "You have successfully searched for a player from the database!";
        }
        
        private void addToDatabase()
        {
            frmAdditionalPlayerInfo aPI = new frmAdditionalPlayerInfo();
            aPI.ShowDialog();
            lblStatus.Text = "You have successfully added a player from the database!";
        }

        private void editDatabase()
        {
            frmAdditionalPlayerInfo aPI = new frmAdditionalPlayerInfo();
            aPI.ShowDialog();
            lblStatus.Text = "You have successfully edited a player from the database!";
        }

        private void removeFromDatabase()
        {
            lblStatus.Text = "You have successfully removed a player from the database!";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //Display all players in database to GUI
            //Display message to status label telling user that all players are being shown
        }

        private void btnLogout_Click(object sender, EventArgs e) { Close(); }

        
    }
}
