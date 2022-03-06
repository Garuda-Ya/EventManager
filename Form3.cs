using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EventApp
{
    public partial class Form1 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=DESKTOP-H1UDJK6\SQLEXPRESS;Initial Catalog=EventManagement;Integrated Security=True";
        private string sql = "SELECT * FROM [EventManagement].[dbo].[Event]";
        public Form1()
        {
            InitializeComponent();
            metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            metroGrid1.AllowUserToAddRows = false;
            metroGrid1.Columns[0].Visible = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];

                connection.Close();
            }
        }
        
        void closeList()
        {
            musicbtn.Enabled = false;
            photographbtn.Enabled = false;
            leaderbtn.Enabled = false;
            musicbtn.Visible = false;
            photographbtn.Visible = false;
            leaderbtn.Visible = false;
            foodbtn.Enabled = false;
            dragbtn.Enabled = false;
            foodbtn.Visible = false;
            dragbtn.Visible = false;
            xuiCustomGroupbox3.Size = new Size(208, 41);
            xuiCustomGroupbox4.Size = new Size(208, 38);
            placebtn.Location = new Point(0, 84);
            xuiCustomGroupbox4.Location = new Point(0, 129);
        }

        private void personbtn_Click(object sender, EventArgs e)
        {

        }

        private void eventbtn_Click(object sender, EventArgs e)
        {

        }

        private void personbtn_MouseHover(object sender, EventArgs e)
        {
            musicbtn.Enabled = true;
            photographbtn.Enabled = true;   
            leaderbtn.Enabled = true;   
            musicbtn.Visible = true;
            photographbtn.Visible = true;
            leaderbtn.Visible = true;
        }

        private void musicbtn_Click(object sender, EventArgs e)
        {

        }

        private void photographbtn_Click(object sender, EventArgs e)
        {

        }

        private void musicbtn_MouseHover(object sender, EventArgs e)
        {
            musicbtn.Enabled = true;
            photographbtn.Enabled = true;
            leaderbtn.Enabled = true;
            musicbtn.Visible = true;
            photographbtn.Visible = true;
            leaderbtn.Visible = true;
        }

        private void photographbtn_MouseHover(object sender, EventArgs e)
        {
            musicbtn.Enabled = true;
            photographbtn.Enabled = true;
            leaderbtn.Enabled = true;
            musicbtn.Visible = true;
            photographbtn.Visible = true;
            leaderbtn.Visible = true;
        }

        private void leaderbtn_MouseHover(object sender, EventArgs e)
        {
            musicbtn.Enabled = true;
            photographbtn.Enabled = true;
            leaderbtn.Enabled = true;
            musicbtn.Visible = true;
            photographbtn.Visible = true;
            leaderbtn.Visible = true;
        }

        private void leaderbtn_MouseMove(object sender, MouseEventArgs e)
        {
            musicbtn.Enabled = true;
            photographbtn.Enabled = true;
            leaderbtn.Enabled = true;
            musicbtn.Visible = true;
            photographbtn.Visible = true;
            leaderbtn.Visible = true;
        }

        private void personbtn_MouseMove(object sender, MouseEventArgs e)
        {
            musicbtn.Enabled = true;
            photographbtn.Enabled = true;
            leaderbtn.Enabled = true;
            musicbtn.Visible = true;
            photographbtn.Visible = true;
            leaderbtn.Visible = true;
            xuiCustomGroupbox3.Size = new Size(208,171);
            placebtn.Location = new Point(0, 216);
            xuiCustomGroupbox4.Location = new Point(0, 255);
        }

        private void musicbtn_MouseMove(object sender, MouseEventArgs e)
        {
            musicbtn.Enabled = true;
            photographbtn.Enabled = true;
            leaderbtn.Enabled = true;
            musicbtn.Visible = true;
            photographbtn.Visible = true;
            leaderbtn.Visible = true;
        }

        private void photographbtn_MouseMove(object sender, MouseEventArgs e)
        {
            musicbtn.Enabled = true;
            photographbtn.Enabled = true;
            leaderbtn.Enabled = true;
            musicbtn.Visible = true;
            photographbtn.Visible = true;
            leaderbtn.Visible = true;
        }

        private void musicbtn_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void photographbtn_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void leaderbtn_MouseLeave(object sender, EventArgs e)
        {
            closeList();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            closeList();
        }

        private void xuiButton5_MouseMove(object sender, MouseEventArgs e)
        {
            foodbtn.Enabled = true;
            dragbtn.Enabled = true;
            foodbtn.Visible = true;
            dragbtn.Visible = true;
            xuiCustomGroupbox4.Size = new Size(208, 135);
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dragbtn_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void foodbtn_MouseLeave(object sender, EventArgs e)
        {
            closeList();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
