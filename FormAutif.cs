using System;
using MetroFramework.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace EventApp
{
    public partial class FormAutif : MetroForm
    {
        string role = "";
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Server=eventsqlconnect.eastus.cloudapp.azure.com;Database=EventManagement;Integrated Security=false;User ID=sa;Password=S8J-kJs-59D-ui7;";
        public FormAutif()
        {
            InitializeComponent();
            metroLabel1.Focus();
            metroTextBox1.Text = "Введите логин";//подсказка
            metroTextBox2.Text = "Введите пароль";//подсказка
        }

        private void FormAutif_Load(object sender, EventArgs e)
        {


        }

        private void MetroTextBox1_Enter(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "Введите логин")
            {
                metroTextBox1.Text = null;
            }
        }
        private void MetroTextBox2_Enter(object sender, EventArgs e)
        {
            if (metroTextBox2.Text == "Введите пароль")
            {
                metroTextBox2.Text = null;
            }
            metroTextBox2.UseSystemPasswordChar = true;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            bool success = false;
            try
            {
                const string comand = "SELECT * FROM Users WHERE login=@login AND password=@password";
                SqlCommand check = new SqlCommand(comand, connection);
                check.Parameters.AddWithValue("@login", metroTextBox1.Text);
                check.Parameters.AddWithValue("@password", metroTextBox2.Text);
                connection.Open();

                using (var dataReader = check.ExecuteReader())
                {
                    success = dataReader.Read();
                }
            }
            finally
            {
                connection.Close();
            }
            if (success)
            {
                //using (SqlConnection con = new SqlConnection(connectionString))
                //{
                //    string sql = $"SELECT role FROM Users WHERE login='{metroTextBox1.Text}' AND password='{metroTextBox2.Text}'";
                //    SqlCommand command = new SqlCommand(sql, connection);
                //    con.Open();
                //    role = (int)command.ExecuteScalar();
                //    con.Close();
                //}
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sql = $"SELECT role FROM Users WHERE login='{metroTextBox1.Text}' AND password='{metroTextBox2.Text}'";
                    SqlCommand command = con.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = sql;
                    command.Parameters.Clear();
                    con.Open();
                    var result = command.ExecuteScalar();
                    role = result.ToString();
                    con.Close();
                }
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    adapter = new SqlDataAdapter($"SELECT id FROM Users Where login='{metroTextBox1.Text}'", connect);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    connect.Close();
                };
                if (role.ToString() == "0")
                {
                    Form form = new EventApp.Form1(ds.Tables[0].Rows[0][0].ToString());
                    form.Show();
                    this.Hide();
                }
                if (role.ToString() == "1")
                {

                    Form form = new EventApp.Form1(ds.Tables[0].Rows[0][0].ToString());
                    form.Show();
                    this.Hide();
                }
                if (role.ToString() == "2")
                {
                    Form form = new EventApp.AccountantForm();
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                metroTextBox2.UseSystemPasswordChar = false;
            }
        }

        private void FormAutif_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }


}
