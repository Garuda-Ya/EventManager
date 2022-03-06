namespace EventApp
{
    partial class viewPersonal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.DicTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.DicrLabel = new System.Windows.Forms.Label();
            this.NumberLebel = new System.Windows.Forms.Label();
            this.maskedBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categorylabel = new System.Windows.Forms.Label();
            this.categoryBox1 = new MetroFramework.Controls.MetroComboBox();
            this.categoryTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventManagementDataSet = new EventApp.EventManagementDataSet();
            this.categoryTTableAdapter = new EventApp.EventManagementDataSetTableAdapters.CategoryTTableAdapter();
            this.addBtn = new XanderUI.XUIButton();
            this.ChooseBut = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.xuiButton3);
            this.panel1.Controls.Add(this.xuiButton1);
            this.panel1.Controls.Add(this.xuiButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 32);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.Red;
            this.xuiButton3.ButtonImage = null;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton3.ButtonText = "";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.Red;
            this.xuiButton3.ClickTextColor = System.Drawing.Color.Red;
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.Red;
            this.xuiButton3.HoverTextColor = System.Drawing.Color.Red;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(955, 8);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(15, 15);
            this.xuiButton3.TabIndex = 4;
            this.xuiButton3.TextColor = System.Drawing.Color.Red;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.Click += new System.EventHandler(this.xuiButton3_Click);
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.Yellow;
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton1.ButtonText = "";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.Yellow;
            this.xuiButton1.ClickTextColor = System.Drawing.Color.Yellow;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.Yellow;
            this.xuiButton1.HoverTextColor = System.Drawing.Color.Yellow;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(934, 8);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(15, 15);
            this.xuiButton1.TabIndex = 5;
            this.xuiButton1.TextColor = System.Drawing.Color.Yellow;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton2.ButtonText = "";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.ForestGreen;
            this.xuiButton2.ClickTextColor = System.Drawing.Color.ForestGreen;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.ForestGreen;
            this.xuiButton2.HoverTextColor = System.Drawing.Color.ForestGreen;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(913, 8);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(15, 15);
            this.xuiButton2.TabIndex = 6;
            this.xuiButton2.TextColor = System.Drawing.Color.ForestGreen;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(528, 83);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(356, 38);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DicTextBox
            // 
            this.DicTextBox.BackColor = System.Drawing.Color.Snow;
            this.DicTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DicTextBox.Location = new System.Drawing.Point(528, 275);
            this.DicTextBox.MaxLength = 300;
            this.DicTextBox.Multiline = true;
            this.DicTextBox.Name = "DicTextBox";
            this.DicTextBox.Size = new System.Drawing.Size(356, 157);
            this.DicTextBox.TabIndex = 14;
            this.DicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.Color.White;
            this.PriceTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTextBox.Location = new System.Drawing.Point(528, 147);
            this.PriceTextBox.MaxLength = 10;
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(356, 38);
            this.PriceTextBox.TabIndex = 15;
            this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countPeopleBox_KeyPress);
            // 
            // DicrLabel
            // 
            this.DicrLabel.AutoSize = true;
            this.DicrLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DicrLabel.Location = new System.Drawing.Point(404, 284);
            this.DicrLabel.Name = "DicrLabel";
            this.DicrLabel.Size = new System.Drawing.Size(118, 24);
            this.DicrLabel.TabIndex = 25;
            this.DicrLabel.Text = "Описание:";
            // 
            // NumberLebel
            // 
            this.NumberLebel.AutoSize = true;
            this.NumberLebel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLebel.Location = new System.Drawing.Point(416, 211);
            this.NumberLebel.Name = "NumberLebel";
            this.NumberLebel.Size = new System.Drawing.Size(106, 24);
            this.NumberLebel.TabIndex = 29;
            this.NumberLebel.Text = "Телефон:";
            // 
            // maskedBoxPhone
            // 
            this.maskedBoxPhone.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedBoxPhone.Location = new System.Drawing.Point(528, 208);
            this.maskedBoxPhone.Mask = "8(000)000-00-00";
            this.maskedBoxPhone.Name = "maskedBoxPhone";
            this.maskedBoxPhone.Size = new System.Drawing.Size(356, 32);
            this.maskedBoxPhone.TabIndex = 42;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(464, 86);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(58, 24);
            this.NameLabel.TabIndex = 53;
            this.NameLabel.Text = "Имя:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(452, 150);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(70, 24);
            this.priceLabel.TabIndex = 54;
            this.priceLabel.Text = "Цена:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(246, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "Добавление нового";
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categorylabel.Location = new System.Drawing.Point(37, 474);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(130, 24);
            this.categorylabel.TabIndex = 58;
            this.categorylabel.Text = "Категория:";
            this.categorylabel.Visible = false;
            // 
            // categoryBox1
            // 
            this.categoryBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.categoryBox1.DataSource = this.categoryTBindingSource;
            this.categoryBox1.DisplayMember = "Name";
            this.categoryBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBox1.FormattingEnabled = true;
            this.categoryBox1.ItemHeight = 23;
            this.categoryBox1.Location = new System.Drawing.Point(29, 442);
            this.categoryBox1.Name = "categoryBox1";
            this.categoryBox1.Size = new System.Drawing.Size(356, 29);
            this.categoryBox1.Style = MetroFramework.MetroColorStyle.Lime;
            this.categoryBox1.TabIndex = 59;
            this.categoryBox1.UseSelectable = true;
            this.categoryBox1.ValueMember = "Name";
            this.categoryBox1.Visible = false;
            this.categoryBox1.SelectedIndexChanged += new System.EventHandler(this.categoryBox1_SelectedIndexChanged);
            // 
            // categoryTBindingSource
            // 
            this.categoryTBindingSource.DataMember = "CategoryT";
            this.categoryTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // eventManagementDataSet
            // 
            this.eventManagementDataSet.DataSetName = "EventManagementDataSet";
            this.eventManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTTableAdapter
            // 
            this.categoryTTableAdapter.ClearBeforeFill = true;
            // 
            // addBtn
            // 
            this.addBtn.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.addBtn.ButtonImage = null;
            this.addBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.addBtn.ButtonText = "Добавить";
            this.addBtn.ClickBackColor = System.Drawing.Color.Black;
            this.addBtn.ClickTextColor = System.Drawing.Color.Black;
            this.addBtn.CornerRadius = 5;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.addBtn.HoverBackgroundColor = System.Drawing.Color.Black;
            this.addBtn.HoverTextColor = System.Drawing.Color.White;
            this.addBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.addBtn.Location = new System.Drawing.Point(393, 474);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(143, 50);
            this.addBtn.TabIndex = 60;
            this.addBtn.TextColor = System.Drawing.Color.Black;
            this.addBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ChooseBut
            // 
            this.ChooseBut.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.ChooseBut.ButtonImage = null;
            this.ChooseBut.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.ChooseBut.ButtonText = "Выбрать фото";
            this.ChooseBut.ClickBackColor = System.Drawing.Color.Black;
            this.ChooseBut.ClickTextColor = System.Drawing.Color.Black;
            this.ChooseBut.CornerRadius = 5;
            this.ChooseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ChooseBut.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.ChooseBut.HoverBackgroundColor = System.Drawing.Color.Black;
            this.ChooseBut.HoverTextColor = System.Drawing.Color.White;
            this.ChooseBut.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.ChooseBut.Location = new System.Drawing.Point(136, 382);
            this.ChooseBut.Name = "ChooseBut";
            this.ChooseBut.Size = new System.Drawing.Size(143, 50);
            this.ChooseBut.TabIndex = 61;
            this.ChooseBut.TextColor = System.Drawing.Color.Black;
            this.ChooseBut.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.ChooseBut.Click += new System.EventHandler(this.ChooseBut_Click);
            // 
            // viewPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(976, 560);
            this.Controls.Add(this.ChooseBut);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.categoryBox1);
            this.Controls.Add(this.categorylabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.maskedBoxPhone);
            this.Controls.Add(this.NumberLebel);
            this.Controls.Add(this.DicrLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.DicTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "viewPersonal";
            this.Text = "0";
            this.Load += new System.EventHandler(this.addPersonal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIButton xuiButton2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox DicTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label DicrLabel;
        private System.Windows.Forms.Label NumberLebel;
        private System.Windows.Forms.MaskedTextBox maskedBoxPhone;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label categorylabel;
        private MetroFramework.Controls.MetroComboBox categoryBox1;
        private EventManagementDataSet eventManagementDataSet;
        private System.Windows.Forms.BindingSource categoryTBindingSource;
        private EventManagementDataSetTableAdapters.CategoryTTableAdapter categoryTTableAdapter;
        private XanderUI.XUIButton addBtn;
        private XanderUI.XUIButton ChooseBut;
    }
}