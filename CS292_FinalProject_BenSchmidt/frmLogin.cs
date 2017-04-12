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

namespace CS292_FinalProject_BenSchmidt
{
    public partial class frmLogin : Form
    {
        private const string DB_FOOTBALL = "Data Source = ../../highSchoolFootball.db; Version = 3";
        private SQLiteConnection connection = new SQLiteConnection(DB_FOOTBALL);
        private string sql;

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
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;
            sql = "SELECT COUNT(*) FROM LeagueOfficials WHERE Username = @Username AND Password = @Password";
            connection.Open();

            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Username", txtLoginUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtLoginPassword.Text);
            int linesCounted = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if (linesCounted == 1)
            {
                frmOfficials officials = new frmOfficials();
                this.Hide();
                officials.ShowDialog();
                this.Show();
            }
            else if (linesCounted == 0)
                lblStatus.Text = "Username and password combination does not match an existing League Official!";
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
