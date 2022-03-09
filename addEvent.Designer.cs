namespace EventApp
{
    partial class addEvent
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
            this.nameEventBox = new System.Windows.Forms.TextBox();
            this.clientBox = new System.Windows.Forms.TextBox();
            this.buddgetBox = new System.Windows.Forms.TextBox();
            this.countPeopleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.addBtn = new XanderUI.XUIButton();
            this.comboBoxCategory = new MetroFramework.Controls.MetroComboBox();
            this.categoryTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventManagementDataSet = new EventApp.EventManagementDataSet();
            this.maskedBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPlace = new MetroFramework.Controls.MetroComboBox();
            this.placeTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxTamoda = new MetroFramework.Controls.MetroComboBox();
            this.tamodaTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxPhoto = new MetroFramework.Controls.MetroComboBox();
            this.photoManBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMusic = new MetroFramework.Controls.MetroComboBox();
            this.musicTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFlowers = new MetroFramework.Controls.MetroComboBox();
            this.flowersTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxBalls = new MetroFramework.Controls.MetroComboBox();
            this.ballsTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxRibbons = new MetroFramework.Controls.MetroComboBox();
            this.ribbonsTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFood = new MetroFramework.Controls.MetroComboBox();
            this.restaurantFoodTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.categoryTTableAdapter = new EventApp.EventManagementDataSetTableAdapters.CategoryTTableAdapter();
            this.tamodaTTableAdapter = new EventApp.EventManagementDataSetTableAdapters.TamodaTTableAdapter();
            this.photoManTableAdapter = new EventApp.EventManagementDataSetTableAdapters.PhotoManTableAdapter();
            this.musicTTableAdapter = new EventApp.EventManagementDataSetTableAdapters.MusicTTableAdapter();
            this.flowersTTableAdapter = new EventApp.EventManagementDataSetTableAdapters.FlowersTTableAdapter();
            this.ribbonsTTableAdapter = new EventApp.EventManagementDataSetTableAdapters.RibbonsTTableAdapter();
            this.restaurantFoodTTableAdapter = new EventApp.EventManagementDataSetTableAdapters.RestaurantFoodTTableAdapter();
            this.ballsTTableAdapter = new EventApp.EventManagementDataSetTableAdapters.BallsTTableAdapter();
            this.placeTTableAdapter = new EventApp.EventManagementDataSetTableAdapters.PlaceTTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamodaTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoManBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballsTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonsTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantFoodTBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(980, 32);
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
            // nameEventBox
            // 
            this.nameEventBox.BackColor = System.Drawing.Color.White;
            this.nameEventBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameEventBox.Location = new System.Drawing.Point(347, 94);
            this.nameEventBox.MaxLength = 50;
            this.nameEventBox.Multiline = true;
            this.nameEventBox.Name = "nameEventBox";
            this.nameEventBox.Size = new System.Drawing.Size(356, 38);
            this.nameEventBox.TabIndex = 10;
            this.nameEventBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clientBox
            // 
            this.clientBox.BackColor = System.Drawing.Color.White;
            this.clientBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientBox.Location = new System.Drawing.Point(598, 278);
            this.clientBox.MaxLength = 50;
            this.clientBox.Multiline = true;
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(313, 38);
            this.clientBox.TabIndex = 11;
            this.clientBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buddgetBox
            // 
            this.buddgetBox.BackColor = System.Drawing.Color.Snow;
            this.buddgetBox.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold);
            this.buddgetBox.Location = new System.Drawing.Point(598, 521);
            this.buddgetBox.MaxLength = 15;
            this.buddgetBox.Multiline = true;
            this.buddgetBox.Name = "buddgetBox";
            this.buddgetBox.Size = new System.Drawing.Size(311, 38);
            this.buddgetBox.TabIndex = 14;
            this.buddgetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buddgetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buddgetBox_KeyPress);
            // 
            // countPeopleBox
            // 
            this.countPeopleBox.BackColor = System.Drawing.Color.White;
            this.countPeopleBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countPeopleBox.Location = new System.Drawing.Point(598, 453);
            this.countPeopleBox.MaxLength = 4;
            this.countPeopleBox.Multiline = true;
            this.countPeopleBox.Name = "countPeopleBox";
            this.countPeopleBox.Size = new System.Drawing.Size(313, 38);
            this.countPeopleBox.TabIndex = 15;
            this.countPeopleBox.Text = "1";
            this.countPeopleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countPeopleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countPeopleBox_KeyPress);
            this.countPeopleBox.Leave += new System.EventHandler(this.countPeopleBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ведущий:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Фотограф:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Музыкант:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(502, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Клиент:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(490, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Телефон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(514, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Место:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(510, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 48);
            this.label8.TabIndex = 32;
            this.label8.Text = "Кол-во\r\nлюдей:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(526, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Дата:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(502, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "Бюджет:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(70, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 24);
            this.label11.TabIndex = 35;
            this.label11.Text = "Цветы:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(82, 571);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 24);
            this.label12.TabIndex = 36;
            this.label12.Text = "Шары:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(70, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 24);
            this.label13.TabIndex = 37;
            this.label13.Text = "Ленты:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(94, 512);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 24);
            this.label14.TabIndex = 38;
            this.label14.Text = "Еда:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
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
            this.addBtn.Location = new System.Drawing.Point(692, 594);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(143, 50);
            this.addBtn.TabIndex = 39;
            this.addBtn.TextColor = System.Drawing.Color.Black;
            this.addBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataSource = this.categoryTBindingSource;
            this.comboBoxCategory.DisplayMember = "Name";
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.ItemHeight = 23;
            this.comboBoxCategory.Location = new System.Drawing.Point(368, 160);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(313, 29);
            this.comboBoxCategory.TabIndex = 41;
            this.comboBoxCategory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboBoxCategory.UseSelectable = true;
            this.comboBoxCategory.ValueMember = "Name";
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
            // maskedBoxPhone
            // 
            this.maskedBoxPhone.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedBoxPhone.Location = new System.Drawing.Point(598, 397);
            this.maskedBoxPhone.Mask = "8(000)000-00-00";
            this.maskedBoxPhone.Name = "maskedBoxPhone";
            this.maskedBoxPhone.Size = new System.Drawing.Size(313, 32);
            this.maskedBoxPhone.TabIndex = 42;
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.CustomFormat = "yyyy-MM-dd";
            this.dateTimeBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBox.Location = new System.Drawing.Point(598, 339);
            this.dateTimeBox.MinDate = new System.DateTime(2022, 3, 6, 0, 0, 0, 0);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(313, 32);
            this.dateTimeBox.TabIndex = 43;
            this.dateTimeBox.Value = new System.DateTime(2022, 3, 6, 0, 0, 0, 0);
            this.dateTimeBox.ValueChanged += new System.EventHandler(this.dateTimeBox_ValueChanged);
            // 
            // comboBoxPlace
            // 
            this.comboBoxPlace.DataSource = this.placeTBindingSource;
            this.comboBoxPlace.DisplayMember = "Name";
            this.comboBoxPlace.FormattingEnabled = true;
            this.comboBoxPlace.ItemHeight = 23;
            this.comboBoxPlace.Location = new System.Drawing.Point(598, 223);
            this.comboBoxPlace.Name = "comboBoxPlace";
            this.comboBoxPlace.Size = new System.Drawing.Size(313, 29);
            this.comboBoxPlace.TabIndex = 45;
            this.comboBoxPlace.UseSelectable = true;
            this.comboBoxPlace.ValueMember = "Name";
            // 
            // placeTBindingSource
            // 
            this.placeTBindingSource.DataMember = "PlaceT";
            this.placeTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // comboBoxTamoda
            // 
            this.comboBoxTamoda.DataSource = this.tamodaTBindingSource;
            this.comboBoxTamoda.DisplayMember = "FIO";
            this.comboBoxTamoda.FormattingEnabled = true;
            this.comboBoxTamoda.ItemHeight = 23;
            this.comboBoxTamoda.Location = new System.Drawing.Point(158, 223);
            this.comboBoxTamoda.Name = "comboBoxTamoda";
            this.comboBoxTamoda.Size = new System.Drawing.Size(313, 29);
            this.comboBoxTamoda.TabIndex = 46;
            this.comboBoxTamoda.UseSelectable = true;
            this.comboBoxTamoda.ValueMember = "FIO";
            // 
            // tamodaTBindingSource
            // 
            this.tamodaTBindingSource.DataMember = "TamodaT";
            this.tamodaTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // comboBoxPhoto
            // 
            this.comboBoxPhoto.DataSource = this.photoManBindingSource;
            this.comboBoxPhoto.DisplayMember = "FIO";
            this.comboBoxPhoto.FormattingEnabled = true;
            this.comboBoxPhoto.ItemHeight = 23;
            this.comboBoxPhoto.Location = new System.Drawing.Point(158, 281);
            this.comboBoxPhoto.Name = "comboBoxPhoto";
            this.comboBoxPhoto.Size = new System.Drawing.Size(313, 29);
            this.comboBoxPhoto.TabIndex = 47;
            this.comboBoxPhoto.UseSelectable = true;
            this.comboBoxPhoto.ValueMember = "FIO";
            // 
            // photoManBindingSource
            // 
            this.photoManBindingSource.DataMember = "PhotoMan";
            this.photoManBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // comboBoxMusic
            // 
            this.comboBoxMusic.DataSource = this.musicTBindingSource;
            this.comboBoxMusic.DisplayMember = "FIO";
            this.comboBoxMusic.FormattingEnabled = true;
            this.comboBoxMusic.ItemHeight = 23;
            this.comboBoxMusic.Location = new System.Drawing.Point(158, 339);
            this.comboBoxMusic.Name = "comboBoxMusic";
            this.comboBoxMusic.Size = new System.Drawing.Size(313, 29);
            this.comboBoxMusic.TabIndex = 48;
            this.comboBoxMusic.UseSelectable = true;
            this.comboBoxMusic.ValueMember = "FIO";
            // 
            // musicTBindingSource
            // 
            this.musicTBindingSource.DataMember = "MusicT";
            this.musicTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // comboBoxFlowers
            // 
            this.comboBoxFlowers.DataSource = this.flowersTBindingSource;
            this.comboBoxFlowers.DisplayMember = "Name";
            this.comboBoxFlowers.FormattingEnabled = true;
            this.comboBoxFlowers.ItemHeight = 23;
            this.comboBoxFlowers.Location = new System.Drawing.Point(158, 397);
            this.comboBoxFlowers.Name = "comboBoxFlowers";
            this.comboBoxFlowers.Size = new System.Drawing.Size(313, 29);
            this.comboBoxFlowers.TabIndex = 49;
            this.comboBoxFlowers.UseSelectable = true;
            this.comboBoxFlowers.ValueMember = "Name";
            // 
            // flowersTBindingSource
            // 
            this.flowersTBindingSource.DataMember = "FlowersT";
            this.flowersTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // comboBoxBalls
            // 
            this.comboBoxBalls.DataSource = this.ballsTBindingSource;
            this.comboBoxBalls.DisplayMember = "Color";
            this.comboBoxBalls.FormattingEnabled = true;
            this.comboBoxBalls.ItemHeight = 23;
            this.comboBoxBalls.Location = new System.Drawing.Point(158, 571);
            this.comboBoxBalls.Name = "comboBoxBalls";
            this.comboBoxBalls.Size = new System.Drawing.Size(313, 29);
            this.comboBoxBalls.TabIndex = 50;
            this.comboBoxBalls.UseSelectable = true;
            this.comboBoxBalls.ValueMember = "Color";
            // 
            // ballsTBindingSource
            // 
            this.ballsTBindingSource.DataMember = "BallsT";
            this.ballsTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // comboBoxRibbons
            // 
            this.comboBoxRibbons.DataSource = this.ribbonsTBindingSource;
            this.comboBoxRibbons.DisplayMember = "Color";
            this.comboBoxRibbons.FormattingEnabled = true;
            this.comboBoxRibbons.ItemHeight = 23;
            this.comboBoxRibbons.Location = new System.Drawing.Point(158, 455);
            this.comboBoxRibbons.Name = "comboBoxRibbons";
            this.comboBoxRibbons.Size = new System.Drawing.Size(313, 29);
            this.comboBoxRibbons.TabIndex = 51;
            this.comboBoxRibbons.UseSelectable = true;
            this.comboBoxRibbons.ValueMember = "Color";
            // 
            // ribbonsTBindingSource
            // 
            this.ribbonsTBindingSource.DataMember = "RibbonsT";
            this.ribbonsTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.DataSource = this.restaurantFoodTBindingSource;
            this.comboBoxFood.DisplayMember = "Name";
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.ItemHeight = 23;
            this.comboBoxFood.Location = new System.Drawing.Point(158, 513);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(313, 29);
            this.comboBoxFood.TabIndex = 52;
            this.comboBoxFood.UseSelectable = true;
            this.comboBoxFood.ValueMember = "Name";
            // 
            // restaurantFoodTBindingSource
            // 
            this.restaurantFoodTBindingSource.DataMember = "RestaurantFoodT";
            this.restaurantFoodTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(224, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Название:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(233, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 24);
            this.label15.TabIndex = 54;
            this.label15.Text = "Категория:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(342, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(402, 28);
            this.label16.TabIndex = 55;
            this.label16.Text = "Добавление нового мероприятия ";
            // 
            // categoryTTableAdapter
            // 
            this.categoryTTableAdapter.ClearBeforeFill = true;
            // 
            // tamodaTTableAdapter
            // 
            this.tamodaTTableAdapter.ClearBeforeFill = true;
            // 
            // photoManTableAdapter
            // 
            this.photoManTableAdapter.ClearBeforeFill = true;
            // 
            // musicTTableAdapter
            // 
            this.musicTTableAdapter.ClearBeforeFill = true;
            // 
            // flowersTTableAdapter
            // 
            this.flowersTTableAdapter.ClearBeforeFill = true;
            // 
            // ribbonsTTableAdapter
            // 
            this.ribbonsTTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantFoodTTableAdapter
            // 
            this.restaurantFoodTTableAdapter.ClearBeforeFill = true;
            // 
            // ballsTTableAdapter
            // 
            this.ballsTTableAdapter.ClearBeforeFill = true;
            // 
            // placeTTableAdapter
            // 
            this.placeTTableAdapter.ClearBeforeFill = true;
            // 
            // addEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(980, 660);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxFood);
            this.Controls.Add(this.comboBoxRibbons);
            this.Controls.Add(this.comboBoxBalls);
            this.Controls.Add(this.comboBoxFlowers);
            this.Controls.Add(this.comboBoxMusic);
            this.Controls.Add(this.comboBoxPhoto);
            this.Controls.Add(this.comboBoxTamoda);
            this.Controls.Add(this.comboBoxPlace);
            this.Controls.Add(this.dateTimeBox);
            this.Controls.Add(this.maskedBoxPhone);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countPeopleBox);
            this.Controls.Add(this.buddgetBox);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.nameEventBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(980, 660);
            this.Name = "addEvent";
            this.Text = "infoForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamodaTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoManBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballsTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonsTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantFoodTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIButton xuiButton2;
        private System.Windows.Forms.TextBox nameEventBox;
        private System.Windows.Forms.TextBox clientBox;
        private System.Windows.Forms.TextBox buddgetBox;
        private System.Windows.Forms.TextBox countPeopleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private XanderUI.XUIButton addBtn;
        private MetroFramework.Controls.MetroComboBox comboBoxCategory;
        private System.Windows.Forms.MaskedTextBox maskedBoxPhone;
        private System.Windows.Forms.DateTimePicker dateTimeBox;
        private MetroFramework.Controls.MetroComboBox comboBoxPlace;
        private MetroFramework.Controls.MetroComboBox comboBoxTamoda;
        private MetroFramework.Controls.MetroComboBox comboBoxPhoto;
        private MetroFramework.Controls.MetroComboBox comboBoxMusic;
        private MetroFramework.Controls.MetroComboBox comboBoxFlowers;
        private MetroFramework.Controls.MetroComboBox comboBoxBalls;
        private MetroFramework.Controls.MetroComboBox comboBoxRibbons;
        private MetroFramework.Controls.MetroComboBox comboBoxFood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private EventManagementDataSet eventManagementDataSet;
        private System.Windows.Forms.BindingSource categoryTBindingSource;
        private EventManagementDataSetTableAdapters.CategoryTTableAdapter categoryTTableAdapter;
        private System.Windows.Forms.BindingSource tamodaTBindingSource;
        private EventManagementDataSetTableAdapters.TamodaTTableAdapter tamodaTTableAdapter;
        private System.Windows.Forms.BindingSource photoManBindingSource;
        private EventManagementDataSetTableAdapters.PhotoManTableAdapter photoManTableAdapter;
        private System.Windows.Forms.BindingSource musicTBindingSource;
        private EventManagementDataSetTableAdapters.MusicTTableAdapter musicTTableAdapter;
        private System.Windows.Forms.BindingSource flowersTBindingSource;
        private EventManagementDataSetTableAdapters.FlowersTTableAdapter flowersTTableAdapter;
        private System.Windows.Forms.BindingSource ribbonsTBindingSource;
        private EventManagementDataSetTableAdapters.RibbonsTTableAdapter ribbonsTTableAdapter;
        private System.Windows.Forms.BindingSource restaurantFoodTBindingSource;
        private EventManagementDataSetTableAdapters.RestaurantFoodTTableAdapter restaurantFoodTTableAdapter;
        private System.Windows.Forms.BindingSource ballsTBindingSource;
        private EventManagementDataSetTableAdapters.BallsTTableAdapter ballsTTableAdapter;
        private System.Windows.Forms.BindingSource placeTBindingSource;
        private EventManagementDataSetTableAdapters.PlaceTTableAdapter placeTTableAdapter;
    }
}