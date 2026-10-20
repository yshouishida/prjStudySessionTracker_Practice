using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using prjStudySessionTracker_Practice.Database;

namespace prjStudySessionTracker_Practice.Forms
{
    public partial class frmLogin : Form
    {

        private int UserId { get; set; }
        private string Username { get; set; }


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!DbConnection.GetConnection()) return;

            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPwd.Text)
                )
            {
                MessageBox.Show("Username and password are required.");
                return;
            }

            try
            {
                using (MySqlCommand cmd = DbConnection.Connection.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT
                            id,
                            CONCAT('last_name', ', ', 'first_name') full_name,
                            username
                        FROM tblUsers
                        WHERE username = @username
                        AND   password = @password
                    ";

                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPwd.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Invalid username or password.");
                            return;
                        }

                        UserId = Convert.ToInt32(reader["id"]);
                        Username = reader["username"].ToString();

                        this.Hide();

                        using (frmMain main = new frmMain(UserId, Username))
                        {
                            main.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DbConnection.ConnClose();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
