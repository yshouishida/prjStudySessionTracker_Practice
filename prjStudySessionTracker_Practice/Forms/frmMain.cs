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
using prjStudySessionTracker_Practice.Forms;

namespace prjStudySessionTracker_Practice
{
    public partial class frmMain : Form
    {
        private int UserId { get; set; }
        private string Username { get; set; }

        public frmMain(int userId, string username) 
        {
            UserId = userId;
            Username = username;

            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadStudySessions();

            lblDisplayUser.Text = $"User: {Username}";
        }

        private void LoadStudySessions()
        {
            string sql = $@"
                SELECT 
                    s.id,
	                s.subject_name 'Subject Name',
	                s.activity_type 'Activity Type',
	                s.study_date 'Date',
	                s.duration_hours 'Duration Hours',
                    s.task_completed 'Task Completed',
	                s.notes 'Notes'

                FROM tblStudySessions s
                INNER JOIN tblUsers   u
                ON s.user_id = u.id
                WHERE s.user_id = {UserId};
            ";


            DbHelpers.DgvLoader(sql, dgvStudySessions);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (frmStudySessionDE studySessionDE = new frmStudySessionDE(UserId))
            {
                studySessionDE.ShowDialog();

                if (studySessionDE.DialogResult == DialogResult.OK)
                {
                    LoadStudySessions();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudySessions.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            try
            {
                int studySessionId = Convert.ToInt32(dgvStudySessions.CurrentRow.Cells["id"].Value);


                using (frmStudySessionDE studySessionDE = new frmStudySessionDE(UserId, studySessionId))
                {
                    studySessionDE.ShowDialog();

                    if (studySessionDE.DialogResult == DialogResult.OK)
                    {
                        LoadStudySessions();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudySessions.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            if (MessageBox.Show(
                "Do you want to delete this record?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                ) == DialogResult.No) return;


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudySessions();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new frmStudySessionReport(UserId).ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;

            this.Close();

            new frmLogin().Show();
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (!DbConnection.GetConnection()) return;

            try
            {
               
                using (MySqlCommand cmd = DbConnection.Connection.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT 
                            s.id,
	                        s.subject_name 'Subject Name',
	                        s.activity_type 'Activity Type',
	                        s.study_date 'Date',
	                        s.duration_hours 'Duration Hours',
                                s.task_completed 'Task Completed',
	                        s.notes 'Notes'

                        FROM tblStudySessions s
                        INNER JOIN tblUsers   u
                        ON s.user_id = u.id
                        WHERE s.subject_name LIKE @subject_name
                    ";

                    cmd.Parameters.AddWithValue(@"subject_name", $"%{txtSearch.Text.Trim()}%");

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvStudySessions.DataSource = null;
                        dgvStudySessions.DataSource = dt;

                        dgvStudySessions.AutoGenerateColumns = false;
                        dgvStudySessions.Columns["id"].Visible = false;

                        dgvStudySessions.ClearSelection();
                        dgvStudySessions.CurrentCell = null;

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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSerach.PerformClick();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
