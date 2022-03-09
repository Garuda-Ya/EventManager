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

    public partial class viewPersonal : Form
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
        bool change=false;
        private void Insertfield()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {                
                if(change==true)
                {   
                    switch (condition)
                    {
                        case Condition.music:
                            sql = $"UPDATE [EventManagement].[dbo].[MusicT] SET FIO = '{nameTextBox.Text}',Phone = '{maskedBoxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "")}' ,Price = '{PriceTextBox.Text}',Photo =@screen, Description = '{DicTextBox.Text}'  WHERE id = {id}";
                            break;
                        case Condition.photoman:
                            sql = $"UPDATE [EventManagement].[dbo].[PhotoMan] SET FIO = '{nameTextBox.Text}',Phone = '{maskedBoxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "")}' ,Price = '{PriceTextBox.Text}',Photo =@screen, Description = '{DicTextBox.Text}'  WHERE id = {id}";
                            break;
                        case Condition.tamoda:
                            sql = $"UPDATE [EventManagement].[dbo].[TamodaT] SET FIO = '{nameTextBox.Text}',Phone = '{maskedBoxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "")}' ,Price = '{PriceTextBox.Text}',Photo =@screen, Description = '{DicTextBox.Text}', Category ={getId("categoryT", "Name", categoryBox1.PromptText)}  WHERE id = {id}";
                            break;
                    }
                    connection.Open();
                    string iFile = FileName;
                    byte[] imageData = null;
                    FileInfo fInfo = new FileInfo(iFile);
                    long numBytes = fInfo.Length;
                    FileStream fStream = new FileStream(iFile, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fStream);
                    imageData = br.ReadBytes((int)numBytes); 
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@screen", (object)imageData);
                    classs.CreateLogs(idUser, "Изменение персонала:" + nameTextBox.Text + "");
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    switch(condition)
                    {
                        case Condition.tamoda:
                            sql = $"UPDATE [EventManagement].[dbo].[TamodaT] SET FIO = '{nameTextBox.Text}',Phone = '{maskedBoxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "")}' ,Price = '{PriceTextBox.Text}', Description = '{DicTextBox.Text}', Category ={ getId("categoryT", "Name", categoryBox1.PromptText)} WHERE id = {id}";
                            break;
                        case Condition.photoman:
                            sql = $"UPDATE [EventManagement].[dbo].[PhotoMan] SET FIO = '{nameTextBox.Text}',Phone = '{maskedBoxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "")}' ,Price = '{PriceTextBox.Text}',Photo =@screen, Description = '{DicTextBox.Text}'  WHERE id = {id}";
                            break;
                        case Condition.music:
                            sql = $"UPDATE [EventManagement].[dbo].[MusicT] SET FIO = '{nameTextBox.Text}',Phone = '{maskedBoxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "")}' ,Price = '{PriceTextBox.Text}',Photo =@screen, Description = '{DicTextBox.Text}'  WHERE id = {id}";
                            break;

                    }   
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
     
            }
        }
        public viewPersonal(Condition condition1,DataRow row, string idUserr)
        {
            id = (int)row[0];
            idUser = idUserr;
            condition = condition1;
            InitializeComponent();
            this.CenterToScreen();
            switch (condition)
            {
                case Condition.music:
                    label1.Text += " Музыканта";
                    DicTextBox.Text = row[4].ToString();
                    nameTextBox.Text = row[1].ToString();
                    PriceTextBox.Text = row[3].ToString();
                    maskedBoxPhone.Text = row[2].ToString();
                    Stream stream = new MemoryStream((byte[])row[5]);
                    pictureBox1.Image = new Bitmap(stream);
                    break;
                case Condition.photoman:
                    label1.Text += " Фотографа";
                    DicTextBox.Text = row[5].ToString();
                    nameTextBox.Text = row[1].ToString();
                    PriceTextBox.Text = row[3].ToString();
                    maskedBoxPhone.Text = row[2].ToString();
                    Stream stream1 = new MemoryStream((byte[])row[4]);
                    pictureBox1.Image = new Bitmap(stream1);
                    break;
                case Condition.tamoda:
                    label1.Text += " Ведущего";
                    this.Size = new Size(this.Width, this.Height + 90);
                    categorylabel.Location = new Point(522 - categorylabel.Width, 275);
                    categoryBox1.Location = new Point(528, 275);
                    categorylabel.Visible = true;
                    categoryBox1.Visible = true;
                    DicrLabel.Location = new Point(DicrLabel.Location.X, DicrLabel.Location.Y + 90);
                    DicTextBox.Location = new Point(DicTextBox.Location.X, DicTextBox.Location.Y + 90);
                    addBtn.Location = new Point(addBtn.Location.X, addBtn.Location.Y + 90);
                    categoryBox1.PromptText= row[6].ToString();
                    //categoryBox1.ValueMember= row[6].ToString();
                    DicTextBox.Text = row[5].ToString();
                    nameTextBox.Text = row[1].ToString();
                    PriceTextBox.Text = row[3].ToString();
                    maskedBoxPhone.Text = row[2].ToString();
                    Stream stream2 = new MemoryStream((byte[])row[4]);
                    pictureBox1.Image = new Bitmap(stream2);
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
            MessageBox.Show(ip);
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
                    change = true;
                }
                
            }
        }

        private void addPersonal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eventManagementDataSet.CategoryT". При необходимости она может быть перемещена или удалена.
            this.categoryTTableAdapter.Fill(this.eventManagementDataSet.CategoryT);

        }

        private void categoryBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryBox1.PromptText = categoryBox1.Text;
        }
    }
}
