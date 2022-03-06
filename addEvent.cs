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

namespace EventApp
{
    public partial class addEvent : Form
    {
        Class1 classs = new Class1();
        string idUser;
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        int id;
        string connectionString = @"Server=eventsqlconnect.eastus.cloudapp.azure.com;Database=EventManagement;Integrated Security=false;User ID=sa;Password=S8J-kJs-59D-ui7;";
        public addEvent(string idUserr)
        {
            idUser = idUserr;
            InitializeComponent();
            setPeopleComBox();
            setDecorComboBox();
            setComboBox("CategoryT", "Name", comboBoxCategory);

            this.CenterToScreen();
        }

        private void setPeopleComBox()
        {
            setComboBox("MusicT", "FIO", "Music", dateTimeBox.Value.Date.ToString("yyyy-MM-dd"), comboBoxMusic);
            setComboBox("PhotoMan", "FIO", "PhotoMan", dateTimeBox.Value.Date.ToString("yyyy-MM-dd"), comboBoxPhoto);
            setComboBox("TamodaT", "FIO", "Tamoda", dateTimeBox.Value.Date.ToString("yyyy-MM-dd"), comboBoxTamoda);
            setComboBox("RestaurantFoodT", "Name", "RestaurantFood", dateTimeBox.Value.Date.ToString("yyyy-MM-dd"), comboBoxFood);
            setComboBox("PlaceT", "Name", "Place", dateTimeBox.Value.Date.ToString("yyyy-MM-dd"), comboBoxPlace);
        }

        private void setDecorComboBox()
        {
            setComboBox("RibbonsT", "Color", 1, comboBoxRibbons);
            setComboBox("BallsT", "Color", 1, comboBoxBalls);
            setComboBox("FlowersT", "Name", 1, comboBoxFlowers);
        }

        private void setComboBox(string nameTable, string name, string NameInEvent, string date, ComboBox cb)
        {
            string sql = $"IF(SELECT COUNT({ NameInEvent}) FROM Event WHERE DateEvent = '{date}') = 0 SELECT {name} FROM dbo.{nameTable} ELSE SELECT {name} FROM dbo.{nameTable} Where {nameTable}.id NOT IN(SELECT {NameInEvent} FROM Event WHERE DateEvent = '{date}' AND {NameInEvent} IS NOT NULL)";
            //IF(SELECT COUNT(Music) FROM Event WHERE DateEvent = '2022-03-06') > 0 SELECT FIO FROM MusicT Where MusicT.id<>(SELECT Music FROM Event WHERE DateEvent = '2022-03-06') ELSE SELECT FIO FROM MusicT
            //string sql = $"IF(SELECT COUNT({NameInEvent}) FROM Event WHERE DateEvent = '{date}') = 0 SELECT {name} FROM dbo.{nameTable} ELSE SELECT {name} FROM dbo.{nameTable} Where {nameTable}.id<>(SELECT {NameInEvent} FROM Event WHERE DateEvent = '{date}')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);

                cb.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        private void setComboBox(string nameTable, string name, ComboBox cb)
        {
            string sql = $"SELECT {name} FROM {nameTable}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);

                cb.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        private void setComboBox(string nameTable, string name, int n, ComboBox cb)
        {
            if (countPeopleBox.Text != "")
            {
                string sql = $"SELECT {name} FROM {nameTable} WHERE Count >= {int.Parse(countPeopleBox.Text)}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(sql, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);

                    cb.DataSource = ds.Tables[0];

                    connection.Close();
                }
            }
        }

        private string getId(string nameTable, string name, MetroFramework.Controls.MetroComboBox cd)
        {
            string ip;
            if (cd.Items.Count == 0)
            {
                return "null";
            }
            else
            {
                ip = cd.Text;
            }
            string id = "";

            string sql = $"SELECT id FROM {nameTable} WHERE {name} = '{ip}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);

                id = ds.Tables[0].Rows[0][0].ToString();

                connection.Close();
            }

            return id;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameEventBox.Text == "")
            {
                MessageBox.Show("Введите название мероприятия!");
            }
            else if (clientBox.Text == "")
            {
                MessageBox.Show("Введите имя клиента!");
            }
            else if (buddgetBox.Text == "")
            {
                MessageBox.Show("Введите бюджет!");
            }
            else if (countPeopleBox.Text == "")
            {
                MessageBox.Show("Введите кол-во человек!");
            }
            else if (maskedBoxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Length < 11)
            {
                MessageBox.Show("Введите полноценный номер");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Event (NameEvent,Client,DateEvent,Phone,Buddget,CountPeople,Place,Category,RestaurantFood,Music,Tamoda,PhotoMan,Flowers,Balls,Ribbons) VALUES ('" + nameEventBox.Text + "','" + clientBox.Text + "','" +  dateTimeBox.Value.Date.ToString("yyyy-MM-dd") + "','" + maskedBoxPhone.Text + "'," + buddgetBox.Text + "," + countPeopleBox.Text + "," + getId("PlaceT", "Name", comboBoxPlace) + "," + getId("CategoryT", "Name", comboBoxCategory) + "," + getId("RestaurantFoodT", "Name", comboBoxFood) + "," + getId("MusicT", "FIO", comboBoxMusic) + "," + getId("TamodaT", "FIO", comboBoxTamoda) + "," + getId("PhotoMan", "FIO", comboBoxPhoto) + "," + getId("FlowersT", "Name", comboBoxFlowers) + " ," + getId("BallsT", "Color", comboBoxBalls) + "," + getId("RibbonsT", "Color", comboBoxRibbons) + ")";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    classs.CreateLogs(idUser, "Добавление события:" + nameEventBox.Text + "");
                    connection.Close();
                }
                if(comboBoxBalls.Text!="")
                {
                    minusEl(comboBoxBalls.Text, "BallsT", "Color");
                }

