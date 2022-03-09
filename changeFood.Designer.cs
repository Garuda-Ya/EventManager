namespace EventApp
{
    partial class changeFood
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
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.changeBtn = new XanderUI.XUIButton();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventManagementDataSet = new EventApp.EventManagementDataSet();
            this.categoryTTableAdapter = new EventApp.EventManagementDataSetTableAdapters.CategoryTTableAdapter();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(900, 32);
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
            this.xuiButton3.Location = new System.Drawing.Point(869, 8);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(14, 15);
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
            this.xuiButton1.Location = new System.Drawing.Point(848, 8);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(14, 15);
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
            this.xuiButton2.Location = new System.Drawing.Point(827, 8);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(14, 15);
            this.xuiButton2.TabIndex = 6;
            this.xuiButton2.TextColor = System.Drawing.Color.ForestGreen;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(287, 163);
            this.nameTextBox.MaxLength = 40;
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(356, 38);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.White;
            this.textBoxPrice.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(287, 261);
            this.textBoxPrice.MaxLength = 10;
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(356, 38);
            this.textBoxPrice.TabIndex = 15;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // changeBtn
            // 
            this.changeBtn.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.changeBtn.ButtonImage = null;
            this.changeBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.changeBtn.ButtonText = "Изменить";
            this.changeBtn.ClickBackColor = System.Drawing.Color.Black;
            this.changeBtn.ClickTextColor = System.Drawing.Color.Black;
            this.changeBtn.CornerRadius = 5;
            this.changeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.changeBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.changeBtn.HoverBackgroundColor = System.Drawing.Color.Black;
            this.changeBtn.HoverTextColor = System.Drawing.Color.White;
            this.changeBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.changeBtn.Location = new System.Drawing.Point(379, 405);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(143, 50);
            this.changeBtn.TabIndex = 39;
            this.changeBtn.TextColor = System.Drawing.Color.Black;
            this.changeBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.changeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(79, 266);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(202, 24);
            this.labelPrice.TabIndex = 54;
            this.labelPrice.Text = "Цена за 1 штуку:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(375, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "Изменение еды";
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
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(162, 164);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(119, 32);
            this.labelName.TabIndex = 58;
            this.labelName.Text = "Название:";
            // 
            // changeFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "changeFood";
            this.Text = "infoForm";
            this.Load += new System.EventHandler(this.addPersonal_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBoxPrice;
        private XanderUI.XUIButton changeBtn;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label1;
        private EventManagementDataSet eventManagementDataSet;
        private System.Windows.Forms.BindingSource categoryTBindingSource;
        private EventManagementDataSetTableAdapters.CategoryTTableAdapter categoryTTableAdapter;
        private System.Windows.Forms.Label labelName;
    }
}