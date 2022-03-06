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

    public partial class addPersonal : Form
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
        private void Insertfield()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                switch (condition)
                {
                    case Condition.music:
                        sql = $"INSERT INTO MusicT (FIO,Phone,Price,Photo,Description) VALUES('{nameTextBox.Text}','{maskedBoxPhone.Text.Replace("(","").Replace(")","").Replace("-","")}','{PriceTextBox.Text}',@screen,'{DicTextBox.Text}')";
                        break;
                    case Condition.photoman:
                        sql = $"INSERT INTO PhotoMan (FIO,Phone,Price,Photo,Description) VALUES('{nameTextBox.Text}','{maskedBoxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "")}','{PriceTextBox.Text}',@screen,'{DicTextBox.Text}')";
                        break;
                    case Condition.tamoda:
                        sql = $"INSERT INTO TamodaT (FIO,Phone,Price,Photo,Description,Category) VALUES('{nameTextBox.Text}','{maskedBoxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "")}','{PriceTextBox.Text}',@screen,'{DicTextBox.Text}',{getId("categoryT","Name",categoryBox1.Text)})";
                        break;
                }
                connection.Open(); 
                byte[] imageData = null;
                string iFile = FileName;
                FileInfo fInfo = new FileInfo(iFile);
                long numBytes = fInfo.Length;
                FileStream fStream = new FileStream(iFile, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                imageData = br.ReadBytes((int)numBytes);
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@screen", (object)imageData);
                command.ExecuteNonQuery();
                classs.CreateLogs(idUser, "Добавление персонала:" + nameTextBox.Text + "");
                connection.Close();
            }
        }
        public addPersonal(Condition condition1, string idUserr)
        {
            condition = condition1;
            idUser = idUserr;
            InitializeComponent();
            this.CenterToScreen();
            if (condition1 == Condition.tamoda)
            {
                this.Size = new Size(this.Width, this.Height + 90);
                categorylabel.Location = new Point(522 - categorylabel.Width, 275);
                categoryBox1.Location = new Point(528, 275);
                categorylabel.Visible = true;
                categoryBox1.Visible = true;
                DicrLabel.Location = new Point(DicrLabel.Location.X, DicrLabel.Location.Y + 90);
                DicTextBox.Location = new Point(DicTextBox.Location.X, DicTextBox.Location.Y + 90);
                addBtn.Location = new Point(addBtn.Location.X, addBtn.Location.Y + 90);
            }
            switch (condition)
            {
                case Condition.music:
                    label1.Text += " Музыканта";
                    break;
                case Condition.photoman:
                    label1.Text += " Фотографа";
                    break;
                case Condition.tamoda:
                    label1.Text += " Ведущего";
                    break;
            }
        }

        private void setComboBox( ComboBox cb)
        {
            string sql1 = $"SELECT Name FROM [EventManagement].[dbo].[CategoryT]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql1, connection);
                DataTable dt = new DataTable();
                //ds = new DataSet();
                adapter.Fill(dt);
                cb.DataSource = dt;
                connection.Close();
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
                MessageBox.Show("Введите Ф.И.О!");
            }
            else if (PriceTextBox.Text == "")
            {
                MessageBox.Show("Введите цену за работу!");
            }
            else if (maskedBoxPhone.Text == "")
            {
                MessageBox.Show("Введите кол-во человек!");
            }
            else if(FileName==null)
            {
                MessageBox.Show("Выберите картинку");
            }
            else if (maskedBoxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Length < 11)
            {
                MessageBox.Show("Введите полноценный номер");
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

        private void ChooseBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.JPEG)| *.BMP; *.JPG; *.JPEG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл");
                }
                finally
                {
                    FileName = ofd.FileName;
                }
                
            }
        }

        private void addPersonal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eventManagementDataSet.CategoryT". При необходимости она может быть перемещена или удалена.
            this.categoryTTableAdapter.Fill(this.eventManagementDataSet.CategoryT);

        }
    }
}