                if (comboBoxFlowers.Text != "")
                {
                    minusEl(comboBoxFlowers.Text, "FlowersT", "Name");
                }
                if (comboBoxRibbons.Text != "")
                {
                    minusEl(comboBoxRibbons.Text, "RibbonsT", "Color");
                }
                this.Close();
            }
        }
        private void minusEl(string name,string nameTable,string FromName)
        {
            string sql = $"SELECT Count FROM {nameTable} WHERE {FromName} ='{name}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);

                connection.Close();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql1 = $"UPDATE {nameTable} SET Count={(int)ds.Tables[0].Rows[0][0] - int.Parse(countPeopleBox.Text)} WHERE {FromName} ='{name}'";
                SqlCommand command = new SqlCommand(sql1, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void DelDecor()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Event (NameEvent,Client,DateEvent,Phone,Buddget,CountPeople,Place,Category,RestaurantFood,Music,Tamoda,PhotoMan,Flowers,Balls,Ribbons) VALUES ('" + nameEventBox.Text + "','" + clientBox.Text + "','" + dateTimeBox.Value.Date.ToString("yyyy-MM-dd") + "','" + maskedBoxPhone.Text + "'," + buddgetBox.Text + "," + countPeopleBox.Text + "," + getId("PlaceT", "Name", comboBoxPlace) + "," + getId("CategoryT", "Name", comboBoxCategory) + "," + getId("RestaurantFoodT", "Name", comboBoxFood) + "," + getId("MusicT", "FIO", comboBoxMusic) + "," + getId("TamodaT", "FIO", comboBoxTamoda) + "," + getId("PhotoMan", "FIO", comboBoxPhoto) + "," + getId("FlowersT", "Name", comboBoxFlowers) + " ," + getId("BallsT", "Color", comboBoxBalls) + "," + getId("RibbonsT", "Color", comboBoxRibbons) + ")";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Event (NameEvent,Client,DateEvent,Phone,Buddget,CountPeople,Place,Category,RestaurantFood,Music,Tamoda,PhotoMan,Flowers,Balls,Ribbons) VALUES ('" + nameEventBox.Text + "','" + clientBox.Text + "','" + dateTimeBox.Value.Date.ToString("yyyy-MM-dd") + "','" + maskedBoxPhone.Text + "'," + buddgetBox.Text + "," + countPeopleBox.Text + "," + getId("PlaceT", "Name", comboBoxPlace) + "," + getId("CategoryT", "Name", comboBoxCategory) + "," + getId("RestaurantFoodT", "Name", comboBoxFood) + "," + getId("MusicT", "FIO", comboBoxMusic) + "," + getId("TamodaT", "FIO", comboBoxTamoda) + "," + getId("PhotoMan", "FIO", comboBoxPhoto) + "," + getId("FlowersT", "Name", comboBoxFlowers) + " ," + getId("BallsT", "Color", comboBoxBalls) + "," + getId("RibbonsT", "Color", comboBoxRibbons) + ")";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Event (NameEvent,Client,DateEvent,Phone,Buddget,CountPeople,Place,Category,RestaurantFood,Music,Tamoda,PhotoMan,Flowers,Balls,Ribbons) VALUES ('" + nameEventBox.Text + "','" + clientBox.Text + "','" + dateTimeBox.Value.Date.ToString("yyyy-MM-dd") + "','" + maskedBoxPhone.Text + "'," + buddgetBox.Text + "," + countPeopleBox.Text + "," + getId("PlaceT", "Name", comboBoxPlace) + "," + getId("CategoryT", "Name", comboBoxCategory) + "," + getId("RestaurantFoodT", "Name", comboBoxFood) + "," + getId("MusicT", "FIO", comboBoxMusic) + "," + getId("TamodaT", "FIO", comboBoxTamoda) + "," + getId("PhotoMan", "FIO", comboBoxPhoto) + "," + getId("FlowersT", "Name", comboBoxFlowers) + " ," + getId("BallsT", "Color", comboBoxBalls) + "," + getId("RibbonsT", "Color", comboBoxRibbons) + ")";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                connection.Close();
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
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void countPeopleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void buddgetBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeBox_ValueChanged(object sender, EventArgs e)
        {
            setPeopleComBox();
        }

        private void countPeopleBox_Leave(object sender, EventArgs e)
        {
            setDecorComboBox();
        }
    }
}
