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

    public partial class changeResources : Form
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
                switch(condition)
                {
                    case Condition.balls:
                        sql = $"UPDATE BallsT SET Color = '" + nameTextBox.Text + "', Count = '" + textBoxAmount.Text + "', Price = '" + textBoxPrice.Text + "' WHERE id = '" + id.ToString() + "'";
                        break;
                    case Condition.flowers:
                        sql = $"UPDATE FlowersT SET Name = '" + nameTextBox.Text + "', Count = '" + textBoxAmount.Text + "', Price = '" + textBoxPrice.Text + "' WHERE id = '" + id.ToString() + "'";
                        break;
                    case Condition.ribbons:
                        sql = $"UPDATE RibbonsT SET Color = '" + nameTextBox.Text + "', Count = '" + textBoxAmount.Text + "', Price = '" + textBoxPrice.Text + "' WHERE id = '" + id.ToString() + "'";
                        break;
                }
                
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                classs.CreateLogs(idUser, "Изменение украшеный:" + nameTextBox.Text + "");
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public changeResources(Condition condition1, DataRow row, string idUserr)
        {
            idUser = idUserr;
            condition = condition1;
            id = System.Convert.ToInt32(row[0]);
            InitializeComponent();
            this.CenterToScreen();
            switch (condition)
            {
                case Condition.balls:
                    labelName.Text = "Цвет";
                    sql = $"SELECT Color, Count, Price FROM [EventManagement].[dbo].[BallsT] WHERE id = {row[0]}";
                    break;
                case Condition.ribbons:
                    labelName.Text = "Цвет";
                    sql = $"SELECT Color, Count, Price FROM [EventManagement].[dbo].[RibbonsT] WHERE id = {row[0]}";
                    break;
                case Condition.flowers:
                    labelName.Text = "Название";
                    labelName.Location = new Point(labelName.Location.X-45, labelName.Location.Y);
                    sql = $"SELECT Name, Count, Price FROM [EventManagement].[dbo].[FlowersT] WHERE id = {row[0]}";

                    break;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);

                connection.Close();
            }
            switch(condition)
            {
                case Condition.balls:
                    textBoxPrice.Text = ds.Tables[0].Rows[0]["Price"].ToString();
                    textBoxAmount.Text = ds.Tables[0].Rows[0]["Count"].ToString();
                    nameTextBox.Text = ds.Tables[0].Rows[0]["Color"].ToString(); ;
                    break;
                case Condition.ribbons:
                    textBoxPrice.Text = ds.Tables[0].Rows[0]["Price"].ToString();
                    textBoxAmount.Text = ds.Tables[0].Rows[0]["Count"].ToString();
                    nameTextBox.Text = ds.Tables[0].Rows[0]["Color"].ToString(); ;
                    break;
                case Condition.flowers:
                    textBoxPrice.Text = ds.Tables[0].Rows[0]["Price"].ToString();
                    textBoxAmount.Text = ds.Tables[0].Rows[0]["Count"].ToString();
                    nameTextBox.Text = ds.Tables[0].Rows[0]["Name"].ToString(); ;
                    break;
            }
            this.CenterToScreen();

        }

        private int getId(string nameTable, string name, string ip)
        {
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
            return System.Convert.ToInt32(id);
        }


        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                if (condition == Condition.flowers ) MessageBox.Show("Введите название цветов!");
                else MessageBox.Show("Введите цвет!");
            }
            else if (textBoxPrice.Text == "")
            {
                MessageBox.Show("Введите количество штук!");
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

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
