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
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.xuiCustomGroupbox4 = new XanderUI.XUICustomGroupbox();
            this.dragbtn = new XanderUI.XUIButton();
            this.foodbtn = new XanderUI.XUIButton();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.placebtn = new XanderUI.XUIButton();
            this.eventbtn = new XanderUI.XUIButton();
            this.leaderbtn = new XanderUI.XUIButton();
            this.photographbtn = new XanderUI.XUIButton();
            this.musicbtn = new XanderUI.XUIButton();
            this.personbtn = new XanderUI.XUIButton();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiCustomGroupbox3 = new XanderUI.XUICustomGroupbox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
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
            this.xuiCustomGroupbox1.SuspendLayout();
            this.xuiCustomGroupbox4.SuspendLayout();
            this.xuiCustomGroupbox2.SuspendLayout();
            this.xuiCustomGroupbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.Transparent;
            this.xuiCustomGroupbox1.BorderWidth = 0;
            this.xuiCustomGroupbox1.Controls.Add(this.xuiCustomGroupbox4);
            this.xuiCustomGroupbox1.Controls.Add(this.placebtn);
            this.xuiCustomGroupbox1.Controls.Add(this.eventbtn);
            this.xuiCustomGroupbox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(3, 32);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(208, 411);
            this.xuiCustomGroupbox1.TabIndex = 0;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // xuiCustomGroupbox4
            // 
            this.xuiCustomGroupbox4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.xuiCustomGroupbox4.BorderColor = System.Drawing.Color.Transparent;
            this.xuiCustomGroupbox4.BorderWidth = 1;
            this.xuiCustomGroupbox4.Controls.Add(this.dragbtn);
            this.xuiCustomGroupbox4.Controls.Add(this.foodbtn);
            this.xuiCustomGroupbox4.Controls.Add(this.xuiButton5);
            this.xuiCustomGroupbox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xuiCustomGroupbox4.Location = new System.Drawing.Point(0, 129);
            this.xuiCustomGroupbox4.Name = "xuiCustomGroupbox4";
            this.xuiCustomGroupbox4.ShowText = true;
            this.xuiCustomGroupbox4.Size = new System.Drawing.Size(208, 38);
            this.xuiCustomGroupbox4.TabIndex = 3;
            this.xuiCustomGroupbox4.TabStop = false;
            this.xuiCustomGroupbox4.TextColor = System.Drawing.Color.Transparent;
            // 
            // dragbtn
            // 
            this.dragbtn.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dragbtn.ButtonImage = global::EventApp.Properties.Resources.hiclipart_com;
            this.dragbtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.dragbtn.ButtonText = "Украшения";
            this.dragbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.dragbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.dragbtn.CornerRadius = 5;
            this.dragbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dragbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.dragbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.dragbtn.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.dragbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.dragbtn.Location = new System.Drawing.Point(0, 47);
            this.dragbtn.Name = "dragbtn";
            this.dragbtn.Size = new System.Drawing.Size(208, 41);
            this.dragbtn.TabIndex = 2;
            this.dragbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.dragbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.dragbtn.MouseLeave += new System.EventHandler(this.dragbtn_MouseLeave);
            // 
            // foodbtn
            // 
            this.foodbtn.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.foodbtn.ButtonImage = global::EventApp.Properties.Resources.hiclipart_com;
            this.foodbtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.foodbtn.ButtonText = "Еда";
            this.foodbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.foodbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.foodbtn.CornerRadius = 5;
            this.foodbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.foodbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.foodbtn.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.foodbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.foodbtn.Location = new System.Drawing.Point(0, 94);
            this.foodbtn.Name = "foodbtn";
            this.foodbtn.Size = new System.Drawing.Size(208, 41);
            this.foodbtn.TabIndex = 2;
            this.foodbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.foodbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.foodbtn.MouseLeave += new System.EventHandler(this.foodbtn_MouseLeave);
            // 
            // xuiButton5
            // 
            this.xuiButton5.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.xuiButton5.ButtonImage = global::EventApp.Properties.Resources.hiclipart_com;
            this.xuiButton5.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.xuiButton5.ButtonText = "Ресурсы";
            this.xuiButton5.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton5.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton5.CornerRadius = 5;
            this.xuiButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.xuiButton5.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.xuiButton5.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton5.Location = new System.Drawing.Point(0, 0);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(208, 41);
            this.xuiButton5.TabIndex = 2;
            this.xuiButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.xuiButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.xuiButton5_MouseMove);
            // 
            // placebtn
            // 
            this.placebtn.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.placebtn.ButtonImage = global::EventApp.Properties.Resources.hiclipart_com;
            this.placebtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.placebtn.ButtonText = "Места";
            this.placebtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.placebtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.placebtn.CornerRadius = 5;
            this.placebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placebtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.placebtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.placebtn.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.placebtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.placebtn.Location = new System.Drawing.Point(0, 84);
            this.placebtn.Name = "placebtn";
            this.placebtn.Size = new System.Drawing.Size(208, 41);
            this.placebtn.TabIndex = 2;
            this.placebtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.placebtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // eventbtn
            // 
            this.eventbtn.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.eventbtn.ButtonImage = global::EventApp.Properties.Resources.hiclipart_com;
            this.eventbtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.eventbtn.ButtonText = "Мероприятия";
            this.eventbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.eventbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.eventbtn.CornerRadius = 5;
            this.eventbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.eventbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.eventbtn.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.eventbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.eventbtn.Location = new System.Drawing.Point(0, 0);
            this.eventbtn.Name = "eventbtn";
            this.eventbtn.Size = new System.Drawing.Size(208, 41);
            this.eventbtn.TabIndex = 2;
            this.eventbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.eventbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.eventbtn.Click += new System.EventHandler(this.eventbtn_Click);
            // 
            // leaderbtn
            // 
            this.leaderbtn.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.leaderbtn.ButtonImage = global::EventApp.Properties.Resources.hiclipart_com;
            this.leaderbtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.leaderbtn.ButtonText = "Ведущие";
            this.leaderbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.leaderbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.leaderbtn.CornerRadius = 5;
            this.leaderbtn.Enabled = false;
            this.leaderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.leaderbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.leaderbtn.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.leaderbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.leaderbtn.Location = new System.Drawing.Point(0, 130);
            this.leaderbtn.Name = "leaderbtn";
            this.leaderbtn.Size = new System.Drawing.Size(208, 41);
            this.leaderbtn.TabIndex = 2;
            this.leaderbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.leaderbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.leaderbtn.Visible = false;
            this.leaderbtn.MouseLeave += new System.EventHandler(this.leaderbtn_MouseLeave);
            this.leaderbtn.MouseHover += new System.EventHandler(this.leaderbtn_MouseHover);
            this.leaderbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.leaderbtn_MouseMove);
            // 
            // photographbtn
            // 
            this.photographbtn.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.photographbtn.ButtonImage = global::EventApp.Properties.Resources.hiclipart_com;
            this.photographbtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.photographbtn.ButtonText = "Фотографы";
            this.photographbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.photographbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.photographbtn.CornerRadius = 5;
            this.photographbtn.Enabled = false;
            this.photographbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photographbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.photographbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.photographbtn.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.photographbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.photographbtn.Location = new System.Drawing.Point(-1, 87);
            this.photographbtn.Name = "photographbtn";
            this.photographbtn.Size = new System.Drawing.Size(208, 41);
            this.photographbtn.TabIndex = 2;
            this.photographbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.photographbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.photographbtn.Visible = false;
            this.photographbtn.Click += new System.EventHandler(this.photographbtn_Click);
            this.photographbtn.MouseLeave += new System.EventHandler(this.photographbtn_MouseLeave);
            this.photographbtn.MouseHover += new System.EventHandler(this.photographbtn_MouseHover);
            this.photographbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.photographbtn_MouseMove);
            // 
            // musicbtn
            // 
            this.musicbtn.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.musicbtn.ButtonImage = global::EventApp.Properties.Resources.hiclipart_com;
            this.musicbtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.musicbtn.ButtonText = "Музыканты";
            this.musicbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.musicbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.musicbtn.CornerRadius = 5;
            this.musicbtn.Enabled = false;
            this.musicbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.musicbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.musicbtn.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.musicbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.musicbtn.Location = new System.Drawing.Point(0, 45);
            this.musicbtn.Name = "musicbtn";
            this.musicbtn.Size = new System.Drawing.Size(208, 41);
            this.musicbtn.TabIndex = 2;
            this.musicbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.musicbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.musicbtn.Visible = false;
            this.musicbtn.Click += new System.EventHandler(this.musicbtn_Click);
            this.musicbtn.MouseLeave += new System.EventHandler(this.musicbtn_MouseLeave);
            this.musicbtn.MouseHover += new System.EventHandler(this.musicbtn_MouseHover);
            this.musicbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.musicbtn_MouseMove);
            // 
            // personbtn
            // 
            this.personbtn.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.personbtn.ButtonImage = global::EventApp.Properties.Resources.hiclipart_com;
            this.personbtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.personbtn.ButtonText = "Персонал";
            this.personbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.personbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.personbtn.CornerRadius = 5;
            this.personbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.personbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.personbtn.HoverTextColor = System.Drawing.Color.DarkSlateBlue;
            this.personbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.personbtn.Location = new System.Drawing.Point(0, 2);
            this.personbtn.Name = "personbtn";
            this.personbtn.Size = new System.Drawing.Size(208, 41);
            this.personbtn.TabIndex = 2;
            this.personbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.personbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.personbtn.Click += new System.EventHandler(this.personbtn_Click);
            this.personbtn.MouseHover += new System.EventHandler(this.personbtn_MouseHover);
            this.personbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.personbtn_MouseMove);
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.Transparent;
            this.xuiCustomGroupbox2.BorderWidth = 0;
            this.xuiCustomGroupbox2.Controls.Add(this.xuiButton3);
            this.xuiCustomGroupbox2.Controls.Add(this.xuiButton1);
            this.xuiCustomGroupbox2.Controls.Add(this.xuiButton2);
            this.xuiCustomGroupbox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(3, 1);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(797, 29);
            this.xuiCustomGroupbox2.TabIndex = 1;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.DodgerBlue;
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
            this.xuiButton3.Location = new System.Drawing.Point(770, 4);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(15, 15);
            this.xuiButton3.TabIndex = 3;
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
            this.xuiButton1.Location = new System.Drawing.Point(740, 4);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(15, 15);
            this.xuiButton1.TabIndex = 3;
            this.xuiButton1.TextColor = System.Drawing.Color.Yellow;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
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
            this.xuiButton2.Location = new System.Drawing.Point(710, 4);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(15, 15);
            this.xuiButton2.TabIndex = 3;
            this.xuiButton2.TextColor = System.Drawing.Color.ForestGreen;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiCustomGroupbox3
            // 
            this.xuiCustomGroupbox3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.xuiCustomGroupbox3.BorderColor = System.Drawing.Color.Transparent;
            this.xuiCustomGroupbox3.BorderWidth = 1;
            this.xuiCustomGroupbox3.Controls.Add(this.leaderbtn);
            this.xuiCustomGroupbox3.Controls.Add(this.photographbtn);
            this.xuiCustomGroupbox3.Controls.Add(this.personbtn);
            this.xuiCustomGroupbox3.Controls.Add(this.musicbtn);
            this.xuiCustomGroupbox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xuiCustomGroupbox3.Location = new System.Drawing.Point(3, 71);
            this.xuiCustomGroupbox3.Name = "xuiCustomGroupbox3";
            this.xuiCustomGroupbox3.ShowText = true;
            this.xuiCustomGroupbox3.Size = new System.Drawing.Size(208, 41);
            this.xuiCustomGroupbox3.TabIndex = 3;
            this.xuiCustomGroupbox3.TabStop = false;
            this.xuiCustomGroupbox3.TextColor = System.Drawing.Color.Transparent;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(226, 71);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(543, 370);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroGrid1.TabIndex = 4;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
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
            this.CountPeople.Visible = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.xuiCustomGroupbox3);
            this.Controls.Add(this.xuiCustomGroupbox2);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.xuiCustomGroupbox4.ResumeLayout(false);
            this.xuiCustomGroupbox4.PerformLayout();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            this.xuiCustomGroupbox3.ResumeLayout(false);
            this.xuiCustomGroupbox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton eventbtn;
        private XanderUI.XUIButton placebtn;
        private XanderUI.XUIButton xuiButton5;
        private XanderUI.XUIButton dragbtn;
        private XanderUI.XUIButton leaderbtn;
        private XanderUI.XUIButton photographbtn;
        private XanderUI.XUIButton musicbtn;
        private XanderUI.XUIButton personbtn;
        private XanderUI.XUIButton foodbtn;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox3;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox4;
        private MetroFramework.Controls.MetroGrid metroGrid1;
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
    }
}

