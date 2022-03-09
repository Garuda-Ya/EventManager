using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EventApp
{

    public partial class changeFood : Form
    {
        Class1 classs = new Class1();
        string idUser;
        Condition condition;
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        int id;
        string connectionString = @"Server=eventsqlconnect.eastus.cloudapp.azure.com;Database=EventManagement;Integrated Security=false;User ID=sa;Password=S8J-kJs-59D-ui7;";
        string FileName = null;
        string sql;
        private void Changefield()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sql = $"UPDATE RestaurantFoodT SET Name = '" + nameTextBox.Text + "', PriceOnePeople = '" + textBoxPrice.Text + "' WHERE id = '" + id.ToString() + "'";

                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                classs.CreateLogs(idUser, "Изменение еды:" + nameTextBox.Text + "");
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public changeFood(DataRow row, string idUserr)
        {
            id = System.Convert.ToInt32(row[0]);
            idUser = idUserr;
            InitializeComponent();
            this.CenterToScreen();
            sql = $"SELECT Name, PriceOnePeople FROM [EventManagement].[dbo].[RestaurantFoodT] WHERE id = {row[0]}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);

                connection.Close();
            }
            textBoxPrice.Text = ds.Tables[0].Rows[0]["PriceOnePeople"].ToString();
            nameTextBox.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            this.CenterToScreen();

        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Введите название!");
            }
            else if (textBoxPrice.Text == "")
            {
                MessageBox.Show("Введите цену!");
            }
            else
            {
                Changefield();
                this.Close();
            }
        }

            private void xuiButton3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void addPersonal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eventManagementDataSet.CategoryT". При необходимости она может быть перемещена или удалена.
            this.categoryTTableAdapter.Fill(this.eventManagementDataSet.CategoryT);

        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
