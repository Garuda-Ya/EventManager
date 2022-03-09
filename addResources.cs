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

    public partial class addResources : Form
    {
        Class1 classs = new Class1();
        string idUser;
        Condition condition;
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        int id;
        string connectionString = @"Server=eventsqlconnect.eastus.cloudapp.azure.com;Database=EventManagement;Integrated Security=false;User ID=sa;Password=S8J-kJs-59D-ui7;";
        string sql;
        private void Insertfield()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                switch(condition)
                {
                    case Condition.balls:
                        sql = $"INSERT INTO BallsT (Color,Count,Price) VALUES('{nameTextBox.Text}','{textBoxAmount.Text}','{textBoxPrice.Text}')";
                        break;
                    case Condition.flowers:
                        sql = $"INSERT INTO FlowersT (Name,Count,Price) VALUES('{nameTextBox.Text}','{textBoxAmount.Text}','{textBoxPrice.Text}')";
                        break;
                    case Condition.ribbons:
                        sql = $"INSERT INTO RibbonsT (Color,Count,Price) VALUES('{nameTextBox.Text}','{textBoxAmount.Text}','{textBoxPrice.Text}')";
                        break;
                }
                
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                classs.CreateLogs(idUser, "Добавление украшений:" + nameTextBox.Text + "");
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public addResources(Condition condition1, string idUserr)
        {
            condition = condition1;
            idUser = idUserr;
            InitializeComponent();
            this.CenterToScreen();
            switch (condition)
            {
                case Condition.balls:
                    labelName.Text = "Цвет";
                    break;
                case Condition.ribbons:
                    labelName.Text = "Цвет";
                    break;
                case Condition.flowers:
                    labelName.Text = "Название";
                    labelName.Location = new Point(labelName.Location.X - 45, labelName.Location.Y);
                    break;
            }
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


        private void addBtn_Click(object sender, EventArgs e)
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
                Insertfield();
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
