using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using prjStudySessionTracker_Practice.Database;


namespace prjStudySessionTracker_Practice.Database
{
    class DbHelpers
    {
        public static void DgvLoader(string sql, DataGridView dgv)
        {
            if (!DbConnection.GetConnection()) return;

            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, DbConnection.Connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.DataSource = null;
                    dgv.DataSource = dt;

                    dgv.AutoGenerateColumns = false;
                    dgv.Columns["id"].Visible = false;

                    dgv.ClearSelection();
                    dgv.CurrentCell = null;
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
