using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class viewEvent : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        int id;
        string connectionString = @"Server=eventsqlconnect.eastus.cloudapp.azure.com;Database=EventManagement;Integrated Security=false;User ID=sa;Password=S8J-kJs-59D-ui7;";
        public viewEvent(DataRow row, bool select)
        {
            InitializeComponent();
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
            dateTimeBox.Text = ds.Tables[0].Rows[0]["DateEvent"].ToString().Substring(0, ds.Tables[0].Rows[0]["DateEvent"].ToString().Length - 3);
            maskedBoxPhone.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
            buddgetBox.Text = ds.Tables[0].Rows[0]["Buddget"].ToString();
            countPeopleBox.Text = ds.Tables[0].Rows[0]["CountPeople"].ToString();
            placeBox.Text = ds.Tables[0].Rows[0]["Place"].ToString();
            categoryBox.Text = ds.Tables[0].Rows[0]["Category"].ToString();
            restaurantFoodBox.Text = ds.Tables[0].Rows[0]["RestaurantFood"].ToString();
            musicBox.Text = ds.Tables[0].Rows[0]["Music"].ToString();
            tamodaBox.Text = ds.Tables[0].Rows[0]["Tamoda"].ToString();
            photoManBox.Text = ds.Tables[0].Rows[0]["Photo"].ToString();
            flowersBox.Text = ds.Tables[0].Rows[0]["Flowers"].ToString();
            ballsBox.Text = ds.Tables[0].Rows[0]["Balls"].ToString();
            ribbonsBox.Text = ds.Tables[0].Rows[0]["Ribbons"].ToString();
            btnPrint.Enabled = select;
            btnPrint.Visible = select;
            fileNameBox.Enabled = select;
            fileNameBox.Visible = select;
            PrintFile.Visible= select;
            this.CenterToScreen();
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string name = fileNameBox.Text;
            if (name == "")
            {
                MessageBox.Show("Введите имя файла!");
            }
            else
            {
                if (File.Exists(name))
                {
                    MessageBox.Show("Данное имя занято.\n Введите другое имя!");
                }
                else
                {
                    var helper = new WordHelper("reportEvent.docx");
                    double pricePlace, priceT, priceP, priceM, priceFl, priceB, priceR, priceFo, cost, profit;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql = "";
                        SqlCommand command = null;
                        if (placeBox.Text == "")
                        {
                            pricePlace = 0;
                        }
                        else
                        {
                            sql = $"SELECT Price FROM PlaceT WHERE Name = '{placeBox.Text}'";
                            command = new SqlCommand(sql, connection);
                            pricePlace = (double)command.ExecuteScalar();
                            command.ExecuteNonQuery();
                        }
                        if (tamodaBox.Text == "")
                        {
                            priceT = 0;
                        }
                        else
                        {
                            sql = $"SELECT Price FROM TamodaT WHERE FIO = '{tamodaBox.Text}'";
                            command = new SqlCommand(sql, connection);
                            priceT = (double)command.ExecuteScalar();
                            command.ExecuteNonQuery();
                        }
                        if (photoManBox.Text == "")
                        {
                            priceP = 0;
                        }
                        else
                        {
                            sql = $"SELECT Price FROM PhotoMan WHERE FIO = '{photoManBox.Text}'";
                            command = new SqlCommand(sql, connection);
                            priceP = (double)command.ExecuteScalar();
                            command.ExecuteNonQuery();
                        }
                        if (musicBox.Text == "")
                        {
                            priceM = 0;
                        }
                        else
                        {
                            sql = $"SELECT Price FROM MusicT WHERE FIO = '{musicBox.Text}'";
                            command = new SqlCommand(sql, connection);
                            priceM = (double)command.ExecuteScalar();
                            command.ExecuteNonQuery();
                        }
                        if (flowersBox.Text == "")
                        {
                            priceFl = 0;
                        }
                        else
                        {
                            sql = $"SELECT Price FROM FlowersT WHERE Name = '{flowersBox.Text}'";
                            command = new SqlCommand(sql, connection);
                            priceFl = (double)command.ExecuteScalar();
                            command.ExecuteNonQuery();
                        }
                        if (ballsBox.Text == "")
                        {
                            priceB = 0;
                        }
                        else
                        {
                            sql = $"SELECT Price FROM BallsT WHERE Color = '{ballsBox.Text}'";
                            command = new SqlCommand(sql, connection);
                            priceB = (double)command.ExecuteScalar();
                            command.ExecuteNonQuery();
                        }
                        if (ribbonsBox.Text == "")
                        {
                            priceR = 0;
                        }
                        else
                        {
                            sql = $"SELECT Price FROM RibbonsT WHERE Color = '{ribbonsBox.Text}'";
                            command = new SqlCommand(sql, connection);
                            priceR = (double)command.ExecuteScalar();
                            command.ExecuteNonQuery();
                        }
                        if (restaurantFoodBox.Text == "")
                        {
                            priceFo = 0;
                        }
                        else
                        {
                            sql = $"SELECT PriceOnePeople FROM RestaurantFoodT WHERE Name = '{restaurantFoodBox.Text}'";
                            command = new SqlCommand(sql, connection);
                            priceFo = (double)command.ExecuteScalar();
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                    cost = System.Convert.ToDouble(buddgetBox.Text) - System.Convert.ToDouble(pricePlace.ToString()) -
                        System.Convert.ToDouble(priceT.ToString()) - System.Convert.ToDouble(priceP.ToString()) -
                        System.Convert.ToDouble(priceM.ToString()) - System.Convert.ToDouble((priceFl * System.Convert.ToInt32(countPeopleBox.Text)).ToString()) -
                        System.Convert.ToDouble((priceR * System.Convert.ToInt32(countPeopleBox.Text)).ToString()) - System.Convert.ToDouble((priceB * System.Convert.ToInt32(countPeopleBox.Text)).ToString()) -
                        System.Convert.ToDouble((priceFo * System.Convert.ToInt32(countPeopleBox.Text)).ToString());
                    if (cost < 0) cost *= -1;
                    profit = System.Convert.ToDouble(buddgetBox.Text) - cost;
                    var tag = new Dictionary<string, string>
            {
                { "NameEvent", nameEventBox.Text},
                { "Client", clientBox.Text},
                { "Phone", maskedBoxPhone.Text},
                { "Place", placeBox.Text},
                { "PricePl",  pricePlace.ToString()},
                { "DateP", dateTimeBox.Text},
                { "CountPeople", countPeopleBox.Text},
                { "Buddget", buddgetBox.Text},
                { "Tamoda", tamodaBox.Text},
                { "PriceT", priceT.ToString()},
                { "PhotoMan", photoManBox.Text},
                { "PriceP", priceP.ToString()},
                { "Music", musicBox.Text},
                { "PriceM", priceM.ToString()},
                { "Flowers", flowersBox.Text},
                { "PriceFl", (priceFl * System.Convert.ToInt32(countPeopleBox.Text)).ToString()},
                { "Ribbons", ribbonsBox.Text},
                { "PriceR", (priceR * System.Convert.ToInt32(countPeopleBox.Text)).ToString()},
                { "Balls", ballsBox.Text},
                { "PriceB", (priceB * System.Convert.ToInt32(countPeopleBox.Text)).ToString()},
                { "Food", restaurantFoodBox.Text},
                { "PriceFo", (priceFo * System.Convert.ToInt32(countPeopleBox.Text)).ToString()},
                { "Cost", (cost).ToString()},
                { "Profit", (profit).ToString()},
                { "DateNow", DateTime.Now.ToString("dd/MM/yyyy HH:mm")}
                };

                    helper.Process(tag, name);
                    this.Close();
                }
            }
        }
    }
}
