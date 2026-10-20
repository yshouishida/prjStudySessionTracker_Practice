using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace prjStudySessionTracker_Practice.Database
{
    class DbConnection
    {
        public static MySqlConnection Connection;

        public static bool GetConnection()
        {
            try
            {
                Connection = new MySqlConnection("Server=localhost;Database=study_tracker_db;Uid=root;Password=P@ssw0rd123;SslMode=None");
                Connection.Open();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void ConnClose()
        {
            Connection?.Close();
        }

    }
}
