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

namespace CS292_FinalProject_BenSchmidt
{
    public partial class frmAdditionalPlayerInfo : Form
    {
        private const string DB_FOOTBALL = "Data Source = ../../highSchoolFootball.db; Version = 3";
        private bool isEdit;
        private int id;
        private string name;
        private string school;
        private string standing;
        private string position;
        private bool inputIsNotValid;

        private SQLiteConnection connection = new SQLiteConnection(DB_FOOTBALL);
        private SQLiteDataAdapter dataAdapter;
        private SQLiteCommand command;
        private DataSet dataSet;
        private string sql;

        public frmAdditionalPlayerInfo() { InitializeComponent(); }

        private void frmAdditionalPlayerInfo_Load(object sender, EventArgs e)
        {
            inputIsNotValid = false;
            btnClear_Click(null, null);
        }

        public void setEdit(bool choice) { isEdit = choice; }

        public void setID(int newID) { id = newID; }
        public void setName(string newName) { name = newName; }
        public void setSchool(string newSchool) { school = newSchool; }
        public void setStanding(string newStanding) { standing = newStanding; }
        public void setPosition(string newPosition) { position = newPosition; }

        private void btnClear_Click(object sender, EventArgs e)// TODO: fix this
        {
            errorProviderAPI.Clear();
            clearTextboxes(this);
        }

        private void clearTextboxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox) c.Text = string.Empty;
                if (c is GroupBox) clearTextboxes(c);
            }
        }

        private void btnAddEditPlayer_Click(object sender, EventArgs e)
        {
            errorProviderAPI.Clear();
            checkUserInput(this);
            if (inputIsNotValid)
            {
                inputIsNotValid = false;
                return;
            }
            if (isEdit) updateDatabase();
            else addToDatabase();
            Close();
        }

        private void checkUserInput(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is GroupBox) checkUserInput(c);
                if (c is TextBox)
                {
                    int parsedValue;
                    if (c.Text.Equals("")) continue;
                    if(!int.TryParse(c.Text, out parsedValue))
                    {
                        errorProviderAPI.SetError(c, "All entered values must be in the form of an integer!");
                        inputIsNotValid = true;
                        return;
                    }
                }
            }
        }

        private void updateDatabase()
        {
            sql = "UPDATE StudentFootballPlayer SET Name = @name, School = @school, Standing = @standing, " +
                "Position = @position, \"Passing Yards\" = @passingYards, \"Pass Attempts\" = @passAttempts, " + 
                "\"Pass Completions\" = @passCompletions, \"Passing TDs\" = @passingTDs, \"Passing Interceptions\" "+ 
                "= @passingInterceptions, \"Receiving Yards\" = @receivingYards, Receptions = @receptions, " + 
                "\"Receiving TDs\" = @receivingTDs, \"Rushing Yards\" = @rushingYards, \"Rushing Attempts\" = "+ 
                "@rushingAttempts, \"Rushing TDs\" = @rushingTDs, Fumbles = @fumbles, Tackles = @tackles, " + 
                "\"Assisted Tackles\" = @assistedTackles, Sacks = @sacks, Interceptions = @interceptions, " + 
                "Safeties = @safeties, \"Forced Fumbles\" = @forcedFumbles, \"Field Goals Attempted\" = " + 
                "@fieldGoalsAttempted, \"Field Goals Made\" = @fieldGoalsMade, \"Punt Yards\" = @puntYards, " + 
                "\"Kick Yards\" = @kickYards, Touchbacks = @touchbacks WHERE Id = @id";
            connection.Open();
            command = new SQLiteCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            setParameters();

            command.ExecuteNonQuery();
            connection.Close();
        }
        
        private void addToDatabase()
        {
            sql = "INSERT INTO StudentFootballPlayer(Name, School, Standing, Position, \"Passing Yards\", \"Pass Attempts\", "+
                "\"Pass Completions\", \"Passing TDs\", \"Passing Interceptions\", \"Receiving Yards\", Receptions, " +
                "\"Receiving TDs\", \"Rushing Yards\", \"Rushing Attempts\", \"Rushing TDs\", Fumbles, Tackles, " +
                "\"Assisted Tackles\", Sacks, Interceptions, Safeties, \"Forced Fumbles\", \"Field Goals Attempted\", " + 
                "\"Field Goals Made\", \"Punt Yards\", \"Kick Yards\", Touchbacks) VALUES (@name, @school, @standing, " + 
                "@position, @passingYards, @passAttempts, @passCompletions, @passingTDs, @passingInterceptions, " + 
                "@receivingYards, @receptions, @receivingTDs, @rushingYards, @rushingAttempts, @rushingTDs, @fumbles, " + 
                "@tackles, @assistedTackles, @sacks, @interceptions, @safeties, @forcedFumbles, @fieldGoalsAttempted, " + 
                "@fieldGoalsMade, @puntYards, @kickYards, @touchbacks)";

            connection.Open();
            command = new SQLiteCommand(sql, connection);
            setParameters();

            command.ExecuteNonQuery();
            connection.Close();
        }

        private void setParameters()
        {
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@school", school);
            command.Parameters.AddWithValue("@standing", standing);
            command.Parameters.AddWithValue("@position", position);
            command.Parameters.AddWithValue("@passingYards", txtPassingYards.Text);
            command.Parameters.AddWithValue("@passAttempts", txtPassingAttempts.Text);
            command.Parameters.AddWithValue("@passCompletions", txtPassingCompletions.Text);
            command.Parameters.AddWithValue("@passingTDs", txtPassingTDs.Text);
            command.Parameters.AddWithValue("@passingInterceptions", txtPassingInterceptions.Text);
            command.Parameters.AddWithValue("@receivingYards", txtReceivingYards.Text);
            command.Parameters.AddWithValue("@receptions", txtReceptions.Text);
            command.Parameters.AddWithValue("@receivingTDs", txtReceivingTDs.Text);
            command.Parameters.AddWithValue("@rushingYards", txtRushingYards.Text);
            command.Parameters.AddWithValue("@rushingAttempts", txtRushingAttempts.Text);
            command.Parameters.AddWithValue("@rushingTDs", txtRushingTDs.Text);
            command.Parameters.AddWithValue("@fumbles", txtOffensiveFumbles.Text);
            command.Parameters.AddWithValue("@tackles", txtTackles.Text);
            command.Parameters.AddWithValue("@assistedTackles", txtAssistedTackles.Text);
            command.Parameters.AddWithValue("@sacks", txtSacks.Text);
            command.Parameters.AddWithValue("@interceptions", txtDefensiveInterceptions.Text);
            command.Parameters.AddWithValue("@safeties", txtSafeties.Text);
            command.Parameters.AddWithValue("@forcedFumbles", txtForcedFumbles.Text);
            command.Parameters.AddWithValue("@fieldGoalsAttempted", txtFieldGoalsAttempted.Text);
            command.Parameters.AddWithValue("@fieldGoalsMade", txtFieldGoalsMade.Text);
            command.Parameters.AddWithValue("@puntYards", txtPuntYards.Text);
            command.Parameters.AddWithValue("@kickYards", txtKickYards.Text);
            command.Parameters.AddWithValue("@touchbacks", txtTouchbacks.Text);
        }
    }
}
