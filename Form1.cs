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
    public enum Condition
    {
        eventik,
        music,
        tamoda,
        photoman,
        place,
        balls,
        restourant,
        flowers,
        ribbons
    }
    public partial class Form1 : Form
    {
        Class1 classs = new Class1();
        string idUser;
        Condition con=Condition.eventik;
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Server=eventsqlconnect.eastus.cloudapp.azure.com;Database=EventManagement;Integrated Security=false;User ID=sa;Password=S8J-kJs-59D-ui7;";
        private string sql;
        private string sql1 = "SELECT [id],[NameEvent],[Client],[DateEvent],[Phone],[Buddget],[CountPeople] FROM [EventManagement].[dbo].[Event]";
        private string sql2 = "SELECT * FROM [EventManagement].[dbo].[MusicT]";
        private string sql3 = "SELECT dbo.TamodaT.id , dbo.TamodaT.FIO, dbo.TamodaT.Phone, dbo.TamodaT.Price, Photo,Description,dbo.CategoryT.Name AS Category FROM dbo.TamodaT LEFT JOIN dbo.CategoryT ON dbo.TamodaT.Category = dbo.CategoryT.id";
        private string sql4 = "SELECT *  FROM [EventManagement].[dbo].[PhotoMan]";
        private string sql5 = "SELECT *  FROM [EventManagement].[dbo].[PlaceT]";
        private string sql6 = "SELECT * FROM [EventManagement].[dbo].[RestaurantFoodT]";
        private string sql7 = "SELECT * FROM [EventManagement].[dbo].[FlowersT]";
        private string sql8 = "SELECT * FROM [EventManagement].[dbo].[BallsT]";
        private string sql9 = "SELECT * FROM [EventManagement].[dbo].[RibbonsT]";
        public Form1(string idUserr)
        {
            InitializeComponent();

            idUser = idUserr;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            sql = sql1;
            this.CenterToScreen();
            comboBoxChooseResourceTurn(false);
            DSload(Condition.eventik);
        }
        private void comboBoxChooseResourceTurn(bool turn)
        {
            comboBoxChooseResource.Enabled = turn;
            comboBoxChooseResource.Visible = turn;
        }

        private void DSload(Condition t)
        {
            metroGridMain.Columns.Clear();
            metroGridMain.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            metroGridMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            xuiButton1.Visible = false; 
            SearchD.Visible = false; 
            dateTimePicker1.Visible=false;
            con = t;
            switch (t)
            {
                //Event
                case Condition.eventik:
                    sql = sql1;
                    xuiButton1.Visible = true;
                    SearchD.Visible = true;
                    dateTimePicker1.Visible = true;
                    comboBoxChooseResourceTurn(false);

                    for (int i = 0; i < 7; i++)
                    {
                        metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    }
                    metroGridMain.Columns[1].HeaderText = "Название мероприятия";
                    metroGridMain.Columns[2].HeaderText = "Ф.И.О. клиента";
                    metroGridMain.Columns[3].HeaderText = "Дата";
                    metroGridMain.Columns[4].HeaderText = "Телефон";
                    metroGridMain.Columns[5].HeaderText = "Стоимость";
                    metroGridMain.Columns[6].HeaderText = "Количество людей";
                    metroGridMain.Columns[0].DataPropertyName = "id";
                    metroGridMain.Columns[1].DataPropertyName = "NameEvent";
                    metroGridMain.Columns[2].DataPropertyName = "Client";
                    metroGridMain.Columns[3].DataPropertyName = "DateEvent";
                    metroGridMain.Columns[4].DataPropertyName = "Phone";
                    metroGridMain.Columns[5].DataPropertyName = "Buddget";
                    metroGridMain.Columns[6].DataPropertyName = "CountPeople";
                    break;
                case Condition.music:
                    sql = sql2;
                    comboBoxChooseResourceTurn(false);

                    metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    metroGridMain.Columns.Add(imageColumn);
                    for (int i = 0; i < 4; i++)
                    {
                        metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    }
                    metroGridMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    metroGridMain.RowTemplate.Height = 130;
                    metroGridMain.Columns[1].Width = 130;
                    metroGridMain.Columns[1].HeaderText = "Фото";
                    metroGridMain.Columns[2].HeaderText = "Ф.И.О.";
                    metroGridMain.Columns[3].HeaderText = "Телефон";
                    metroGridMain.Columns[4].HeaderText = "Цена";
                    metroGridMain.Columns[5].HeaderText = "Описание";
                    metroGridMain.Columns[0].DataPropertyName = "id";
                    metroGridMain.Columns[1].DataPropertyName = "Photo";
                    metroGridMain.Columns[2].DataPropertyName = "FIO";
                    metroGridMain.Columns[3].DataPropertyName = "Phone";
                    metroGridMain.Columns[4].DataPropertyName = "Price";
                    metroGridMain.Columns[5].DataPropertyName = "Description";
                    break;
                case Condition.tamoda:
                    sql = sql3;
                    comboBoxChooseResourceTurn(false);
                    metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    DataGridViewImageColumn imageColumn1 = new DataGridViewImageColumn();
                    imageColumn1.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    metroGridMain.Columns.Add(imageColumn1);
                    for (int i = 0; i < 5; i++)
                    {
                        metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    }
                    metroGridMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    metroGridMain.RowTemplate.Height = 130;
                    metroGridMain.Columns[1].Width = 130;
                    metroGridMain.Columns[1].HeaderText = "Фото";
                    metroGridMain.Columns[2].HeaderText = "Ф.И.О.";
                    metroGridMain.Columns[3].HeaderText = "Телефон";
                    metroGridMain.Columns[4].HeaderText = "Цена";
                    metroGridMain.Columns[5].HeaderText = "Категория";
                    metroGridMain.Columns[6].HeaderText = "Описание";
                    metroGridMain.Columns[0].DataPropertyName = "id";
                    metroGridMain.Columns[1].DataPropertyName = "Photo";
                    metroGridMain.Columns[2].DataPropertyName = "FIO";
                    metroGridMain.Columns[3].DataPropertyName = "Phone";
                    metroGridMain.Columns[4].DataPropertyName = "Price";
                    metroGridMain.Columns[5].DataPropertyName = "Category";
                    metroGridMain.Columns[6].DataPropertyName = "Description";
                    break;
                //PhotomanT
                case Condition.photoman:
                    sql = sql4;
                    comboBoxChooseResourceTurn(false);
                    metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    DataGridViewImageColumn imageColumn2 = new DataGridViewImageColumn();
                    imageColumn2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    metroGridMain.Columns.Add(imageColumn2);
                    for (int i = 0; i < 4; i++)
                    {
                        metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    }
                    metroGridMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    metroGridMain.RowTemplate.Height = 130;
                    metroGridMain.Columns[1].Width = 130;
                    metroGridMain.Columns[1].HeaderText = "Фото";
                    metroGridMain.Columns[2].HeaderText = "Ф.И.О.";
                    metroGridMain.Columns[3].HeaderText = "Телефон";
                    metroGridMain.Columns[4].HeaderText = "Цена";
                    metroGridMain.Columns[5].HeaderText = "Описание";
                    metroGridMain.Columns[0].DataPropertyName = "id";
                    metroGridMain.Columns[1].DataPropertyName = "Photo";
                    metroGridMain.Columns[2].DataPropertyName = "FIO";
                    metroGridMain.Columns[3].DataPropertyName = "Phone";
                    metroGridMain.Columns[4].DataPropertyName = "Price";
                    metroGridMain.Columns[5].DataPropertyName = "Description";
                    metroGridMain.Columns[5].Width = 100;
                    break;
                //PlaceT
                case Condition.place:
                    sql = sql5;
                    comboBoxChooseResourceTurn(false);
                    for (int i = 0; i < 4; i++)
                    {
                        metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    }
                    metroGridMain.Columns[1].HeaderText = "Название";
                    metroGridMain.Columns[2].HeaderText = "Максимальное кол-во людей";
                    metroGridMain.Columns[3].HeaderText = "Цена";
                    metroGridMain.Columns[0].DataPropertyName = "id";
                    metroGridMain.Columns[1].DataPropertyName = "Name";
                    metroGridMain.Columns[2].DataPropertyName = "MaxCountPeople";
                    metroGridMain.Columns[3].DataPropertyName = "Price";
                    break;
                case Condition.restourant:
                    sql = sql6;
                    comboBoxChooseResourceTurn(false);
                    for (int i = 0; i < 3; i++)
                    {
                        metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    }
                    metroGridMain.Columns[1].HeaderText = "Название";
                    metroGridMain.Columns[2].HeaderText = "Цена за 1 порцию";
                    metroGridMain.Columns[0].DataPropertyName = "id";
                    metroGridMain.Columns[1].DataPropertyName = "Name";
                    metroGridMain.Columns[2].DataPropertyName = "PriceOnePeople";
                    break;
                //Resourses
                //FlowersT
                case Condition.flowers:
                    //comboBoxChooseResource.SelectedIndex = 0;
                    sql = sql7;
                    comboBoxChooseResourceTurn(true);
                    for (int i = 0; i < 4; i++)
                    {
                        metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    }
                    metroGridMain.Columns[1].HeaderText = "Название";
                    metroGridMain.Columns[2].HeaderText = "Количество";
                    metroGridMain.Columns[3].HeaderText = "Цена за 1 шт";
                    metroGridMain.Columns[0].DataPropertyName = "id";
                    metroGridMain.Columns[1].DataPropertyName = "Name";
                    metroGridMain.Columns[2].DataPropertyName = "Count";
                    metroGridMain.Columns[3].DataPropertyName = "Price";
                    comboBoxChooseResource.SelectedIndex = 0;
                    break;
                //BallsT
                case Condition.balls:
                    sql = sql8;
                    comboBoxChooseResourceTurn(true);
                    for (int i = 0; i < 4; i++)
                    {
                        metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    }
                    metroGridMain.Columns[1].HeaderText = "Цвет";
                    metroGridMain.Columns[2].HeaderText = "Количество";
                    metroGridMain.Columns[3].HeaderText = "Цена за 1 шт";
                    metroGridMain.Columns[0].DataPropertyName = "id";
                    metroGridMain.Columns[1].DataPropertyName = "Color";
                    metroGridMain.Columns[2].DataPropertyName = "Count";
                    metroGridMain.Columns[3].DataPropertyName = "Price";
                    break;
                //Ribbons
                case Condition.ribbons:
                    sql = sql9;
                    comboBoxChooseResourceTurn(true);
                    for (int i = 0; i < 4; i++)
                    {
                        metroGridMain.Columns.Add(new DataGridViewTextBoxColumn());
                    }
                    metroGridMain.Columns[1].HeaderText = "Цвет";
                    metroGridMain.Columns[2].HeaderText = "Количество";
                    metroGridMain.Columns[3].HeaderText = "Цена за 1 шт";
                    metroGridMain.Columns[0].DataPropertyName = "id";
                    metroGridMain.Columns[1].DataPropertyName = "Color";
                    metroGridMain.Columns[2].DataPropertyName = "Count";
                    metroGridMain.Columns[3].DataPropertyName = "Price";
                    break;

            }

            metroGridMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            metroGridMain.AllowUserToAddRows = false;
            metroGridMain.Columns[0].Visible = false;

            hidePanels();
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
        private void hidePanels()
        {
            panelDecoration.Visible = false;
            panelPeople.Visible = false;
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

        private void btnMusic_Click(object sender, EventArgs e)
        {
            DSload(Condition.music);
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            DSload(Condition.photoman);
        }

        private void btnTamoda_Click(object sender, EventArgs e)
        {
            DSload(Condition.tamoda);
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            if (panelPeople.Visible == true)
            {
                panelPeople.Visible = false;
                return;
            }
            panelPeople.Visible = true;
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            if (panelDecoration.Visible == true)
            {
                panelDecoration.Visible = false;
                return;
            }
            panelDecoration.Visible = true;
        }

        private void metroGridMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (con == Condition.eventik)
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
                    Form form1 = new viewEvent(row, false);
                    form1.ShowDialog();
                }
            }
        }

        private void btnChangeElem_Click(object sender, EventArgs e)
        {
            DataRow row = null;
            int ind = 0;
            foreach (DataGridViewRow rows in metroGridMain.SelectedRows)
            {
                foreach (DataRow rows1 in ds.Tables[0].Rows)
                {
                    if (rows.Cells[0].Value.ToString() == rows1[0].ToString())
                    {
                        row = rows1;
                        break;
                    }
                    ind++;
                }
                switch(con)
                {
                    case Condition.eventik:
                        Form form1 = new ChangedEvent(row,idUser);
                        form1.ShowDialog();
                        break;
                    case Condition.music:
                        Form form2 = new viewPersonal(con,row, idUser);
                        form2.ShowDialog();
                        break;
                    case Condition.photoman:
                        Form form3 = new viewPersonal(con,row, idUser);
                        form3.ShowDialog();
                        break;
                    case Condition.tamoda:
                        Form form4 = new viewPersonal(con, row, idUser);
                        form4.ShowDialog();
                        break;
                    case Condition.restourant:
                        Form form5 = new changeFood(ds.Tables[0].Rows[ind], idUser);
                        form5.ShowDialog();
                        break;
                    case Condition.place:
                        Form form6 = new changePlace(row, idUser);
                        form6.ShowDialog();
                        break;
                    case Condition.ribbons:
                        Form form7 = new changeResources(con,row, idUser);
                        form7.ShowDialog();
                        break;
                    case Condition.balls:
                        Form form8 = new changeResources(con, row, idUser);
                        form8.ShowDialog();
                        break;
                    case Condition.flowers:
                        Form form9 = new changeResources(con, row, idUser);
                        form9.ShowDialog();
                        break;
                }

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

        private void btnDeleteElem_Click(object sender, EventArgs e)
        {
            int ind = 0;
            DataRow row = null;
            foreach (DataGridViewRow rows in metroGridMain.SelectedRows)
            { 
                if (rows.Index != -1)
                {                  
                    foreach (DataRow rows1 in ds.Tables[0].Rows)
                    {
                        if (rows.Cells[0].Value.ToString() == rows1[0].ToString())
                        {                            
                            row = rows1;
                            break;
                        }
                        ind++;
                    }
                    Form form1 = new delForm();
                    form1.ShowDialog();
                    if (form1.DialogResult == DialogResult.Yes)
                    {

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string sqlP= $"UPDATE [EventManagement].[dbo].[Event] SET PhotoMan=NULL WHERE PhotoMan = '{ rows.Cells[0].Value.ToString()}'";
                            switch (con)
                            {
                                case (Condition.eventik):
                                    {
                                        sqlP = sql;
                                        classs.CreateLogs(idUser, "Удаление события:" + rows.Cells[0].Value.ToString() + "");
                                        break;
                                    }
                                case (Condition.music):
                                    sqlP = $"UPDATE [EventManagement].[dbo].[Event] SET Music=NULL WHERE Music = '{ rows.Cells[0].Value.ToString()}'";
                                    classs.CreateLogs(idUser, "Удаление музыканта:" + rows.Cells[0].Value.ToString() + "");
                                    break;
                                case (Condition.photoman):
                                    sqlP = $"UPDATE [EventManagement].[dbo].[Event] SET PhotoMan=NULL WHERE PhotoMan = '{ rows.Cells[0].Value.ToString()}'";
                                    classs.CreateLogs(idUser, "Удаление фотографа:" + rows.Cells[0].Value.ToString() + "");
                                    break;
                                case (Condition.tamoda):
                                    sqlP = $"UPDATE [EventManagement].[dbo].[Event] SET Tamoda=NULL WHERE Tamoda = { rows.Cells[0].Value.ToString()}";
                                    classs.CreateLogs(idUser, "Удаление ведущего:" + rows.Cells[0].Value.ToString() + "");
                                    break;
                                case (Condition.ribbons):
                                    sqlP = $"UPDATE [EventManagement].[dbo].[Event] SET Ribbons=NULL WHERE Ribbons = '{ rows.Cells[0].Value.ToString()}'";
                                    classs.CreateLogs(idUser, "Удаление ленточек:" + rows.Cells[0].Value.ToString() + "");
                                    break;
                                case (Condition.balls):
                                    sqlP = $"UPDATE [EventManagement].[dbo].[Event] SET Balls=NULL WHERE Balls = '{ rows.Cells[0].Value.ToString()}'";
                                    classs.CreateLogs(idUser, "Удаление шариков:" + rows.Cells[0].Value.ToString() + "");
                                    break;
                                case (Condition.place):
                                    sqlP = $"UPDATE [EventManagement].[dbo].[Event] SET Place=NULL WHERE Place = '{ rows.Cells[0].Value.ToString()}'";
                                    classs.CreateLogs(idUser, "Удаление мест:" + rows.Cells[0].Value.ToString() + "");
                                    break;
                                case (Condition.restourant):
                                    sqlP = $"UPDATE [EventManagement].[dbo].[Event] SET RestaurantFood=NULL WHERE RestaurantFood = '{ rows.Cells[0].Value.ToString()}'";
                                    classs.CreateLogs(idUser, "Удаление еды:" + rows.Cells[0].Value.ToString() + "");
                                    break;
                                case (Condition.flowers):
                                    sqlP = $"UPDATE [EventManagement].[dbo].[Event] SET Flowers=NULL WHERE Flowers = '{ rows.Cells[0].Value.ToString()}'";
                                    classs.CreateLogs(idUser, "Удаление цветов:" + rows.Cells[0].Value.ToString() + "");
                                    break;
                            }
                            SqlCommand command = new SqlCommand(sqlP, connection);
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                       
                    }
                    if( con==Condition.tamoda)
                    {
                        sql3 = "SELECT * FROM [EventManagement].[dbo].[TamodaT]";
                        DSload(Condition.tamoda);
                    } 
                    metroGridMain.Rows.Remove(metroGridMain.Rows[ind]);
                    //ind = 0;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        adapter = new SqlDataAdapter(sql, connection);
                        commandBuilder = new SqlCommandBuilder(adapter);
                        adapter.Update(ds.Tables[0]);

                        adapter = new SqlDataAdapter(sql, connection);
                        commandBuilder = new SqlCommandBuilder(adapter);
                        ds.Clear();
                        adapter.Fill(ds);

                        connection.Close();
                    }
                    if (con == Condition.tamoda)
                    {
                        sql3 = "SELECT dbo.TamodaT.id , dbo.TamodaT.FIO, dbo.TamodaT.Phone, dbo.TamodaT.Price, Photo,Description,dbo.CategoryT.Name AS Category FROM dbo.TamodaT LEFT JOIN dbo.CategoryT ON dbo.TamodaT.Category = dbo.CategoryT.id";
                        DSload(Condition.tamoda);
                    }
                }
            }
        }

        private void btnAddElem_Click(object sender, EventArgs e)
        {
            Condition t = con;

            switch (t)
            {
                //Event
                case Condition.eventik:
                    {
                        sql = sql1;

                        Form form1 = new addEvent(idUser);
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
                        break;
                    }

                case Condition.music:
                {
                    sql = sql2;

                    Form form1 = new addPersonal(Condition.music, idUser);
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
                    break;
                }
                case Condition.tamoda:
                {
                    sql = sql3;

                    Form form1 = new addPersonal(Condition.tamoda, idUser);
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
                    break;
                };
                //PhotomanT
                case Condition.photoman:
                {
                    sql = sql4;

                    Form form1 = new addPersonal(Condition.photoman, idUser);
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
                    break;
                }
                //PlaceT
                case Condition.place:
                {
                    sql = sql5;

                    Form form1 = new addPlace(idUser);
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
                    break;
                }
                case Condition.restourant:
                {
                    sql = sql6;

                    Form form1 = new addFood(idUser);
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
                    break;
                }
                //Resourses
                //FlowersT
                case Condition.flowers:
                    {
                        sql = sql7;

                        Form form1 = new addResources(con, idUser);
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
                        break;
                    }
                //BallsT
                case Condition.balls:
                    {
                        sql = sql8;

                        Form form1 = new addResources(con, idUser);
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
                        break;
                    }
                //Ribbons
                case Condition.ribbons:
                    {
                        sql = sql9;

                        Form form1 = new addResources(con, idUser);
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
                        break;
                    }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            Condition t = con;


            switch (t)
            {
                case Condition.eventik:
                    ds.Tables[0].DefaultView.RowFilter = $"(NameEvent LIKE '{searchBox.Text}*') or (Client LIKE '{searchBox.Text}*')";
                    break;
                case Condition.music:   
                    ds.Tables[0].DefaultView.RowFilter = $"(Fio LIKE '{searchBox.Text}*')";
                    break;
                case Condition.tamoda:
                    ds.Tables[0].DefaultView.RowFilter = $"(Fio LIKE '{searchBox.Text}*')";
                    break;
                case Condition.photoman:  
                    ds.Tables[0].DefaultView.RowFilter = $"(Fio LIKE '{searchBox.Text}*')";
                    break;
                case Condition.place:
                    ds.Tables[0].DefaultView.RowFilter = $"(Name LIKE '{searchBox.Text}*')";
                    break;
                case Condition.restourant:
                    ds.Tables[0].DefaultView.RowFilter = $"(Name LIKE '{searchBox.Text}*')";
                    break;
                case Condition.flowers:      
                    ds.Tables[0].DefaultView.RowFilter = $"(Name LIKE '{searchBox.Text}*')";
                    break;
                case Condition.balls:
                    ds.Tables[0].DefaultView.RowFilter = $"(Color LIKE '{searchBox.Text}*')";
                    break;
                case Condition.ribbons:
                    ds.Tables[0].DefaultView.RowFilter = $"(Color LIKE '{searchBox.Text}*')";
                    break;
            }
        }

        private void btnPlaces_Click(object sender, EventArgs e)
        {
            DSload(Condition.place);
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            DSload(Condition.eventik);
        }

        private void btnDecoration_Click(object sender, EventArgs e)
        {
            DSload(Condition.flowers);
        }
        private void comboBoxChooseResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxChooseResource.SelectedIndex)
            {
                case 0:
                    DSload(Condition.flowers);
                    break;
                case 1:
                    DSload(Condition.balls);
                    break;
                case 2:
                    DSload(Condition.ribbons);
                    break;
            }
        }

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            DSload(Condition.restourant);
        }

        private void SearchD_Click(object sender, EventArgs e)
        {
            ds.Tables[0].DefaultView.RowFilter = $"DateEvent < #{DateTime.Today.ToString("yyyy-MM-dd")}#";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ds.Tables[0].DefaultView.RowFilter = $"DateEvent = #{dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")}#";           
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
                ds.Tables[0].DefaultView.RowFilter = $"DateEvent >= #{DateTime.Today.ToString("yyyy-MM-dd")}#";
        }
    }
}
