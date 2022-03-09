namespace EventApp
{
    partial class AccountantForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantForm));
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
            this.btnEvent = new XanderUI.XUIButton();
            this.panelLogo = new XanderUI.XUICustomGroupbox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnWord = new XanderUI.XUIButton();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeBtn = new XanderUI.XUIButton();
            this.closeBtn = new XanderUI.XUIButton();
            this.maximizeBtn = new XanderUI.XUIButton();
            this.panelTop = new XanderUI.XUICustomGroupbox();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.SearchD = new XanderUI.XUIButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMain)).BeginInit();
            this.panelSide.SuspendLayout();
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(113)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(125)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(125)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridMain.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGridMain.EnableHeadersVisualStyles = false;
            this.metroGridMain.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridMain.Location = new System.Drawing.Point(0, 0);
            this.metroGridMain.Name = "metroGridMain";
            this.metroGridMain.ReadOnly = true;
            this.metroGridMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(113)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(125)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGridMain.RowHeadersWidth = 47;
            this.metroGridMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridMain.Size = new System.Drawing.Size(582, 459);
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
            this.panelSide.Controls.Add(this.btnEvent);
            this.panelSide.Controls.Add(this.panelLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 55);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(220, 501);
            this.panelSide.TabIndex = 5;
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
            this.panelButtons.Controls.Add(this.btnWord);
            this.panelButtons.Controls.Add(this.dateTimePicker1);
            this.panelButtons.Controls.Add(this.SearchD);
            this.panelButtons.Controls.Add(this.searchBox);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(220, 55);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(582, 42);
            this.panelButtons.TabIndex = 6;
            // 
            // btnWord
            // 
            this.btnWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWord.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnWord.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnWord.ButtonImage")));
            this.btnWord.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnWord.ButtonText = "";
            this.btnWord.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnWord.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnWord.CornerRadius = 5;
            this.btnWord.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnWord.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnWord.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnWord.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnWord.Location = new System.Drawing.Point(533, 3);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(38, 36);
            this.btnWord.TabIndex = 4;
            this.btnWord.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnWord.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.AutoSize = true;
            this.panelGrid.Controls.Add(this.metroGridMain);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(220, 97);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(582, 459);
            this.panelGrid.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minimizeBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.maximizeBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 36);
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
            this.minimizeBtn.Location = new System.Drawing.Point(732, 12);
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
            this.closeBtn.Location = new System.Drawing.Point(775, 12);
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
            this.maximizeBtn.Location = new System.Drawing.Point(753, 12);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(15, 15);
            this.maximizeBtn.TabIndex = 3;
            this.maximizeBtn.TextColor = System.Drawing.Color.Yellow;
            this.maximizeBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // panelTop
            // 
            this.panelTop.AutoSize = true;
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
            this.panelTop.Size = new System.Drawing.Size(802, 55);
            this.panelTop.TabIndex = 1;
            this.panelTop.TabStop = false;
            this.panelTop.TextColor = System.Drawing.Color.DodgerBlue;
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
            this.xuiButton1.Location = new System.Drawing.Point(337, 5);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(30, 30);
            this.xuiButton1.TabIndex = 11;
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
            this.SearchD.Location = new System.Drawing.Point(301, 4);
            this.SearchD.Name = "SearchD";
            this.SearchD.Size = new System.Drawing.Size(30, 30);
            this.SearchD.TabIndex = 10;
            this.SearchD.TextColor = System.Drawing.Color.DodgerBlue;
            this.SearchD.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SearchD.Click += new System.EventHandler(this.SearchD_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 5, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
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
            this.searchBox.Location = new System.Drawing.Point(8, 8);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.Size = new System.Drawing.Size(141, 23);
            this.searchBox.TabIndex = 8;
            this.searchBox.UseSelectable = true;
            this.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchBox.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(802, 556);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountantForm";
            this.Text = " ";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMain)).EndInit();
            this.panelSide.ResumeLayout(false);
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
        private XanderUI.XUICustomGroupbox panelLogo;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelGrid;
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
        private XanderUI.XUIButton btnWord;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private XanderUI.XUIButton SearchD;
        private MetroFramework.Controls.MetroTextBox searchBox;
    }
}

