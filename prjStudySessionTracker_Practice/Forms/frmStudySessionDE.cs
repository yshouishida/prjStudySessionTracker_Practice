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
    public partial class frmStudySessionDE : Form
    {
        private int StudySessionId { get; set; }
        private int UserId { get; set; }
        private bool IsEdit { get; set; }


        public frmStudySessionDE(int userId)
        {
            UserId = userId;
            StudySessionId = 0;
            IsEdit = false;

            InitializeComponent();
        }

        public frmStudySessionDE(int userId, int studySessionId)
        {
            UserId = userId;
            StudySessionId = studySessionId;
            IsEdit = true;

            InitializeComponent();
        }

        private void frmStudySessionDE_Load(object sender, EventArgs e)
        {


            if (IsEdit) LoadStudentSessionById();

        }

        private void LoadStudentSessionById()
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
                        WHERE s.user_id = @user_id
                        AND   s.id      = @id;
                    ";

                    cmd.Parameters.AddWithValue("@user_id", UserId);
                    cmd.Parameters.AddWithValue("@id", StudySessionId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtSubjName.Text = reader["Subject Name"].ToString();
                            cbActType.SelectedItem = reader["Activity Type"];
                            dtpStudydate.Value = Convert.ToDateTime(reader["date"]);
                            txtDurHours.Text = reader["Duration Hours"].ToString();
                            txtTaskCompleted.Text = reader["Task Completed"].ToString();
                            txtNotes.Text = reader["Notes"].ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Unable to load study session. {UserId} | {StudySessionId}");
                            return;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTaskCompleted.Clear();
            txtSubjName.Clear();
            txtNotes.Clear();
            txtDurHours.Clear();

            cbActType.SelectedIndex = -1;

            dtpStudydate.Checked = false;
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(txtTaskCompleted.Text) ||
                string.IsNullOrWhiteSpace(txtSubjName.Text) ||
                string.IsNullOrWhiteSpace(txtDurHours.Text) ||
                cbActType.SelectedIndex == -1
                )
            {
                MessageBox.Show("Please fill all field first before sumitted.");
                return;
            }

            double durationHours;

            if (!double.TryParse(txtDurHours.Text.Trim(), out durationHours) || durationHours <= 0 || durationHours > 23)
            {
                MessageBox.Show("Invalid duration hours.");
                return;
            }
            

            if (!dtpStudydate.Checked)
            {
                MessageBox.Show("Student date field has not checked.");
                return;
            }



            if (!DbConnection.GetConnection()) return;

            try
            {
                using (MySqlCommand cmd = DbConnection.Connection.CreateCommand())
                {
                    cmd.CommandText = IsEdit ?
                        @"
                        UPDATE tblStudySessions
                        SET
                            subject_name   = @subject_name,
                            activity_type  = @activity_type,
                            study_date     = @study_date,
                            duration_hours = @duration_hours,
                            task_completed = @task_completed,
                            notes          = @notes 
                        WHERE    id        = @id
                        AND user_id        = @user_id
                        " :
                        @"
                        INSERT INTO tblStudySessions
                            (subject_name, activity_type, study_date, duration_hours, task_completed, notes, user_id)
                        VALUES
                            (@subject_name, @activity_type, @study_date, @duration_hours, @task_completed, @notes, @user_id)
                        ";

                    cmd.Parameters.AddWithValue("@subject_name", txtSubjName.Text.Trim());
                    cmd.Parameters.AddWithValue("@activity_type", cbActType.SelectedItem);
                    cmd.Parameters.AddWithValue("@study_date", dtpStudydate.Value);
                    cmd.Parameters.AddWithValue("@duration_hours", Convert.ToDouble(txtDurHours.Text));
                    cmd.Parameters.AddWithValue("@task_completed", Convert.ToDouble(txtTaskCompleted.Text));
                    cmd.Parameters.AddWithValue("@notes", txtNotes.Text.Trim());

                    cmd.Parameters.AddWithValue("@user_id", UserId);

                    if (IsEdit) cmd.Parameters.AddWithValue("@id", StudySessionId);

                    this.Close();
                    MessageBox.Show(cmd.ExecuteNonQuery() > 0 ? (IsEdit ? "Updated successfully" : "Added successfully") : (IsEdit ? "Unable to update." : "Unable to add."));
                    this.DialogResult = DialogResult.OK;
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
    }
}
