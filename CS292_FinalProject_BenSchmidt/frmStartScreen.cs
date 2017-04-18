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
using System.Data.SQLite;
using System.IO;

namespace CS292_FinalProject_BenSchmidt
{
    public partial class frmStartScreen : Form
    {
        private const string DB_FOOTBALL = "Data Source = ../../highSchoolFootball.db; Version = 3";
        private const string POSITION_FILE = "positions.txt";
        private const string SCHOOL_FILE = "schools.txt";
        private const string STANDING_FILE = "standing.txt";

        private SQLiteConnection connection = new SQLiteConnection(DB_FOOTBALL);
        private SQLiteDataAdapter dataAdapter;
        //private SQLiteCommand command;
        private DataSet dataSet;
        private String sql;

        public frmStartScreen() { InitializeComponent(); }

        /// <summary>
        /// Initializes all controls on the start screen form and displays
        /// a welcome message to the user through the status label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStartScreen_Load(object sender, EventArgs e)
        {
            btnShowAll_Click(null, null);
            resetControls();
            populateComboBoxes();
            chkEnableSearchFilter.Checked = false;
            lblStatus.Text = "Welcome to the High School Football Stats Tracker!";
        }

        /// <summary>
        /// Initializes all of the items contained in the position, school, and
        /// standing combo boxes.
        /// </summary>
        private void populateComboBoxes()
        {
            try
            {
                string line;

                StreamReader reader = new StreamReader(POSITION_FILE);
                while((line = reader.ReadLine()) != null) cboPosition.Items.Add(line);

                reader = new StreamReader(SCHOOL_FILE);
                while((line = reader.ReadLine()) != null) cboSchool.Items.Add(line);

                reader = new StreamReader(STANDING_FILE);
                while((line = reader.ReadLine()) != null) cboStanding.Items.Add(line);

                reader.Close();
            }
            catch
            {
                lblStatus.Text = POSITION_FILE + " not found!";
            }
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
        /// Searches for either an exact or similar matching name to the
        /// name entered in the name text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchPlayerName.Text;
            connection.Open();
            if(radExactMatch.Checked)
            {
                sql = "Select Name, Position, School, Standing" +
                " FROM StudentFootballPlayer WHERE Name = \'" + name + "\'";
            }
            else if(radSimilarMatch.Checked)
            {
                sql = "Select Name, Position, School, Standing" +
                " FROM StudentFootballPlayer WHERE Name LIKE '%" + name + "%'";
            }
            dataSet = new DataSet();
            dataAdapter = new SQLiteDataAdapter(sql, connection);
            dataAdapter.Fill(dataSet);
            connection.Close();
            dgvPlayers.DataSource = dataSet.Tables[0].DefaultView;
            dgvPlayers.ClearSelection();
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
            this.Hide();
            login.ShowDialog();
            resetControls();
            this.Show();
        }

        /// <summary>
        /// Re-initializes all controls on the start screen form.
        /// </summary>
        private void resetControls()
        {
            cboPosition.SelectedIndex = -1;
            cboSchool.SelectedIndex = -1;
            cboStanding.SelectedIndex = -1;
            txtSearchPlayerName.Text = "";
            radExactMatch.Select();
        }

        /// <summary>
        /// Exits the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) { Close(); }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT Name, School, Standing, Position FROM StudentFootballPlayer";
            dataSet = new DataSet();

            dataAdapter = new SQLiteDataAdapter(sql, connection);
            dataAdapter.Fill(dataSet);
            connection.Close();

            dgvPlayers.DataSource = dataSet.Tables[0].DefaultView;
            dgvPlayers.ClearSelection();
        }

        /// <summary>
        /// Queries all players and their associated stats depending 
        /// on the position selected in the position combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPosition.SelectedIndex == -1) return;
            string position = cboPosition.SelectedItem.ToString();
            connection.Open();
            sql = "Select Name, Position, School, Standing";
            switch (position)
            {
                case "QB":
                    sql += ", \"Passing Yards\", \"Pass Attempts\", \"Pass Completions\", \"Passing TDs\", " +
                        "\"Passing Interceptions\"";
                    break;
                case "RB":
                    sql += ", \"Rushing Yards\", \"Rushing Attempts\", \"Rushing TDs\", \"Fumbles\" ";
                    break;
                case "WR": case "TE":
                    sql += ", \"Receiving Yards\", \"Receptions\", \"Receiving TDs\" ";
                    break;
                case "DT": case "DE": case "MLB": case "OLB": case "CB": case "S":
                    sql += ", \"Tackles\", \"Assisted Tackles\", \"Sacks\", \"Interceptions\", \"Safeties\"" +
                        ", \"Forced Fumbles\" ";
                    break;
                case "K": case "P":
                    sql += ", \"Field Goals Attempted\", \"Field Goals Made\", \"Punt Yards\", \"Kick Yards\", \"Touchbacks\" ";
                    break;
                default:
                    break;
            }
            sql += " FROM StudentFootballPlayer WHERE Position = \'" + position + "\'";

            dataSet = new DataSet();
            dataAdapter = new SQLiteDataAdapter(sql, connection);
            dataAdapter.Fill(dataSet);
            connection.Close();
            dgvPlayers.DataSource = dataSet.Tables[0].DefaultView;
            dgvPlayers.ClearSelection();
        }

        /// <summary>
        /// Queries all players that go to a certain school provided by the
        /// school combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSchool.SelectedIndex == -1) return;
            string school = cboSchool.SelectedItem.ToString();
            connection.Open();
            sql = "Select Name, Position, School, Standing" + 
                " FROM StudentFootballPlayer WHERE School = \'" + school + "\'";

            dataSet = new DataSet();
            dataAdapter = new SQLiteDataAdapter(sql, connection);
            dataAdapter.Fill(dataSet);
            connection.Close();
            dgvPlayers.DataSource = dataSet.Tables[0].DefaultView;
            dgvPlayers.ClearSelection();
        }

        /// <summary>
        /// Queries all players that belong to a certain class standing
        /// provided by the standing combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStanding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStanding.SelectedIndex == -1) return;
            string standing = cboStanding.SelectedItem.ToString();
            connection.Open();
            sql = "Select Name, Position, School, Standing" +
                " FROM StudentFootballPlayer WHERE Standing = \'" + standing + "\'";

            dataSet = new DataSet();
            dataAdapter = new SQLiteDataAdapter(sql, connection);
            dataAdapter.Fill(dataSet);
            connection.Close();
            dgvPlayers.DataSource = dataSet.Tables[0].DefaultView;
            dgvPlayers.ClearSelection();
        }
    }
}
