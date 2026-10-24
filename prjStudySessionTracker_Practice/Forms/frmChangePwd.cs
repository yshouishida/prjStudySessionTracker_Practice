using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjStudySessionTracker_Practice.Database;
using MySqlConnector;
using System.Windows.Forms;

namespace prjStudySessionTracker_Practice.Forms
{
    public partial class frmChangePwd : Form
    {
        private int UserId { get; set; }

        public frmChangePwd(int userId)
        {
            UserId = userId;

            InitializeComponent();
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(txtOldPwd.Text) ||
                string.IsNullOrWhiteSpace(txtNewPwd.Text) ||
                string.IsNullOrWhiteSpace(txtRPwd.Text)
                )
            {
                MessageBox.Show("Please fill all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!DbConnection.GetConnection()) return;

            try
            {
                using (MySqlCommand cmd = DbConnection.Connection.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT 1
                        FROM tblUsers
                        WHERE password = @password 
                        AND id = @id
                    ";
                    cmd.Parameters.AddWithValue("@id", UserId);
                    cmd.Parameters.AddWithValue("@password", txtOldPwd.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Invalid old password.");
                            return;
                        }
                    }
                }

                if (txtNewPwd.Text != txtRPwd.Text)
                {
                    MessageBox.Show("New password and Re-enter password are not equals.");
                    return;
                }

                using (MySqlCommand cmd = DbConnection.Connection.CreateCommand())
                {
                    cmd.CommandText = @"
                        UPDATE tblUsers
                        SET 
                            password = @password
                        WHERE id = @id
                    ";

                    cmd.Parameters.AddWithValue("@password", txtNewPwd.Text);
                    cmd.Parameters.AddWithValue("@id", UserId);

                    MessageBox.Show(cmd.ExecuteNonQuery() > 0 ? "Password updated successfully!": "Unable to change password. \n Please try again.");

                    this.Close();
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

        private void cbShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPwd.UseSystemPasswordChar = cbShowPwd.Checked ? false : true;
            txtNewPwd.UseSystemPasswordChar = cbShowPwd.Checked ? false : true;
            txtRPwd.UseSystemPasswordChar = cbShowPwd.Checked ? false : true;
        }
    }
}
