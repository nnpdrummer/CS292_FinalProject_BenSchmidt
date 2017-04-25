using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CS292_FinalProject_BenSchmidt
{
    public partial class frmRegister : Form
    {
        private const string DB_FOOTBALL = "Data Source = ../../highSchoolFootball.db; Version = 3";
        private SQLiteConnection connection = new SQLiteConnection(DB_FOOTBALL);
        private SQLiteDataAdapter dataAdapter;
        private SQLiteCommand cmd;
        private DataSet dataSet;
        private string sql;

        private string username;
        private string password;

        public frmRegister() { InitializeComponent(); }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            username = password = "";
            sql = "SELECT * FROM RegisterOfficial";
            connection.Open();
            dataSet = new DataSet();
            dataAdapter = new SQLiteDataAdapter(sql, connection);
            dataAdapter.Fill(dataSet);
            connection.Close();
            dgvRegister.DataSource = dataSet.Tables[0].DefaultView;
            dgvRegister.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!validateSelected())
            {
                lblStatus.Text = "Please select a row to add!";
                errorProviderRegister.SetError(btnAdd, "Invalid selection detected!");
                return;
            }
            sql = "INSERT INTO LeagueOfficials(Username, Password) Values (@Username, @Password)";

            connection.Open();
            cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.ExecuteNonQuery();
            connection.Close();

            lblStatus.Text = username + " is now a League Official!";
            remove();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!validateSelected())
            {
                lblStatus.Text = "Please select a row to remove!";
                errorProviderRegister.SetError(btnRemove, "Invalid selection detected!");
                return;
            }
            lblStatus.Text = username + " has been removed!";
            remove();
        }

        private void remove()
        {
            sql = "DELETE FROM RegisterOfficial WHERE Username = @Username";

            connection.Open();
            cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.ExecuteNonQuery();
            connection.Close();

            frmRegister_Load(null, null);
        }

        private bool validateSelected()
        {
            if (username.Equals("") || password.Equals("")) return false; 
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e) { Close(); }

        private void dgvRegister_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRegister.SelectedRows)
            {
                if(row.Cells[0].Value == null || row.Cells[0].Value.Equals(""))
                {
                    lblStatus.Text = "Please select a valid row!";
                    return;
                }
                username = row.Cells[0].Value.ToString();
                password = row.Cells[1].Value.ToString();
            }
        }
    }
}
