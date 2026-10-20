using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using prjStudySessionTracker_Practice.Database;

namespace prjStudySessionTracker_Practice.Forms
{
    public partial class frmStudySessionReport : Form
    {
        private int UserId { get; set; }

        public frmStudySessionReport(int userId)
        {
            UserId = userId;

            InitializeComponent();
        }

        private DataTable GetStudySessionDT()
        {
            if (!DbConnection.GetConnection()) return null;

            try
            {
                
                using (MySqlCommand cmd = DbConnection.Connection.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT 
                            s.id,
	                        s.subject_name 'Subject_Name',
	                        s.activity_type 'Activity_Type',
	                        s.study_date 'Date',
	                        s.duration_hours 'Duration_Hours',
                                s.task_completed 'Task_Completed',
	                        s.notes 'Notes'

                        FROM tblStudySessions s
                        INNER JOIN tblUsers   u
                        ON s.user_id = u.id
                        WHERE s.user_id = @user_id
                    ";
                    cmd.Parameters.AddWithValue(@"user_id", UserId);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                DbConnection.ConnClose();
            }
        }

        private void LoadReport()
        {
            DataTable dt = GetStudySessionDT();
            if (dt == null) return;

            rvStudySessions.LocalReport.DataSources.Clear();
            rvStudySessions.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("StudySessionDataSet", dt));

            rvStudySessions.LocalReport.ReportEmbeddedResource = "prjStudySessionTracker_Practice.Reports.StudySessionReport.rdlc";


            rvStudySessions.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvStudySessions.RefreshReport();

            rvStudySessions.LocalReport.DisplayName = $"Study_Session_Report_{DateTime.Now:MMM dd, yyyy}";
        }

        private void frmStudySessionReport_Load(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}
