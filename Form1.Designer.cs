namespace EventApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroGridMain = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buddget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestaurantFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Music = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flowers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ribbons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelDecoration = new System.Windows.Forms.Panel();
            this.btnRestaurant = new XanderUI.XUIButton();
            this.btnDecoration = new XanderUI.XUIButton();
            this.btnResources = new XanderUI.XUIButton();
            this.btnPlaces = new XanderUI.XUIButton();
            this.panelPeople = new System.Windows.Forms.Panel();
            this.btnPhoto = new XanderUI.XUIButton();
            this.btnMusic = new XanderUI.XUIButton();
            this.btnTamoda = new XanderUI.XUIButton();
            this.btnPeople = new XanderUI.XUIButton();
            this.btnEvent = new XanderUI.XUIButton();
            this.panelLogo = new XanderUI.XUICustomGroupbox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.SearchD = new XanderUI.XUIButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxChooseResource = new System.Windows.Forms.ComboBox();
            this.searchBox = new MetroFramework.Controls.MetroTextBox();
            this.btnChangeElem = new XanderUI.XUIButton();
            this.btnDeleteElem = new XanderUI.XUIButton();
            this.btnAddElem = new XanderUI.XUIButton();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeBtn = new XanderUI.XUIButton();
            this.closeBtn = new XanderUI.XUIButton();
            this.maximizeBtn = new XanderUI.XUIButton();
            this.panelTop = new XanderUI.XUICustomGroupbox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMain)).BeginInit();
            this.panelSide.SuspendLayout();
            this.panelDecoration.SuspendLayout();
            this.panelPeople.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGridMain
            // 
            this.metroGridMain.AllowUserToAddRows = false;
            this.metroGridMain.AllowUserToDeleteRows = false;
            this.metroGridMain.AllowUserToResizeRows = false;
            this.metroGridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.metroGridMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(113)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(125)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameEvent,
            this.Client,
            this.DateEvent,
            this.Phone,
            this.Buddget,
            this.CountPeople,
            this.Place,
            this.Category,
            this.RestaurantFood,
            this.Music,
            this.Tamoda,
            this.PhotoMan,
            this.Flowers,
            this.Balls,
            this.Ribbons});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(125)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGridMain.EnableHeadersVisualStyles = false;
            this.metroGridMain.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridMain.Location = new System.Drawing.Point(0, 0);
            this.metroGridMain.MultiSelect = false;
            this.metroGridMain.Name = "metroGridMain";
            this.metroGridMain.ReadOnly = true;
            this.metroGridMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(113)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(125)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridMain.RowHeadersWidth = 47;
            this.metroGridMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridMain.Size = new System.Drawing.Size(771, 483);
            this.metroGridMain.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroGridMain.TabIndex = 4;
            this.metroGridMain.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridMain.UseCustomBackColor = true;
            this.metroGridMain.UseCustomForeColor = true;
            this.metroGridMain.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridMain_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NameEvent
            // 
            this.NameEvent.DataPropertyName = "NameEvent";
            this.NameEvent.HeaderText = "Название Мероприятия";
            this.NameEvent.Name = "NameEvent";
            this.NameEvent.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client";
            this.Client.HeaderText = "Ф.И.О клиента";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // DateEvent
            // 
            this.DateEvent.DataPropertyName = "DateEvent";
            this.DateEvent.HeaderText = "Дата";
            this.DateEvent.Name = "DateEvent";
            this.DateEvent.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Buddget
            // 
            this.Buddget.DataPropertyName = "Buddget";
            this.Buddget.HeaderText = "Стоимость";
            this.Buddget.Name = "Buddget";
            this.Buddget.ReadOnly = true;
            // 
            // CountPeople
            // 
            this.CountPeople.DataPropertyName = "CountPeople";
            this.CountPeople.HeaderText = "Количество людей";
            this.CountPeople.Name = "CountPeople";
            this.CountPeople.ReadOnly = true;
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Place";
            this.Place.HeaderText = "Место";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            this.Place.Visible = false;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Visible = false;
            // 
            // RestaurantFood
            // 
            this.RestaurantFood.DataPropertyName = "RestaurantFood";
            this.RestaurantFood.HeaderText = "Еда";
            this.RestaurantFood.Name = "RestaurantFood";
            this.RestaurantFood.ReadOnly = true;
            this.RestaurantFood.Visible = false;
            // 
            // Music
            // 
            this.Music.DataPropertyName = "Music";
            this.Music.HeaderText = "Музыкант";
            this.Music.Name = "Music";
            this.Music.ReadOnly = true;
            this.Music.Visible = false;
            // 
            // Tamoda
            // 
            this.Tamoda.DataPropertyName = "Tamoda";
            this.Tamoda.HeaderText = "Ведущий";
            this.Tamoda.Name = "Tamoda";
            this.Tamoda.ReadOnly = true;
            this.Tamoda.Visible = false;
            // 
            // PhotoMan
            // 
            this.PhotoMan.DataPropertyName = "PhotoMan";
            this.PhotoMan.HeaderText = " ";
            this.PhotoMan.Name = "PhotoMan";
            this.PhotoMan.ReadOnly = true;
            this.PhotoMan.Visible = false;
            // 
            // Flowers
            // 
            this.Flowers.DataPropertyName = "Flowers";
            this.Flowers.HeaderText = "Цветы";
            this.Flowers.Name = "Flowers";
            this.Flowers.ReadOnly = true;
            this.Flowers.Visible = false;
            // 
            // Balls
            // 
            this.Balls.DataPropertyName = "Balls";
            this.Balls.HeaderText = "Шары";
            this.Balls.Name = "Balls";
            this.Balls.ReadOnly = true;
            this.Balls.Visible = false;
            // 
            // Ribbons
            // 
            this.Ribbons.DataPropertyName = "Ribbons";
            this.Ribbons.HeaderText = "Украшения";
            this.Ribbons.Name = "Ribbons";
            this.Ribbons.ReadOnly = true;
            this.Ribbons.Visible = false;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelSide.Controls.Add(this.panelDecoration);
            this.panelSide.Controls.Add(this.btnResources);
            this.panelSide.Controls.Add(this.btnPlaces);
            this.panelSide.Controls.Add(this.panelPeople);
            this.panelSide.Controls.Add(this.btnPeople);
            this.panelSide.Controls.Add(this.btnEvent);
            this.panelSide.Controls.Add(this.panelLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 36);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(220, 525);
            this.panelSide.TabIndex = 5;
            // 
            // panelDecoration
            // 
            this.panelDecoration.BackColor = System.Drawing.Color.Transparent;
            this.panelDecoration.Controls.Add(this.btnRestaurant);
            this.panelDecoration.Controls.Add(this.btnDecoration);
            this.panelDecoration.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDecoration.Location = new System.Drawing.Point(0, 349);
            this.panelDecoration.Name = "panelDecoration";
            this.panelDecoration.Size = new System.Drawing.Size(220, 93);
            this.panelDecoration.TabIndex = 6;
            // 
            // btnRestaurant
            // 
            this.btnRestaurant.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnRestaurant.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurant.ButtonImage")));
            this.btnRestaurant.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnRestaurant.ButtonText = "Рестараны";
            this.btnRestaurant.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnRestaurant.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnRestaurant.CornerRadius = 5;
            this.btnRestaurant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestaurant.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRestaurant.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnRestaurant.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRestaurant.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRestaurant.Location = new System.Drawing.Point(0, 42);
            this.btnRestaurant.Name = "btnRestaurant";
            this.btnRestaurant.Size = new System.Drawing.Size(220, 44);
            this.btnRestaurant.TabIndex = 11;
            this.btnRestaurant.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnRestaurant.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRestaurant.Click += new System.EventHandler(this.btnRestaurant_Click);
            // 
            // btnDecoration
            // 
            this.btnDecoration.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnDecoration.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnDecoration.ButtonImage")));
            this.btnDecoration.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDecoration.ButtonText = "Украшения";
            this.btnDecoration.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnDecoration.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnDecoration.CornerRadius = 5;
            this.btnDecoration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDecoration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecoration.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDecoration.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDecoration.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDecoration.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDecoration.Location = new System.Drawing.Point(0, 0);
            this.btnDecoration.Name = "btnDecoration";
            this.btnDecoration.Size = new System.Drawing.Size(220, 42);
            this.btnDecoration.TabIndex = 10;
            this.btnDecoration.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnDecoration.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDecoration.Click += new System.EventHandler(this.btnDecoration_Click);
            // 
            // btnResources
            // 
            this.btnResources.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.btnResources.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnResources.ButtonImage")));
            this.btnResources.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnResources.ButtonText = "Ресурсы";
            this.btnResources.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnResources.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnResources.CornerRadius = 5;
            this.btnResources.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResources.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnResources.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnResources.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.btnResources.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnResources.Location = new System.Drawing.Point(0, 305);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(220, 44);
            this.btnResources.TabIndex = 9;
            this.btnResources.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnResources.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // btnPlaces
            // 
            this.btnPlaces.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnPlaces.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPlaces.ButtonImage")));
            this.btnPlaces.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPlaces.ButtonText = "Места";
            this.btnPlaces.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnPlaces.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnPlaces.CornerRadius = 5;
            this.btnPlaces.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlaces.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPlaces.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPlaces.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPlaces.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPlaces.Location = new System.Drawing.Point(0, 261);
            this.btnPlaces.Name = "btnPlaces";
            this.btnPlaces.Size = new System.Drawing.Size(220, 44);
            this.btnPlaces.TabIndex = 8;
            this.btnPlaces.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnPlaces.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPlaces.Click += new System.EventHandler(this.btnPlaces_Click);
            // 
            // panelPeople
            // 
            this.panelPeople.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelPeople.Controls.Add(this.btnPhoto);
            this.panelPeople.Controls.Add(this.btnMusic);
            this.panelPeople.Controls.Add(this.btnTamoda);
            this.panelPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPeople.Location = new System.Drawing.Point(0, 130);
            this.panelPeople.Name = "panelPeople";
            this.panelPeople.Size = new System.Drawing.Size(220, 131);
            this.panelPeople.TabIndex = 6;
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnPhoto.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPhoto.ButtonImage")));
            this.btnPhoto.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPhoto.ButtonText = "    Фотографы";
            this.btnPhoto.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnPhoto.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnPhoto.CornerRadius = 5;
            this.btnPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPhoto.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPhoto.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPhoto.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPhoto.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPhoto.Location = new System.Drawing.Point(0, 86);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(220, 43);
            this.btnPhoto.TabIndex = 13;
            this.btnPhoto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnPhoto.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnMusic.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnMusic.ButtonImage")));
            this.btnMusic.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnMusic.ButtonText = "    Музыканты";
            this.btnMusic.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnMusic.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnMusic.CornerRadius = 5;
            this.btnMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMusic.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMusic.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnMusic.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMusic.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnMusic.Location = new System.Drawing.Point(0, 43);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(220, 43);
            this.btnMusic.TabIndex = 12;
            this.btnMusic.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnMusic.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnTamoda
            // 
            this.btnTamoda.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnTamoda.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnTamoda.ButtonImage")));
            this.btnTamoda.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnTamoda.ButtonText = "    Ведущие";
            this.btnTamoda.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnTamoda.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnTamoda.CornerRadius = 5;
            this.btnTamoda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTamoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTamoda.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTamoda.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnTamoda.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTamoda.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnTamoda.Location = new System.Drawing.Point(0, 0);
            this.btnTamoda.Name = "btnTamoda";
            this.btnTamoda.Size = new System.Drawing.Size(220, 43);
            this.btnTamoda.TabIndex = 14;
            this.btnTamoda.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnTamoda.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTamoda.Click += new System.EventHandler(this.btnTamoda_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.btnPeople.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPeople.ButtonImage")));
            this.btnPeople.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPeople.ButtonText = "Персонал";
            this.btnPeople.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnPeople.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnPeople.CornerRadius = 5;
            this.btnPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPeople.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPeople.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPeople.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPeople.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPeople.Location = new System.Drawing.Point(0, 86);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(220, 44);
            this.btnPeople.TabIndex = 7;
            this.btnPeople.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnPeople.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnEvent.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnEvent.ButtonImage")));
            this.btnEvent.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnEvent.ButtonText = "Мероприятия";
            this.btnEvent.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnEvent.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnEvent.CornerRadius = 5;
            this.btnEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEvent.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEvent.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEvent.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEvent.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEvent.Location = new System.Drawing.Point(0, 42);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(220, 44);
            this.btnEvent.TabIndex = 6;
            this.btnEvent.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnEvent.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BorderColor = System.Drawing.Color.Transparent;
            this.panelLogo.BorderWidth = 1;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.ShowText = false;
            this.panelLogo.Size = new System.Drawing.Size(220, 42);
            this.panelLogo.TabIndex = 5;
            this.panelLogo.TabStop = false;
            this.panelLogo.Text = "xuiCustomGroupbox1";
            this.panelLogo.TextColor = System.Drawing.Color.Transparent;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelButtons.Controls.Add(this.xuiButton1);
            this.panelButtons.Controls.Add(this.SearchD);
            this.panelButtons.Controls.Add(this.dateTimePicker1);
            this.panelButtons.Controls.Add(this.comboBoxChooseResource);
            this.panelButtons.Controls.Add(this.searchBox);
            this.panelButtons.Controls.Add(this.btnChangeElem);
            this.panelButtons.Controls.Add(this.btnDeleteElem);
            this.panelButtons.Controls.Add(this.btnAddElem);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(220, 36);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(771, 42);
            this.panelButtons.TabIndex = 6;
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.BackgroundImage")));
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(509, 6);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(30, 30);
            this.xuiButton1.TabIndex = 7;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // SearchD
            // 
            this.SearchD.BackgroundColor = System.Drawing.Color.Transparent;
            this.SearchD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchD.BackgroundImage")));
            this.SearchD.ButtonImage = null;
            this.SearchD.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.SearchD.ButtonText = "";
            this.SearchD.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.SearchD.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.SearchD.CornerRadius = 5;
            this.SearchD.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SearchD.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.SearchD.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.SearchD.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SearchD.Location = new System.Drawing.Point(473, 5);
            this.SearchD.Name = "SearchD";
            this.SearchD.Size = new System.Drawing.Size(30, 30);
            this.SearchD.TabIndex = 6;
            this.SearchD.TextColor = System.Drawing.Color.DodgerBlue;
            this.SearchD.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SearchD.Click += new System.EventHandler(this.SearchD_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(327, 10);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 3, 6, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 6, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxChooseResource
            // 
            this.comboBoxChooseResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChooseResource.FormattingEnabled = true;
            this.comboBoxChooseResource.Items.AddRange(new object[] {
            "Цветы",
            "Шарики",
            "Ленточки"});
            this.comboBoxChooseResource.Location = new System.Drawing.Point(6, 9);
            this.comboBoxChooseResource.Name = "comboBoxChooseResource";
            this.comboBoxChooseResource.Size = new System.Drawing.Size(168, 24);
            this.comboBoxChooseResource.TabIndex = 4;
            this.comboBoxChooseResource.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseResource_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.searchBox.CustomButton.Image = null;
            this.searchBox.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.searchBox.CustomButton.Name = "";
            this.searchBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchBox.CustomButton.TabIndex = 1;
            this.searchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBox.CustomButton.UseSelectable = true;
            this.searchBox.CustomButton.Visible = false;
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(180, 9);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.Size = new System.Drawing.Size(141, 23);
            this.searchBox.TabIndex = 3;
            this.searchBox.UseSelectable = true;
            this.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // btnChangeElem
            // 
            this.btnChangeElem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeElem.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnChangeElem.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnChangeElem.ButtonImage")));
            this.btnChangeElem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnChangeElem.ButtonText = "";
            this.btnChangeElem.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnChangeElem.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChangeElem.CornerRadius = 5;
            this.btnChangeElem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChangeElem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChangeElem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChangeElem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnChangeElem.Location = new System.Drawing.Point(675, 3);
            this.btnChangeElem.Name = "btnChangeElem";
            this.btnChangeElem.Size = new System.Drawing.Size(38, 36);
            this.btnChangeElem.TabIndex = 2;
            this.btnChangeElem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnChangeElem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChangeElem.Click += new System.EventHandler(this.btnChangeElem_Click);
            // 
            // btnDeleteElem
            // 
            this.btnDeleteElem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteElem.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDeleteElem.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteElem.ButtonImage")));
            this.btnDeleteElem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDeleteElem.ButtonText = "";
            this.btnDeleteElem.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnDeleteElem.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteElem.CornerRadius = 5;
            this.btnDeleteElem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteElem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDeleteElem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteElem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDeleteElem.Location = new System.Drawing.Point(719, 3);
            this.btnDeleteElem.Name = "btnDeleteElem";
            this.btnDeleteElem.Size = new System.Drawing.Size(38, 36);
            this.btnDeleteElem.TabIndex = 1;
            this.btnDeleteElem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteElem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteElem.Click += new System.EventHandler(this.btnDeleteElem_Click);
            // 
            // btnAddElem
            // 
            this.btnAddElem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddElem.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddElem.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAddElem.ButtonImage")));
            this.btnAddElem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAddElem.ButtonText = "";
            this.btnAddElem.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAddElem.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddElem.CornerRadius = 5;
            this.btnAddElem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddElem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAddElem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddElem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddElem.Location = new System.Drawing.Point(631, 3);
            this.btnAddElem.Name = "btnAddElem";
            this.btnAddElem.Size = new System.Drawing.Size(38, 36);
            this.btnAddElem.TabIndex = 0;
            this.btnAddElem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddElem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddElem.Click += new System.EventHandler(this.btnAddElem_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.AutoSize = true;
            this.panelGrid.Controls.Add(this.metroGridMain);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(220, 78);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(771, 483);
            this.panelGrid.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.minimizeBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.maximizeBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 36);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.minimizeBtn.ButtonImage = null;
            this.minimizeBtn.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.minimizeBtn.ButtonText = "";
            this.minimizeBtn.ClickBackColor = System.Drawing.Color.ForestGreen;
            this.minimizeBtn.ClickTextColor = System.Drawing.Color.ForestGreen;
            this.minimizeBtn.CornerRadius = 5;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.minimizeBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.minimizeBtn.HoverBackgroundColor = System.Drawing.Color.ForestGreen;
            this.minimizeBtn.HoverTextColor = System.Drawing.Color.ForestGreen;
            this.minimizeBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.minimizeBtn.Location = new System.Drawing.Point(919, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(15, 15);
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.TextColor = System.Drawing.Color.ForestGreen;
            this.minimizeBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackgroundColor = System.Drawing.Color.Red;
            this.closeBtn.ButtonImage = null;
            this.closeBtn.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.closeBtn.ButtonText = "";
            this.closeBtn.ClickBackColor = System.Drawing.Color.Red;
            this.closeBtn.ClickTextColor = System.Drawing.Color.Red;
            this.closeBtn.CornerRadius = 5;
            this.closeBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.closeBtn.HoverBackgroundColor = System.Drawing.Color.Red;
            this.closeBtn.HoverTextColor = System.Drawing.Color.Red;
            this.closeBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.closeBtn.Location = new System.Drawing.Point(962, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(15, 15);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.TextColor = System.Drawing.Color.Red;
            this.closeBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackgroundColor = System.Drawing.Color.Yellow;
            this.maximizeBtn.ButtonImage = null;
            this.maximizeBtn.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.maximizeBtn.ButtonText = "";
            this.maximizeBtn.ClickBackColor = System.Drawing.Color.Yellow;
            this.maximizeBtn.ClickTextColor = System.Drawing.Color.Yellow;
            this.maximizeBtn.CornerRadius = 5;
            this.maximizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maximizeBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.maximizeBtn.HoverBackgroundColor = System.Drawing.Color.Yellow;
            this.maximizeBtn.HoverTextColor = System.Drawing.Color.Yellow;
            this.maximizeBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.maximizeBtn.Location = new System.Drawing.Point(940, 12);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(15, 15);
            this.maximizeBtn.TabIndex = 3;
            this.maximizeBtn.TextColor = System.Drawing.Color.Yellow;
            this.maximizeBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // panelTop
            // 
            this.panelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelTop.BorderColor = System.Drawing.Color.Transparent;
            this.panelTop.BorderWidth = 0;
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.ShowText = false;
            this.panelTop.Size = new System.Drawing.Size(991, 36);
            this.panelTop.TabIndex = 1;
            this.panelTop.TabStop = false;
            this.panelTop.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(991, 561);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = " ";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMain)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.panelDecoration.ResumeLayout(false);
            this.panelPeople.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid metroGridMain;
        private System.Windows.Forms.Panel panelSide;
        private XanderUI.XUIButton btnEvent;
        private System.Windows.Forms.Panel panelPeople;
        private XanderUI.XUIButton btnMusic;
        private XanderUI.XUIButton btnTamoda;
        private XanderUI.XUIButton btnPhoto;
        private XanderUI.XUIButton btnPeople;
        private XanderUI.XUIButton btnResources;
        private XanderUI.XUIButton btnPlaces;
        private System.Windows.Forms.Panel panelDecoration;
        private XanderUI.XUIButton btnDecoration;
        private XanderUI.XUIButton btnRestaurant;
        private XanderUI.XUICustomGroupbox panelLogo;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelGrid;
        private XanderUI.XUIButton btnChangeElem;
        private XanderUI.XUIButton btnDeleteElem;
        private XanderUI.XUIButton btnAddElem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buddget;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Music;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotoMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flowers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ribbons;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton minimizeBtn;
        private XanderUI.XUIButton closeBtn;
        private XanderUI.XUIButton maximizeBtn;
        private XanderUI.XUICustomGroupbox panelTop;
        private MetroFramework.Controls.MetroTextBox searchBox;
        private System.Windows.Forms.ComboBox comboBoxChooseResource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private XanderUI.XUIButton SearchD;
        private XanderUI.XUIButton xuiButton1;
    }
}

