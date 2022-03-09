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
    public partial class ChangedEvent : Form
    {
        Class1 classs = new Class1();
        string idUser;
        int CountChel;
        string idBalls,idMusic, idRestaurantFood, idPhoto,idRibbons,idFlowers,idTamoda,idPlace,idCategory;
        bool changeFlower,changeBalls,changeRibboms,changeDate=false;
        DateTime dateTime;
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        int id;
        string connectionString = @"Server=eventsqlconnect.eastus.cloudapp.azure.com;Database=EventManagement;Integrated Security=false;User ID=sa;Password=S8J-kJs-59D-ui7;";
        public ChangedEvent(DataRow row, string idUserr)
        {
            InitializeComponent();
            idUser = idUserr;
            id = System.Convert.ToInt32(row[0]);
            string sql = $"SELECT NameEvent, Client, DateEvent, dbo.Event.Phone, Buddget, CountPeople,dbo.PlaceT.Name AS Place,dbo.CategoryT.Name as Category, dbo.RestaurantFoodT.Name as RestaurantFood, dbo.MusicT.FIO as Music,dbo.TamodaT.FIO as Tamoda, dbo.PhotoMan.FIO as Photo,dbo.FlowersT.Name as Flowers,dbo.BallsT.Color as Balls,dbo.RibbonsT.Color as Ribbons FROM dbo.Event LEFT JOIN dbo.PlaceT ON dbo.Event.Place = dbo.PlaceT.id LEFT JOIN dbo.CategoryT ON dbo.Event.Category = dbo.CategoryT.id LEFT JOIN dbo.RestaurantFoodT ON dbo.Event.RestaurantFood = dbo.RestaurantFoodT.id LEFT JOIN dbo.MusicT ON dbo.Event.Music = dbo.MusicT.id LEFT JOIN dbo.TamodaT ON dbo.Event.Tamoda = dbo.TamodaT.id LEFT JOIN dbo.PhotoMan ON dbo.Event.PhotoMan = dbo.PhotoMan.id LEFT JOIN dbo.FlowersT ON dbo.Event.Flowers = dbo.FlowersT.id LEFT JOIN dbo.BallsT ON dbo.Event.Balls=dbo.BallsT.id LEFT JOIN dbo.RibbonsT ON dbo.Event.Ribbons = dbo.RibbonsT.id WHERE dbo.Event.id = { row[0]}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);

                connection.Close();
            }

            nameEventBox.Text = ds.Tables[0].Rows[0]["NameEvent"].ToString();
            clientBox.Text = ds.Tables[0].Rows[0]["Client"].ToString();
            maskedBoxPhone.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
            buddgetBox.Text = ds.Tables[0].Rows[0]["Buddget"].ToString();
            countPeopleBox.Text = ds.Tables[0].Rows[0]["CountPeople"].ToString();      
            idBalls = retNullOrZn(ds.Tables[0].Rows[0]["Balls"].ToString());
            idMusic = retNullOrZn(ds.Tables[0].Rows[0]["Music"].ToString());
            idRestaurantFood = retNullOrZn(ds.Tables[0].Rows[0]["RestaurantFood"].ToString());
            idPhoto = retNullOrZn(ds.Tables[0].Rows[0]["Photo"].ToString());
            idRibbons = retNullOrZn(ds.Tables[0].Rows[0]["Ribbons"].ToString());
            idFlowers = retNullOrZn(ds.Tables[0].Rows[0]["Flowers"].ToString());
            idTamoda = retNullOrZn(ds.Tables[0].Rows[0]["Tamoda"].ToString());
            idPlace = retNullOrZn(ds.Tables[0].Rows[0]["Place"].ToString());
            idCategory = retNullOrZn(ds.Tables[0].Rows[0]["Category"].ToString());
            dateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateEvent"].ToString());
            dateTimeBox.Value = dateTime;
            CountChel = int.Parse(countPeopleBox.Text);
            setPeopleComBox();
            setComboBox("RibbonsT", "Color", "", comboBoxRibbons);
            setComboBox("BallsT", "Color", "", comboBoxBalls);
            setComboBox("FlowersT", "Name", "", comboBoxFlowers);
            setComboBox("CategoryT", "Name", comboBoxCategory);

            comboBoxBalls.Text = idBalls;
            comboBoxMusic.Text = idMusic;
            comboBoxFood.Text = idRestaurantFood;
            comboBoxPhoto.Text = idPhoto;
            comboBoxRibbons.Text = idRibbons;
            comboBoxFlowers.Text = idFlowers;
            comboBoxTamoda.Text = idTamoda;
            comboBoxPlace.Text = idPlace;
            comboBoxCategory.Text = idCategory;

            this.CenterToScreen();
        }

        private string retNullOrZn(string ne)
        {
            return ne != "" ? ne : "null";
        }
        private void setPeopleComBox()
        {
            setComboBox("MusicT", "FIO", "Music", idMusic, dateTimeBox.Value.Date.ToString("yyyy-MM-dd"), comboBoxMusic);
            setComboBox("PhotoMan", "FIO", "PhotoMan", idPhoto, dateTimeBox.Value.Date.ToString("yyyy-MM-dd"), comboBoxPhoto);
            setComboBox("TamodaT", "FIO", "Tamoda", idTamoda.ToString(), dateTimeBox.Value.Date.ToString("yyyy-MM-dd"), comboBoxTamoda);
            setComboBox("RestaurantFoodT", "Name", "RestaurantFood", idRestaurantFood, dateTimeBox.Value.Date.ToString("yyyy-MM-dd"), comboBoxFood);                  
            setComboBox("PlaceT", "Name", "Place", idPlace,dateTimeBox.Value.Date.ToString("yyyy-MM-dd"), comboBoxPlace);
        }

        private void setDecorComboBox()
        {
            setComboBox("RibbonsT", "Color", idRibbons, comboBoxRibbons);
            setComboBox("BallsT", "Color", idBalls, comboBoxBalls);
            setComboBox("FlowersT", "Name", idFlowers, comboBoxFlowers);
        }

        private void setComboBox(string nameTable, string name, string NameInEvent,string tipoid, string date, ComboBox cb)
        {
            string sql;
            //IF(SELECT COUNT(Music) FROM Event WHERE DateEvent = '2022-03-06') > 0 SELECT FIO FROM MusicT Where MusicT.id<>(SELECT Music FROM Event WHERE DateEvent = '2022-03-06') ELSE SELECT FIO FROM MusicT
            if (dateTime == dateTimeBox.Value)
               sql = $"IF(SELECT COUNT({ NameInEvent}) FROM Event WHERE DateEvent = '{date}') = 0 SELECT {name} FROM dbo.{nameTable} ELSE SELECT {name} FROM dbo.{nameTable} Where {nameTable}.id NOT IN(SELECT {NameInEvent} FROM Event WHERE DateEvent = '{date}' AND {NameInEvent} IS NOT NULL AND {NameInEvent} <> {getId(nameTable,name,tipoid)})";
            else
                sql = $"IF(SELECT COUNT({ NameInEvent}) FROM Event WHERE DateEvent = '{date}') = 0 SELECT {name} FROM dbo.{nameTable} ELSE SELECT {name} FROM dbo.{nameTable} Where {nameTable}.id NOT IN(SELECT {NameInEvent} FROM Event WHERE DateEvent = '{date}' AND {NameInEvent} IS NOT NULL)";
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
        private void setComboBox(string nameTable, string name, string n, ComboBox cb)
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
            if (n != "" && n!="null")
            {                
                string sql2 = $"SELECT Count FROM {nameTable} WHERE {name} ='{n}'";

                int razn=CountChel;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(sql2, connection);
                    DataSet dt1 = new DataSet();
                    adapter.Fill(dt1);
                    if(int.Parse(dt1.Tables[0].Rows[0][0].ToString())+razn >=int.Parse(countPeopleBox.Text))
                    {
                        ds.Tables[0].Rows.Add(n);
                        cb.DataSource = ds.Tables[0];
                    }
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
        private string getId(string nameTable, string name, string cd)
        {
            string id="";
            string sql = $"SELECT id FROM {nameTable} WHERE {name} = '{cd}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count!=0)
                {
                    id = ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    id = "Null";
                }

                connection.Close();
            }
            return id;
        }

        private void chengedBtn_Click(object sender, EventArgs e)
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
                    string sql = "UPDATE Event SET NameEvent = '" + nameEventBox.Text + "',Client = '" + clientBox.Text + "'," +
                        "DateEvent = '" + dateTimeBox.Value.Date.ToString("yyyy-MM-dd") + "' ,Phone = '" + maskedBoxPhone.Text + "'," +
                        "Buddget = '" + buddgetBox.Text + "',CountPeople = '" + countPeopleBox.Text + "'," +
                        "" + "Place = " + getId("PlaceT", "Name", comboBoxPlace) + "," +
                        "Category = " + getId("CategoryT", "Name", comboBoxCategory) + ", RestaurantFood = " + getId("RestaurantFoodT", "Name", comboBoxFood) + "," +
                        " Music = " + getId("MusicT", "FIO", comboBoxMusic) + ",Tamoda = " + getId("TamodaT", "FIO", comboBoxTamoda) + "," +
                        "PhotoMan = " + getId("PhotoMan", "FIO", comboBoxPhoto) + " ,Flowers = " + getId("FlowersT", "Name", comboBoxFlowers) + " ," +
                        "Balls = " + getId("BallsT", "Color", comboBoxBalls) + ",Ribbons = " + getId("RibbonsT", "Color", comboBoxRibbons) + " " +
                        "WHERE id =  " + id.ToString() + "";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    classs.CreateLogs(idUser, "Изменение события:" + nameEventBox.Text + "");
                    connection.Close();
                }
                if (comboBoxBalls.Text != "")
                {
                    if(comboBoxBalls.Text == idBalls)
                    {
                        if(CountChel != int.Parse(countPeopleBox.Text))
                        {
                            minusEl(idBalls, "BallsT", "Color", int.Parse(countPeopleBox.Text)-CountChel);
                        }
                    }
                    else
                    {
                        if (idBalls!="null")
                            minusEl(idBalls, "BallsT", "Color",  -CountChel);
                        minusEl(comboBoxBalls.Text, "BallsT", "Color", int.Parse(countPeopleBox.Text));
                    }
                }
                else
                {
                    if (idBalls!="null")
                    {
                        minusEl(idBalls, "BallsT", "Color", -CountChel);
                    }
                }

                if (comboBoxFlowers.Text != "")
                {
                    if (comboBoxFlowers.Text == idFlowers)
                    {
                        if (CountChel != int.Parse(countPeopleBox.Text))
                        {
                            minusEl(idFlowers, "FlowersT", "Name", int.Parse(countPeopleBox.Text) - CountChel);
                        }
                    }
                    else
                    {
                        if (idFlowers!="null")
                            minusEl(idFlowers, "FlowersT", "Name", -CountChel);
                        minusEl(comboBoxFlowers.Text, "FlowersT", "Name", int.Parse(countPeopleBox.Text));
                    }
                }
                else
                {
                    if (idFlowers != "null")
                    {
                        minusEl(idFlowers, "FlowersT", "Name", -CountChel);
                    }
                }
                if (comboBoxRibbons.Text != "")
                {
                    if (comboBoxRibbons.Text == idRibbons)
                    {
                        if (CountChel != int.Parse(countPeopleBox.Text))
                        {
                            minusEl(idRibbons, "RibbonsT", "Color", int.Parse(countPeopleBox.Text) - CountChel);
                        }
                    }
                    else
                    {
                        if(idRibbons!="null")
                            minusEl(idRibbons, "RibbonsT", "Color", -CountChel);
                        minusEl(comboBoxRibbons.Text, "RibbonsT", "Color", int.Parse(countPeopleBox.Text));
                    }
                }
                else
                {
                    if (idRibbons != "null")
                    {
                        minusEl(idRibbons, "RibbonsT", "Color", -CountChel);
                    }
                }
                this.Close();
            }
        }
        private void minusEl(string name, string nameTable, string FromName,int razn)
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
                string sql1 = $"UPDATE {nameTable} SET Count={(int)ds.Tables[0].Rows[0][0] - razn} WHERE {FromName} ='{name}'";
                SqlCommand command = new SqlCommand(sql1, connection);
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
            Console.WriteLine("sdgf");
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buddgetBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void countPeopleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void dateTimeBox_ValueChanged(object sender, EventArgs e)
        {
            setPeopleComBox(); 
        }

        private void countPeopleBox_Leave(object sender, EventArgs e)
        {
            if (CountChel != int.Parse(countPeopleBox.Text))
            {
                setDecorComboBox();
            }   
            
        }

        private void AddDecor(string name,string nameTable)
        {
            //string sql1= $"UPDATE {nameTable} SET Count={int.Parse(countPeopleBox.Text)} "
        }
    }
}