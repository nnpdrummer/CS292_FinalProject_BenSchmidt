/*
 * Name: Ben Schmidt
 * Project: Final Project
 * Date:
 * Purpose:
 */

using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CS292_FinalProject_BenSchmidt
{
    public partial class frmLogin : Form
    {
        private const string DB_FOOTBALL = "Data Source = ../../highSchoolFootball.db; Version = 3";
        private SQLiteConnection connection = new SQLiteConnection(DB_FOOTBALL);
        private SQLiteCommand cmd;
        private string sql;

        public frmLogin() { InitializeComponent(); }

        /// <summary>
        /// Initializes the controls in the login form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLoginUsername.Focus();
            txtLoginUsername.Clear();
            txtLoginPassword.Clear();
            txtRegUsername.Clear();
            txtRegPassword.Clear();
            lblStatus.Text = "";
            errorProviderLogin.Clear();
        }

        /// <summary>
        /// Closes this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackToMain_Click(object sender, EventArgs e) { Close(); }


        /// <summary>
        /// Attempts to see if the user's username and password is in the LeagueOfficials
        /// table of the highSchoolFootball database. If it is, the Officials form is shown.
        /// If not, notifies the user that the username and password combination do not match
        /// any credentials in the LeagueOfficals table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            errorProviderLogin.Clear();
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;
            sql = "SELECT COUNT(*) FROM LeagueOfficials WHERE Username = @Username AND Password = @Password";
            connection.Open();

            cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            int linesCounted = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if (linesCounted == 1)
            {
                frmOfficials officials = new frmOfficials();
                officials.setUsername(username);
                frmLogin_Load(null, null);
                this.Hide();
                officials.ShowDialog();
                lblStatus.Text = "You have successfully logged out!";
                this.Show();
            }
            else if (linesCounted == 0)
            {
                lblStatus.Text = "Username and password combination does not belong to an existing League Official!";
                errorProviderLogin.SetError(btnLogin, "Invalid Login Credentials!");
            }
        }

        /// <summary>
        /// Adds the user's login information to the RegisterOfficial table if
        /// their username does not match a username that already exists in the
        /// LeagueOfficials and RegisterOffical tables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!validCredentials()) return;

            lblStatus.Text = "";
            errorProviderLogin.Clear();
            sql = "SELECT COUNT(*) FROM RegisterOfficial WHERE Username = @Username";
            int linesCounted = searchForMatch();

            if (linesCounted == 1)
            {
                lblStatus.Text = "Username: " + txtRegUsername.Text + " is already awaiting approval! Please enter another.";
                errorProviderLogin.SetError(txtRegUsername, "Please enter another username");
            }
            else if (linesCounted == 0)
            {
                sql = "SELECT COUNT(*) FROM LeagueOfficials WHERE Username = @Username";
                linesCounted = searchForMatch();

                if (linesCounted == 1)
                {
                    lblStatus.Text = "Username: " + txtRegUsername.Text + " is already taken! Please enter another.";
                    errorProviderLogin.SetError(txtRegUsername, "Please enter another username");
                }
                else if (linesCounted == 0) register();
            }
        }

        /// <summary>
        /// Ensures that the password and username fields for
        /// the register group box contain text.
        /// </summary>
        /// <returns>True if they contain text, False if not.</returns>
        private bool validCredentials()
        {
            if (txtRegUsername.Text.Length == 0 || txtRegPassword.Text.Length == 0)
            {
                lblStatus.Text = "Please ensure username and password fields contain text!";
                errorProviderLogin.SetError(btnRegister, "Invalid username and/or password detected!");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Searches through the desired table to ensure that the user's
        /// username is not contianed in said table.
        /// </summary>
        /// <returns>1 if there is a match, 0 if not.</returns>
        private int searchForMatch()
        {
            connection.Open();
            cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Username", txtRegUsername.Text);
            int linesCounted = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            return linesCounted;
        }

        /// <summary>
        /// Inserts the user's credentials into the Register Official table.
        /// </summary>
        private void register()
        {
            sql = "INSERT INTO RegisterOfficial(Username, Password) Values (@Username, @Password)";

            connection.Open();
            cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Username", txtRegUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtRegPassword.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

            lblStatus.Text = "Username: " + txtRegUsername.Text + " is awaiting approval!";
        }
    }
}
