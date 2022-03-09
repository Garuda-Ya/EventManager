namespace EventApp
{
    partial class viewEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewEvent));
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
            this.categoryTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventManagementDataSet = new EventApp.EventManagementDataSet();
            this.maskedBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.placeTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamodaTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoManBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowersTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ballsTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonsTBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.placeBox = new System.Windows.Forms.TextBox();
            this.ballsBox = new System.Windows.Forms.TextBox();
            this.restaurantFoodBox = new System.Windows.Forms.TextBox();
            this.ribbonsBox = new System.Windows.Forms.TextBox();
            this.flowersBox = new System.Windows.Forms.TextBox();
            this.musicBox = new System.Windows.Forms.TextBox();
            this.photoManBox = new System.Windows.Forms.TextBox();
            this.tamodaBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.btnPrint = new XanderUI.XUIButton();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.PrintFile = new System.Windows.Forms.Label();
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
            this.clientBox.MaxLength = 1000;
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
            this.buddgetBox.MaxLength = 1000;
            this.buddgetBox.Multiline = true;
            this.buddgetBox.Name = "buddgetBox";
            this.buddgetBox.Size = new System.Drawing.Size(311, 38);
            this.buddgetBox.TabIndex = 14;
            this.buddgetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countPeopleBox
            // 
            this.countPeopleBox.BackColor = System.Drawing.Color.White;
            this.countPeopleBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countPeopleBox.Location = new System.Drawing.Point(598, 453);
            this.countPeopleBox.MaxLength = 1000;
            this.countPeopleBox.Multiline = true;
            this.countPeopleBox.Name = "countPeopleBox";
            this.countPeopleBox.Size = new System.Drawing.Size(313, 38);
            this.countPeopleBox.TabIndex = 15;
            this.countPeopleBox.Text = "1";
            this.countPeopleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(313, 32);
            this.dateTimeBox.TabIndex = 43;
            this.dateTimeBox.Value = new System.DateTime(2022, 2, 27, 0, 0, 0, 0);
            // 
            // placeTBindingSource
            // 
            this.placeTBindingSource.DataMember = "PlaceT";
            this.placeTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // tamodaTBindingSource
            // 
            this.tamodaTBindingSource.DataMember = "TamodaT";
            this.tamodaTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // photoManBindingSource
            // 
            this.photoManBindingSource.DataMember = "PhotoMan";
            this.photoManBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // musicTBindingSource
            // 
            this.musicTBindingSource.DataMember = "MusicT";
            this.musicTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // flowersTBindingSource
            // 
            this.flowersTBindingSource.DataMember = "FlowersT";
            this.flowersTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // ballsTBindingSource
            // 
            this.ballsTBindingSource.DataMember = "BallsT";
            this.ballsTBindingSource.DataSource = this.eventManagementDataSet;
            // 
            // ribbonsTBindingSource
            // 
            this.ribbonsTBindingSource.DataMember = "RibbonsT";
            this.ribbonsTBindingSource.DataSource = this.eventManagementDataSet;
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
            // placeBox
            // 
            this.placeBox.BackColor = System.Drawing.Color.White;
            this.placeBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeBox.Location = new System.Drawing.Point(596, 223);
            this.placeBox.Multiline = true;
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(313, 38);
            this.placeBox.TabIndex = 56;
            this.placeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ballsBox
            // 
            this.ballsBox.BackColor = System.Drawing.Color.White;
            this.ballsBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ballsBox.Location = new System.Drawing.Point(158, 568);
            this.ballsBox.Multiline = true;
            this.ballsBox.Name = "ballsBox";
            this.ballsBox.Size = new System.Drawing.Size(313, 38);
            this.ballsBox.TabIndex = 57;
            this.ballsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // restaurantFoodBox
            // 
            this.restaurantFoodBox.BackColor = System.Drawing.Color.White;
            this.restaurantFoodBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restaurantFoodBox.Location = new System.Drawing.Point(158, 509);
            this.restaurantFoodBox.Multiline = true;
            this.restaurantFoodBox.Name = "restaurantFoodBox";
            this.restaurantFoodBox.Size = new System.Drawing.Size(313, 38);
            this.restaurantFoodBox.TabIndex = 58;
            this.restaurantFoodBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ribbonsBox
            // 
            this.ribbonsBox.BackColor = System.Drawing.Color.White;
            this.ribbonsBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ribbonsBox.Location = new System.Drawing.Point(158, 450);
            this.ribbonsBox.Multiline = true;
            this.ribbonsBox.Name = "ribbonsBox";
            this.ribbonsBox.Size = new System.Drawing.Size(313, 38);
            this.ribbonsBox.TabIndex = 59;
            this.ribbonsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowersBox
            // 
            this.flowersBox.BackColor = System.Drawing.Color.White;
            this.flowersBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowersBox.Location = new System.Drawing.Point(158, 394);
            this.flowersBox.Multiline = true;
            this.flowersBox.Name = "flowersBox";
            this.flowersBox.Size = new System.Drawing.Size(313, 38);
            this.flowersBox.TabIndex = 60;
            this.flowersBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // musicBox
            // 
            this.musicBox.BackColor = System.Drawing.Color.White;
            this.musicBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicBox.Location = new System.Drawing.Point(158, 336);
            this.musicBox.Multiline = true;
            this.musicBox.Name = "musicBox";
            this.musicBox.Size = new System.Drawing.Size(313, 38);
            this.musicBox.TabIndex = 61;
            this.musicBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // photoManBox
            // 
            this.photoManBox.BackColor = System.Drawing.Color.White;
            this.photoManBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoManBox.Location = new System.Drawing.Point(158, 278);
            this.photoManBox.Multiline = true;
            this.photoManBox.Name = "photoManBox";
            this.photoManBox.Size = new System.Drawing.Size(313, 38);
            this.photoManBox.TabIndex = 62;
            this.photoManBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tamodaBox
            // 
            this.tamodaBox.BackColor = System.Drawing.Color.White;
            this.tamodaBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tamodaBox.Location = new System.Drawing.Point(158, 220);
            this.tamodaBox.Multiline = true;
            this.tamodaBox.Name = "tamodaBox";
            this.tamodaBox.Size = new System.Drawing.Size(313, 38);
            this.tamodaBox.TabIndex = 63;
            this.tamodaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.Color.White;
            this.categoryBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryBox.Location = new System.Drawing.Point(367, 156);
            this.categoryBox.Multiline = true;
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(313, 38);
            this.categoryBox.TabIndex = 64;
            this.categoryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleName = "распечатать   ";
            this.btnPrint.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrint.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.ButtonImage")));
            this.btnPrint.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPrint.ButtonText = "Распечать";
            this.btnPrint.ClickBackColor = System.Drawing.Color.Black;
            this.btnPrint.ClickTextColor = System.Drawing.Color.Black;
            this.btnPrint.CornerRadius = 5;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrint.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPrint.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPrint.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPrint.Location = new System.Drawing.Point(750, 621);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(159, 62);
            this.btnPrint.TabIndex = 65;
            this.btnPrint.TextColor = System.Drawing.Color.Black;
            this.btnPrint.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // fileNameBox
            // 
            this.fileNameBox.BackColor = System.Drawing.Color.White;
            this.fileNameBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameBox.Location = new System.Drawing.Point(276, 645);
            this.fileNameBox.MaxLength = 30;
            this.fileNameBox.Multiline = true;
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(333, 38);
            this.fileNameBox.TabIndex = 66;
            this.fileNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PrintFile
            // 
            this.PrintFile.AutoSize = true;
            this.PrintFile.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintFile.Location = new System.Drawing.Point(140, 651);
            this.PrintFile.Name = "PrintFile";
            this.PrintFile.Size = new System.Drawing.Size(118, 24);
            this.PrintFile.TabIndex = 67;
            this.PrintFile.Text = "Имя файла";
            // 
            // viewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(980, 723);
            this.Controls.Add(this.PrintFile);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.tamodaBox);
            this.Controls.Add(this.photoManBox);
            this.Controls.Add(this.musicBox);
            this.Controls.Add(this.flowersBox);
            this.Controls.Add(this.ribbonsBox);
            this.Controls.Add(this.restaurantFoodBox);
            this.Controls.Add(this.ballsBox);
            this.Controls.Add(this.placeBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeBox);
            this.Controls.Add(this.maskedBoxPhone);
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
            this.Name = "viewEvent";
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
        private System.Windows.Forms.MaskedTextBox maskedBoxPhone;
        private System.Windows.Forms.DateTimePicker dateTimeBox;
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
        private System.Windows.Forms.TextBox placeBox;
        private System.Windows.Forms.TextBox ballsBox;
        private System.Windows.Forms.TextBox restaurantFoodBox;
        private System.Windows.Forms.TextBox ribbonsBox;
        private System.Windows.Forms.TextBox flowersBox;
        private System.Windows.Forms.TextBox musicBox;
        private System.Windows.Forms.TextBox photoManBox;
        private System.Windows.Forms.TextBox tamodaBox;
        private System.Windows.Forms.TextBox categoryBox;
        private XanderUI.XUIButton btnPrint;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Label PrintFile;
    }
}