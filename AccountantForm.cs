using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace EventApp
{
    public partial class AccountantForm : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Server=eventsqlconnect.eastus.cloudapp.azure.com;Database=EventManagement;Integrated Security=false;User ID=sa;Password=S8J-kJs-59D-ui7;";
        private string sql = "SELECT * FROM [EventManagement].[dbo].[Event]";
        public AccountantForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            metroGridMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            metroGridMain.AllowUserToAddRows = false;
            metroGridMain.Columns[0].Visible = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                metroGridMain.DataSource = ds.Tables[0];

                connection.Close();
            }
            
        }

        public void updateGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(ds);

                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                ds.Clear();
                adapter.Fill(ds);

                connection.Close();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("sdgf");
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }


        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) 
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }
            this.WindowState = FormWindowState.Maximized;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {

        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnTamoda_Click(object sender, EventArgs e)
        {

        }

        private void metroGridMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = null;
            foreach (DataGridViewRow rows in metroGridMain.SelectedRows)
            {
                foreach (DataRow rows1 in ds.Tables[0].Rows)
                {
                    if(rows.Cells[0].Value.ToString() == rows1[0].ToString())
                    {
                        row = rows1;
                    }
                }
                Form form1 = new viewEvent(row, false);
                form1.ShowDialog();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(sql, connection);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds);

                    adapter = new SqlDataAdapter(sql, connection);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    ds.Clear();
                    adapter.Fill(ds);

                    connection.Close();
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM [EventManagement].[dbo].[Event]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                metroGridMain.DataSource = ds.Tables[0];

                connection.Close();
            }

            ds.Tables[0].DefaultView.RowFilter = $"(NameEvent LIKE '{searchBox.Text}*') or (Client LIKE '{searchBox.Text}*')";
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            DataRow row = null;
            foreach (DataGridViewRow rows in metroGridMain.SelectedRows)
            {
                foreach (DataRow rows1 in ds.Tables[0].Rows)
                {
                    if (rows.Cells[0].Value.ToString() == rows1[0].ToString())
                    {
                        row = rows1;
                    }
                }
                Form form1 = new viewEvent(row, true);
                form1.ShowDialog();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(sql, connection);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds);

                    adapter = new SqlDataAdapter(sql, connection);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    ds.Clear();
                    adapter.Fill(ds);

                    connection.Close();
                }
            }
        }

        private void searchDate_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;

            DateTimePicker dtp = dateTimePicker1;

            ds.Tables[0].DefaultView.RowFilter = $"DateEvent = #{dtp.Value.Date.ToString("yyyy-MM-dd")}#";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM [EventManagement].[dbo].[Event]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                metroGridMain.DataSource = ds.Tables[0];

                connection.Close();
            }

            ds.Tables[0].DefaultView.RowFilter = $"(NameEvent LIKE '{searchBox.Text}*') or (Client LIKE '{searchBox.Text}*')";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ds.Tables[0].DefaultView.RowFilter = $"DateEvent = #{dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")}#";
        }

        private void SearchD_Click(object sender, EventArgs e)
        {
            ds.Tables[0].DefaultView.RowFilter = $"DateEvent < #{DateTime.Today.ToString("yyyy-MM-dd")}#";
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            ds.Tables[0].DefaultView.RowFilter = $"DateEvent >= #{DateTime.Today.ToString("yyyy-MM-dd")}#";
        }
    }
}
