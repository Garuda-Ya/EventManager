using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace EventApp
{
    internal class Class1
    {
        string NameEvent, NameUser;

        public void CreateLogs(string id, string Name)
        {
            DataSet ds;
            SqlDataAdapter adapter;
            SqlCommandBuilder commandBuilder;
            string connectionString = @"Server=eventsqlconnect.eastus.cloudapp.azure.com;Database=EventManagement;Integrated Security=false;User ID=sa;Password=S8J-kJs-59D-ui7;";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                adapter = new SqlDataAdapter($"SELECT Name FROM Users Where id='{id}'", connect);
                ds = new DataSet();
                adapter.Fill(ds);
                connect.Close();
            };
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO LogsT (LogName,LogDate) VALUES ('Пользователь" + ds.Tables[0].Rows[0][0] + "" + Name + "','" + DateTime.Now.ToString() + "')";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}