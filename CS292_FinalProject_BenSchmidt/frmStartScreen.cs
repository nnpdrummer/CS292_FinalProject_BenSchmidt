/*
 * Name: Ben Schmidt
 * Project: Final Project
 * Date:
 * Purpose:
 */

using System;
using System.Data;
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
        /// Searches for either an exact or similar matching name to the
        /// name entered in the name text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchPlayerName.Text;
            connection.Open();
            sql = "Select Name, Position, School, Standing FROM StudentFootballPlayer WHERE Name ";

            if (radExactMatch.Checked) sql +=  "= \'" + name + "\'";
            else if(radSimilarMatch.Checked) sql += "LIKE '%" + name + "%'";

            fillDataGridView();
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
        /// Displays all of the players in the StudentFootballPlayer table
        /// to the appropriate dgv.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT Name, School, Standing, Position FROM StudentFootballPlayer";

            fillDataGridView();
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
            }
            sql += " FROM StudentFootballPlayer WHERE Position = \'" + position + "\'";

            fillDataGridView();
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

            fillDataGridView();
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

            fillDataGridView();
        }

        /// <summary>
        /// Fills the player data grid view with the query results obtained
        /// in various functions.
        /// </summary>
        private void fillDataGridView()
        {
            dataSet = new DataSet();
            dataAdapter = new SQLiteDataAdapter(sql, connection);
            dataAdapter.Fill(dataSet);
            connection.Close();
            dgvPlayers.DataSource = dataSet.Tables[0].DefaultView;
            dgvPlayers.ClearSelection();
        }

        /// <summary>
        /// Displays the login form. Once the login form is closed,
        /// redisplays the start screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuItemLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
            resetControls();
            this.Show();
        }

        /// <summary>
        /// Displays all of the players in the StudentFootballPlayer table
        /// to the appropriate dgv.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuItemShowAll_Click(object sender, EventArgs e) { btnShowAll_Click(null, null); }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuItemExit_Click(object sender, EventArgs e) { Close(); }
    }
}
