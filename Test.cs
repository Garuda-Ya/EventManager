using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace EventApp
{
    public partial class Test : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=EventManagement;Integrated Security=True";
        private string sql = "SELECT * FROM [EventManagement].[dbo].[MusicT]";
        public Test()
        {
            InitializeComponent();
            metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            metroGrid1.AllowUserToAddRows = false;
            metroGrid1.Columns[0].Visible = false;
            List<byte[]> iScreen = new List<byte[]>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = @"SELECT [Photo] FROM [EventManagement].[dbo].[MusicT]";
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                byte[] iTrimByte = null;
                string iTrimText = null;
                while (sqlReader.Read())
                {
                    iTrimByte = (byte[])sqlReader["Photo"]; 
                    iScreen.Add(iTrimByte);
                }
              
             

                connection.Close();
            }
            byte[] imageData = iScreen[0];
            MemoryStream ms = new MemoryStream(imageData);
            Image newImage = Image.FromStream(ms,true);

            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            iconColumn.Image = newImage;
            iconColumn.Name = "Tree";
            iconColumn.HeaderText = "Nice tree";
            metroGrid1.Columns.Insert(5, iconColumn);

        }
        private void Insertfield()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string iFile = @"jj.jpg";
                byte[] imageData = null;
                FileInfo fInfo = new FileInfo(iFile);
                long numBytes = fInfo.Length;
                FileStream fStream = new FileStream(iFile, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                imageData = br.ReadBytes((int)numBytes);
                string commandText = "INSERT INTO MusicT (FIO,Phone,Price,Description,Photo) VALUES('dfdgd','dghdh','3533','dfgdgd',@screen)"; // запрос на вставку
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@screen", (object)imageData); // записываем само изображение
                
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eventManagementDataSet.MusicT". При необходимости она может быть перемещена или удалена.
            this.musicTTableAdapter.Fill(this.eventManagementDataSet.MusicT);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Insertfield();
        }
    }
}
