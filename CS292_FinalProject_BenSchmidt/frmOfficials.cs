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
    public partial class frmOfficials : Form
    {
        private const string DB_FOOTBALL = "Data Source = ../../highSchoolFootball.db; Version = 3";
        private const string POSITION_FILE = "positions.txt";
        private const string SCHOOL_FILE = "schools.txt";
        private const string STANDING_FILE = "standing.txt";

        private SQLiteConnection connection = new SQLiteConnection(DB_FOOTBALL);
        private SQLiteDataAdapter dataAdapter;
        private SQLiteCommand command;
        private DataSet dataSet;
        private string sql;

        public frmOfficials() { InitializeComponent(); }

        /// <summary>
        /// Sets the logged-in official's username in the label
        /// at the top of the form
        /// </summary>
        /// <param name="username"></param>
        public void setUsername(string username) { lblUsername.Text = username; }

        /// <summary>
        /// Adds values to the combo boxes on the form and
        /// displays all players to the player data grivd view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOfficials_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
            btnShowAll_Click(null, null);
        }

        /// <summary>
        /// Adds items to each combo box on the form by
        /// reading their corresponding files.
        /// </summary>
        private void populateComboBoxes()
        {
            try
            {
                string line;

                StreamReader reader = new StreamReader(POSITION_FILE);
                while ((line = reader.ReadLine()) != null) cboPosition.Items.Add(line);

                reader = new StreamReader(SCHOOL_FILE);
                while ((line = reader.ReadLine()) != null) cboSchool.Items.Add(line);

                reader = new StreamReader(STANDING_FILE);
                while ((line = reader.ReadLine()) != null) cboStanding.Items.Add(line);

                reader.Close();
            }
            catch
            {
                lblStatus.Text = "File(s) not found!";
            }
        }

        /// <summary>
        /// Enables and disables various controls if the search
        /// radio button is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radSearch_CheckedChanged(object sender, EventArgs e)
        {
            cboPosition.Enabled = true;
            cboSchool.Enabled = true;
            cboStanding.Enabled = true;
            txtPlayerID.Enabled = true;
            txtSearchPlayerName.Enabled = true;
            chkExactMatch.Enabled = true;
            btnPlayerInfoCRUD.Text = "Search for player(s)";
        }

        /// <summary>
        /// Enables and disables various controls if the add
        /// radio button is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            cboPosition.Enabled = true;
            cboSchool.Enabled = true;
            cboStanding.Enabled = true;
            txtPlayerID.Enabled = false;
            txtSearchPlayerName.Enabled = true;
            chkExactMatch.Enabled = false;
            btnPlayerInfoCRUD.Text = "Add new player";
        }

        /// <summary>
        /// Enables and disables various controls if the edit
        /// radio button is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radEdit_CheckedChanged(object sender, EventArgs e)
        {
            cboPosition.Enabled = true;
            cboSchool.Enabled = true;
            cboStanding.Enabled = true;
            txtPlayerID.Enabled = true;
            txtSearchPlayerName.Enabled = true;
            chkExactMatch.Enabled = false;
            btnPlayerInfoCRUD.Text = "Edit existing player";
        }

        /// <summary>
        /// Enables and disables various controls if the remove
        /// radio button is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radRemove_CheckedChanged(object sender, EventArgs e)
        {
            cboPosition.Enabled = false;
            cboSchool.Enabled = false;
            cboStanding.Enabled = false;
            txtPlayerID.Enabled = true;
            txtSearchPlayerName.Enabled = false;
            btnPlayerInfoCRUD.Text = "Remove existing player";
        }

        /// <summary>
        /// Depending on what radio button is selected on the form,
        /// either adds a player to the database, edits a player in the database,
        /// removes a player from the database, or queries player(s) from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayerInfoCRUD_Click(object sender, EventArgs e)
        {
            errorProviderOfficials.Clear();
            if(radSearch.Checked) searchDatabase();
            else if(radAdd.Checked) addToDatabase();
            else if(radEdit.Checked) editDatabase();
            else removeFromDatabase();
        }

        /// <summary>
        /// Searches the database for players whose names and/or
        /// Id's are equal to those that the user entered.
        /// </summary>
        private void searchDatabase()
        {
            string playerID = txtPlayerID.Text;
            string playerName = txtSearchPlayerName.Text;

            if (playerID.Equals("") && playerName.Equals(""))
            {
                errorProviderOfficials.SetError(txtPlayerID, "Please enter a value for player ID");
                errorProviderOfficials.SetError(txtSearchPlayerName, "Please enter a value for player name");
                lblStatus.Text = "Please enter data for either/both the player ID and/or the player name.";
            }
            else if (!playerID.Equals("") && playerName.Equals(""))
            {
                sql = "SELECT * FROM StudentFootballPlayer WHERE Id = \'" + playerID +"\'";
            }
            else if (playerID.Equals("") && !playerName.Equals(""))
            {
                if (chkExactMatch.Checked)
                    sql = "SELECT * FROM StudentFootballPlayer WHERE Name = \'" + playerName + "\'";
                else
                    sql = "SELECT * FROM StudentFootballPlayer WHERE Name LIKE '%" + playerName + "%'";
            }
            else
            {
                if (chkExactMatch.Checked)
                    sql = "SELECT * FROM StudentFootballPlayer WHERE Id = \'" + playerID + "\' AND Name = \'" + playerName + "\'";
                else
                    sql = "SELECT * FROM StudentFootballPlayer WHERE Id = \'" + playerID + "\' AND Name LIKE '%" + playerName +"%'";
            }
            fillDataGridTable();
        }
        
        /// <summary>
        /// Displays the additional player info form.
        /// And notifies the user when the player has
        /// successfully been added to the database.
        /// </summary>
        private void addToDatabase()
        {
            frmAdditionalPlayerInfo aPI = new frmAdditionalPlayerInfo();
            aPI.setEdit(false);
            if (checkPlayerInfo()) return;
            aPI.setName(txtSearchPlayerName.Text);
            aPI.setPosition(cboPosition.SelectedItem.ToString());
            aPI.setSchool(cboSchool.SelectedItem.ToString());
            aPI.setStanding(cboStanding.SelectedItem.ToString());
            aPI.ShowDialog();
            lblStatus.Text = "You have successfully added a player from the database!";
        }

        /// <summary>
        /// Ensures that the user's entered id matches that of an existing player,
        /// displays the additional player info form, and notifies the user of a successful
        /// edit.
        /// </summary>
        private void editDatabase()
        {
            if (!ensurePlayerID())
            {
                errorProviderOfficials.SetError(txtPlayerID, "Invalid Player ID");
                lblStatus.Text = "Entered player ID does not belong to an existing player!";
                return;
            }
            frmAdditionalPlayerInfo aPI = new frmAdditionalPlayerInfo();
            aPI.setEdit(true);
            aPI.setID(int.Parse(txtPlayerID.Text));
            if (checkPlayerInfo()) return;
            aPI.setName(txtSearchPlayerName.Text);
            aPI.setPosition(cboPosition.SelectedItem.ToString());
            aPI.setSchool(cboSchool.SelectedItem.ToString());
            aPI.setStanding(cboStanding.SelectedItem.ToString());
            aPI.ShowDialog();

            lblStatus.Text = "You have successfully edited a player from the database!";
        }

        /// <summary>
        /// Checks to see if the name textbox and all of the combo boxes
        /// have values in them.
        /// </summary>
        /// <returns>True if there is input in all of the controls, False if not.</returns>
        private bool checkPlayerInfo()
        {
            if(txtSearchPlayerName.Equals(""))
            {
                errorProviderOfficials.SetError(txtSearchPlayerName, "Please enter the player's name!");
                return true;
            }
            if (cboPosition.SelectedIndex == 0)
            {
                errorProviderOfficials.SetError(cboPosition, "Please enter the player's position!");
                return true;
            }
            if (cboSchool.SelectedIndex == 0)
            {
                errorProviderOfficials.SetError(cboSchool, "Please enter the player's school!");
                return true;
            }
            if (cboStanding.SelectedIndex == 0)
            {
                errorProviderOfficials.SetError(cboStanding, "Please enter the player's class standing!");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes a player, specified by the user's entered id, from
        /// the database.
        /// </summary>
        private void removeFromDatabase()
        {
            string id = txtPlayerID.Text;
            if(id.Length == 0)
            {
                errorProviderOfficials.SetError(txtPlayerID, "Please enter an ID");
                lblStatus.Text = "Please enter the ID of the player you want to remove!";
                return;
            }
            if(!ensurePlayerID())
            {
                errorProviderOfficials.SetError(txtPlayerID, "Please enter an existing ID");
                lblStatus.Text = "Please enter an ID that belongs to the player you want to remove!";
                return;
            }
            sql = "DELETE FROM StudentFootballPlayer WHERE Id = @id";

            connection.Open();
            command = new SQLiteCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();

            lblStatus.Text = "Player: " + id + " was removed from database!";
        }

        /// <summary>
        /// Displays all of the players to the player data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT * FROM StudentFootballPlayer";
            fillDataGridTable();
        }

        /// <summary>
        /// Queries all players and their associated stats depending 
        /// on the position selected in the position combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!radSearch.Checked || cboPosition.SelectedIndex == -1) return;
            string position = cboPosition.SelectedItem.ToString();
            connection.Open();
            sql = "Select Id, Name, Position, School, Standing";
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

            fillDataGridTable();
        }

        /// <summary>
        /// Queries all players that go to a certain school provided by the
        /// school combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!radSearch.Checked || cboSchool.SelectedIndex == -1) return;
            string school = cboSchool.SelectedItem.ToString();
            connection.Open();
            sql = "Select Id, Name, Position, School, Standing" +
                " FROM StudentFootballPlayer WHERE School = \'" + school + "\'";

            fillDataGridTable();
        }

        /// <summary>
        /// Queries all players that belong to a certain class standing
        /// provided by the standing combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStanding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!radSearch.Checked || cboStanding.SelectedIndex == -1) return;
            string standing = cboStanding.SelectedItem.ToString();
            connection.Open();
            sql = "Select Id, Name, Position, School, Standing" +
                " FROM StudentFootballPlayer WHERE Standing = \'" + standing + "\'";

            fillDataGridTable();
        }

        /// <summary>
        /// Fills the player data grid view with the query results
        /// of any of the above, or below, functions.
        /// </summary>
        private void fillDataGridTable()
        {
            dataSet = new DataSet();
            dataAdapter = new SQLiteDataAdapter(sql, connection);
            dataAdapter.Fill(dataSet);
            connection.Close();
            dgvPlayers.DataSource = dataSet.Tables[0].DefaultView;
            dgvPlayers.ClearSelection();
        }

        /// <summary>
        /// Ensures that the user's entered ID matches that of
        /// an existing player.
        /// </summary>
        /// <returns>True if the IDs match, False if not.</returns>
        private bool ensurePlayerID()
        {
            sql = "SELECT COUNT(*) FROM StudentFootballPlayer WHERE Id = @id";
            connection.Open();

            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id", txtPlayerID.Text);
            int linesCounted = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if (linesCounted == 1) return true;
            else if (linesCounted == 0)
            {
                lblStatus.Text = "The entered player ID does not belong to an existing player!";
                errorProviderOfficials.SetError(txtPlayerID, "Invalid Login Credentials!");
            }
            return false;
        }

        /// <summary>
        /// Ensures that only digits may be entered in the
        /// player ID text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPlayerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }

        /// <summary>
        /// Displays all of the players to the player data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllToolStripMenuItem_Click(object sender, EventArgs e) { btnShowAll_Click(null, null); }

        /// <summary>
        /// TODO: Create implementation later.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOfficialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.ShowDialog();
        }

        /// <summary>
        /// Logs the official out of the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) { Close(); }
    }
}
