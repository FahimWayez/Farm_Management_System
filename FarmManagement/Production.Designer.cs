
namespace FarmManagement
{
    partial class Production
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Production));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProdExitLabel = new System.Windows.Forms.Label();
            this.ProdTimeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MPortalHomePanel = new System.Windows.Forms.Panel();
            this.MPortalHomeIcon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.MPortalHomeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProdClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProdDeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProdUpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProdSaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.ProdLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProdDateTimePanel = new System.Windows.Forms.Panel();
            this.ProdDateLabel = new System.Windows.Forms.Label();
            this.ProdTimer1 = new System.Windows.Forms.Timer(this.components);
            this.ProdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SalesDateLabe = new System.Windows.Forms.Label();
            this.ProdTagLabel = new System.Windows.Forms.Label();
            this.ProdDBLabel = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdUPriceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProdTypeOfProductTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProdQuantityTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProdTagComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ProdDatePanel = new System.Windows.Forms.Panel();
            this.ProdSearchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProdRefreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProdDBDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.MPortalHomePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.ProdDateTimePanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.ProdDatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDBDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdExitLabel
            // 
            this.ProdExitLabel.AutoSize = true;
            this.ProdExitLabel.BackColor = System.Drawing.Color.Red;
            this.ProdExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdExitLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ProdExitLabel.Location = new System.Drawing.Point(1034, 0);
            this.ProdExitLabel.Name = "ProdExitLabel";
            this.ProdExitLabel.Size = new System.Drawing.Size(35, 32);
            this.ProdExitLabel.TabIndex = 4;
            this.ProdExitLabel.Text = "X";
            this.ProdExitLabel.Click += new System.EventHandler(this.ProdExitLabel_Click);
            // 
            // ProdTimeLabel
            // 
            this.ProdTimeLabel.AutoSize = true;
            this.ProdTimeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdTimeLabel.Location = new System.Drawing.Point(400, 5);
            this.ProdTimeLabel.Name = "ProdTimeLabel";
            this.ProdTimeLabel.Size = new System.Drawing.Size(108, 26);
            this.ProdTimeLabel.TabIndex = 0;
            this.ProdTimeLabel.Text = "Label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.MPortalHomePanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.AdminLabel);
            this.panel1.Controls.Add(this.ProdLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 730);
            this.panel1.TabIndex = 31;
            // 
            // MPortalHomePanel
            // 
            this.MPortalHomePanel.BackColor = System.Drawing.SystemColors.Control;
            this.MPortalHomePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MPortalHomePanel.Controls.Add(this.MPortalHomeIcon);
            this.MPortalHomePanel.Controls.Add(this.MPortalHomeLabel);
            this.MPortalHomePanel.Location = new System.Drawing.Point(3, 187);
            this.MPortalHomePanel.Name = "MPortalHomePanel";
            this.MPortalHomePanel.Size = new System.Drawing.Size(267, 95);
            this.MPortalHomePanel.TabIndex = 36;
            // 
            // MPortalHomeIcon
            // 
            this.MPortalHomeIcon.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.MPortalHomeIcon.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.MPortalHomeIcon.HoverState.ImageSize = new System.Drawing.Size(170, 100);
            this.MPortalHomeIcon.Image = ((System.Drawing.Image)(resources.GetObject("MPortalHomeIcon.Image")));
            this.MPortalHomeIcon.ImageOffset = new System.Drawing.Point(0, 0);
            this.MPortalHomeIcon.ImageRotate = 0F;
            this.MPortalHomeIcon.ImageSize = new System.Drawing.Size(160, 90);
            this.MPortalHomeIcon.IndicateFocus = true;
            this.MPortalHomeIcon.Location = new System.Drawing.Point(-2, -2);
            this.MPortalHomeIcon.Name = "MPortalHomeIcon";
            this.MPortalHomeIcon.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.MPortalHomeIcon.PressedState.ImageSize = new System.Drawing.Size(150, 80);
            this.MPortalHomeIcon.Size = new System.Drawing.Size(160, 90);
            this.MPortalHomeIcon.TabIndex = 18;
            this.MPortalHomeIcon.Click += new System.EventHandler(this.MPortalHomeIcon_Click_1);
            // 
            // MPortalHomeLabel
            // 
            this.MPortalHomeLabel.AutoSize = true;
            this.MPortalHomeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPortalHomeLabel.Location = new System.Drawing.Point(176, 32);
            this.MPortalHomeLabel.Name = "MPortalHomeLabel";
            this.MPortalHomeLabel.Size = new System.Drawing.Size(85, 26);
            this.MPortalHomeLabel.TabIndex = 1;
            this.MPortalHomeLabel.Text = "Home";
            this.MPortalHomeLabel.Click += new System.EventHandler(this.MPortalHomeLabel_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProdClearButton);
            this.panel3.Controls.Add(this.ProdDeleteButton);
            this.panel3.Controls.Add(this.ProdUpdateButton);
            this.panel3.Controls.Add(this.ProdSaveButton);
            this.panel3.Location = new System.Drawing.Point(3, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 217);
            this.panel3.TabIndex = 35;
            // 
            // ProdClearButton
            // 
            this.ProdClearButton.Animated = true;
            this.ProdClearButton.AutoRoundedCorners = true;
            this.ProdClearButton.BackColor = System.Drawing.Color.Transparent;
            this.ProdClearButton.BorderRadius = 18;
            this.ProdClearButton.BorderThickness = 3;
            this.ProdClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProdClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProdClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProdClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProdClearButton.FillColor = System.Drawing.SystemColors.Control;
            this.ProdClearButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.ProdClearButton.ForeColor = System.Drawing.Color.Black;
            this.ProdClearButton.Location = new System.Drawing.Point(62, 152);
            this.ProdClearButton.Name = "ProdClearButton";
            this.ProdClearButton.Size = new System.Drawing.Size(150, 38);
            this.ProdClearButton.TabIndex = 28;
            this.ProdClearButton.Text = "Clear";
            this.ProdClearButton.UseTransparentBackground = true;
            this.ProdClearButton.Click += new System.EventHandler(this.ProdClearButton_Click);
            // 
            // ProdDeleteButton
            // 
            this.ProdDeleteButton.Animated = true;
            this.ProdDeleteButton.AutoRoundedCorners = true;
            this.ProdDeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.ProdDeleteButton.BorderRadius = 18;
            this.ProdDeleteButton.BorderThickness = 3;
            this.ProdDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProdDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProdDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProdDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProdDeleteButton.FillColor = System.Drawing.SystemColors.Control;
            this.ProdDeleteButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.ProdDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.ProdDeleteButton.Location = new System.Drawing.Point(62, 108);
            this.ProdDeleteButton.Name = "ProdDeleteButton";
            this.ProdDeleteButton.Size = new System.Drawing.Size(150, 38);
            this.ProdDeleteButton.TabIndex = 27;
            this.ProdDeleteButton.Text = "Delete";
            this.ProdDeleteButton.UseTransparentBackground = true;
            this.ProdDeleteButton.Click += new System.EventHandler(this.ProdDeleteButton_Click);
            // 
            // ProdUpdateButton
            // 
            this.ProdUpdateButton.Animated = true;
            this.ProdUpdateButton.AutoRoundedCorners = true;
            this.ProdUpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.ProdUpdateButton.BorderRadius = 18;
            this.ProdUpdateButton.BorderThickness = 3;
            this.ProdUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProdUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProdUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProdUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProdUpdateButton.FillColor = System.Drawing.SystemColors.Control;
            this.ProdUpdateButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.ProdUpdateButton.ForeColor = System.Drawing.Color.Black;
            this.ProdUpdateButton.Location = new System.Drawing.Point(62, 64);
            this.ProdUpdateButton.Name = "ProdUpdateButton";
            this.ProdUpdateButton.Size = new System.Drawing.Size(150, 38);
            this.ProdUpdateButton.TabIndex = 26;
            this.ProdUpdateButton.Text = "Update";
            this.ProdUpdateButton.UseTransparentBackground = true;
            this.ProdUpdateButton.Click += new System.EventHandler(this.ProdUpdateButton_Click);
            // 
            // ProdSaveButton
            // 
            this.ProdSaveButton.Animated = true;
            this.ProdSaveButton.AutoRoundedCorners = true;
            this.ProdSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.ProdSaveButton.BorderRadius = 18;
            this.ProdSaveButton.BorderThickness = 3;
            this.ProdSaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProdSaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProdSaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProdSaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProdSaveButton.FillColor = System.Drawing.SystemColors.Control;
            this.ProdSaveButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.ProdSaveButton.ForeColor = System.Drawing.Color.Black;
            this.ProdSaveButton.Location = new System.Drawing.Point(62, 20);
            this.ProdSaveButton.Name = "ProdSaveButton";
            this.ProdSaveButton.Size = new System.Drawing.Size(150, 38);
            this.ProdSaveButton.TabIndex = 25;
            this.ProdSaveButton.Text = "Save";
            this.ProdSaveButton.UseTransparentBackground = true;
            this.ProdSaveButton.Click += new System.EventHandler(this.ProdSaveButton_Click);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.BackColor = System.Drawing.Color.Azure;
            this.AdminLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.Location = new System.Drawing.Point(94, 682);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(104, 26);
            this.AdminLabel.TabIndex = 2;
            this.AdminLabel.Text = "ADMIN";
            // 
            // ProdLogo
            // 
            this.ProdLogo.Image = ((System.Drawing.Image)(resources.GetObject("ProdLogo.Image")));
            this.ProdLogo.Location = new System.Drawing.Point(0, 0);
            this.ProdLogo.Name = "ProdLogo";
            this.ProdLogo.Size = new System.Drawing.Size(280, 183);
            this.ProdLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProdLogo.TabIndex = 0;
            this.ProdLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.ProdDateTimePanel);
            this.panel2.Controls.Add(this.ProdExitLabel);
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 55);
            this.panel2.TabIndex = 32;
            // 
            // ProdDateTimePanel
            // 
            this.ProdDateTimePanel.BackColor = System.Drawing.Color.Azure;
            this.ProdDateTimePanel.Controls.Add(this.ProdDateLabel);
            this.ProdDateTimePanel.Controls.Add(this.ProdTimeLabel);
            this.ProdDateTimePanel.Location = new System.Drawing.Point(10, 11);
            this.ProdDateTimePanel.Name = "ProdDateTimePanel";
            this.ProdDateTimePanel.Size = new System.Drawing.Size(1004, 33);
            this.ProdDateTimePanel.TabIndex = 6;
            // 
            // ProdDateLabel
            // 
            this.ProdDateLabel.AutoSize = true;
            this.ProdDateLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDateLabel.Location = new System.Drawing.Point(5, 5);
            this.ProdDateLabel.Name = "ProdDateLabel";
            this.ProdDateLabel.Size = new System.Drawing.Size(108, 26);
            this.ProdDateLabel.TabIndex = 1;
            this.ProdDateLabel.Text = "Label2";
            // 
            // ProdTimer1
            // 
            this.ProdTimer1.Tick += new System.EventHandler(this.ProdTimer1_Tick);
            // 
            // ProdDateTimePicker
            // 
            this.ProdDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.ProdDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.ProdDateTimePicker.CustomFormat = "";
            this.ProdDateTimePicker.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDateTimePicker.Location = new System.Drawing.Point(2, 33);
            this.ProdDateTimePicker.Name = "ProdDateTimePicker";
            this.ProdDateTimePicker.Size = new System.Drawing.Size(336, 26);
            this.ProdDateTimePicker.TabIndex = 15;
            this.ProdDateTimePicker.Tag = "0";
            // 
            // SalesDateLabe
            // 
            this.SalesDateLabe.AutoSize = true;
            this.SalesDateLabe.Location = new System.Drawing.Point(133, 4);
            this.SalesDateLabe.Name = "SalesDateLabe";
            this.SalesDateLabe.Size = new System.Drawing.Size(78, 26);
            this.SalesDateLabe.TabIndex = 14;
            this.SalesDateLabe.Text = "Date";
            // 
            // ProdTagLabel
            // 
            this.ProdTagLabel.AutoSize = true;
            this.ProdTagLabel.Location = new System.Drawing.Point(130, 12);
            this.ProdTagLabel.Name = "ProdTagLabel";
            this.ProdTagLabel.Size = new System.Drawing.Size(62, 26);
            this.ProdTagLabel.TabIndex = 12;
            this.ProdTagLabel.Text = "Tag";
            // 
            // ProdDBLabel
            // 
            this.ProdDBLabel.AutoSize = true;
            this.ProdDBLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProdDBLabel.Location = new System.Drawing.Point(662, 297);
            this.ProdDBLabel.Name = "ProdDBLabel";
            this.ProdDBLabel.Size = new System.Drawing.Size(280, 28);
            this.ProdDBLabel.TabIndex = 2;
            this.ProdDBLabel.Text = "Production Details";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.ProdUPriceTB);
            this.panel10.Controls.Add(this.ProdTypeOfProductTB);
            this.panel10.Controls.Add(this.ProdQuantityTB);
            this.panel10.Controls.Add(this.ProdTagLabel);
            this.panel10.Controls.Add(this.ProdTagComboBox);
            this.panel10.Controls.Add(this.ProdDatePanel);
            this.panel10.Controls.Add(this.ProdSearchTB);
            this.panel10.Location = new System.Drawing.Point(291, 62);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1047, 223);
            this.panel10.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "Type of Product";
            // 
            // ProdUPriceTB
            // 
            this.ProdUPriceTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdUPriceTB.Animated = true;
            this.ProdUPriceTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.ProdUPriceTB.BorderThickness = 3;
            this.ProdUPriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdUPriceTB.DefaultText = "";
            this.ProdUPriceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdUPriceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdUPriceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdUPriceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdUPriceTB.FillColor = System.Drawing.SystemColors.Control;
            this.ProdUPriceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdUPriceTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.ProdUPriceTB.ForeColor = System.Drawing.Color.Black;
            this.ProdUPriceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdUPriceTB.Location = new System.Drawing.Point(371, 103);
            this.ProdUPriceTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ProdUPriceTB.Name = "ProdUPriceTB";
            this.ProdUPriceTB.PasswordChar = '\0';
            this.ProdUPriceTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.ProdUPriceTB.PlaceholderText = "Unit Price";
            this.ProdUPriceTB.SelectedText = "";
            this.ProdUPriceTB.Size = new System.Drawing.Size(300, 36);
            this.ProdUPriceTB.TabIndex = 38;
            this.ProdUPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProdTypeOfProductTB
            // 
            this.ProdTypeOfProductTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdTypeOfProductTB.Animated = true;
            this.ProdTypeOfProductTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.ProdTypeOfProductTB.BorderThickness = 3;
            this.ProdTypeOfProductTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdTypeOfProductTB.DefaultText = "Milk";
            this.ProdTypeOfProductTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdTypeOfProductTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdTypeOfProductTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdTypeOfProductTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdTypeOfProductTB.FillColor = System.Drawing.SystemColors.Control;
            this.ProdTypeOfProductTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdTypeOfProductTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.ProdTypeOfProductTB.ForeColor = System.Drawing.Color.Black;
            this.ProdTypeOfProductTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdTypeOfProductTB.Location = new System.Drawing.Point(371, 41);
            this.ProdTypeOfProductTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ProdTypeOfProductTB.Name = "ProdTypeOfProductTB";
            this.ProdTypeOfProductTB.PasswordChar = '\0';
            this.ProdTypeOfProductTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.ProdTypeOfProductTB.PlaceholderText = "";
            this.ProdTypeOfProductTB.ReadOnly = true;
            this.ProdTypeOfProductTB.SelectedText = "";
            this.ProdTypeOfProductTB.Size = new System.Drawing.Size(300, 36);
            this.ProdTypeOfProductTB.TabIndex = 37;
            this.ProdTypeOfProductTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProdQuantityTB
            // 
            this.ProdQuantityTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdQuantityTB.Animated = true;
            this.ProdQuantityTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.ProdQuantityTB.BorderThickness = 3;
            this.ProdQuantityTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdQuantityTB.DefaultText = "";
            this.ProdQuantityTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdQuantityTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdQuantityTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdQuantityTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdQuantityTB.FillColor = System.Drawing.SystemColors.Control;
            this.ProdQuantityTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdQuantityTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.ProdQuantityTB.ForeColor = System.Drawing.Color.Black;
            this.ProdQuantityTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdQuantityTB.Location = new System.Drawing.Point(742, 41);
            this.ProdQuantityTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ProdQuantityTB.Name = "ProdQuantityTB";
            this.ProdQuantityTB.PasswordChar = '\0';
            this.ProdQuantityTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.ProdQuantityTB.PlaceholderText = "Quantity";
            this.ProdQuantityTB.SelectedText = "";
            this.ProdQuantityTB.Size = new System.Drawing.Size(300, 36);
            this.ProdQuantityTB.TabIndex = 35;
            this.ProdQuantityTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProdTagComboBox
            // 
            this.ProdTagComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ProdTagComboBox.BorderColor = System.Drawing.Color.SkyBlue;
            this.ProdTagComboBox.BorderThickness = 3;
            this.ProdTagComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProdTagComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProdTagComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdTagComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdTagComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProdTagComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ProdTagComboBox.ItemHeight = 30;
            this.ProdTagComboBox.Location = new System.Drawing.Point(31, 41);
            this.ProdTagComboBox.Name = "ProdTagComboBox";
            this.ProdTagComboBox.Size = new System.Drawing.Size(249, 36);
            this.ProdTagComboBox.TabIndex = 36;
            // 
            // ProdDatePanel
            // 
            this.ProdDatePanel.Controls.Add(this.ProdDateTimePicker);
            this.ProdDatePanel.Controls.Add(this.SalesDateLabe);
            this.ProdDatePanel.Location = new System.Drawing.Point(10, 155);
            this.ProdDatePanel.Name = "ProdDatePanel";
            this.ProdDatePanel.Size = new System.Drawing.Size(339, 59);
            this.ProdDatePanel.TabIndex = 16;
            // 
            // ProdSearchTB
            // 
            this.ProdSearchTB.AcceptsTab = true;
            this.ProdSearchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdSearchTB.Animated = true;
            this.ProdSearchTB.AutoRoundedCorners = true;
            this.ProdSearchTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.ProdSearchTB.BorderRadius = 26;
            this.ProdSearchTB.BorderThickness = 3;
            this.ProdSearchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdSearchTB.DefaultText = "";
            this.ProdSearchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdSearchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdSearchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdSearchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdSearchTB.FillColor = System.Drawing.SystemColors.Control;
            this.ProdSearchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdSearchTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.ProdSearchTB.ForeColor = System.Drawing.Color.Black;
            this.ProdSearchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdSearchTB.Location = new System.Drawing.Point(470, 159);
            this.ProdSearchTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ProdSearchTB.Name = "ProdSearchTB";
            this.ProdSearchTB.PasswordChar = '\0';
            this.ProdSearchTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.ProdSearchTB.PlaceholderText = "Search by Tag";
            this.ProdSearchTB.SelectedText = "";
            this.ProdSearchTB.Size = new System.Drawing.Size(572, 55);
            this.ProdSearchTB.TabIndex = 36;
            this.ProdSearchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProdSearchTB.TextChanged += new System.EventHandler(this.ProdSearchTB_TextChanged);
            // 
            // ProdRefreshButton
            // 
            this.ProdRefreshButton.Animated = true;
            this.ProdRefreshButton.AutoRoundedCorners = true;
            this.ProdRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.ProdRefreshButton.BorderRadius = 14;
            this.ProdRefreshButton.BorderThickness = 1;
            this.ProdRefreshButton.DefaultAutoSize = true;
            this.ProdRefreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProdRefreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProdRefreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProdRefreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProdRefreshButton.FillColor = System.Drawing.SystemColors.Control;
            this.ProdRefreshButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F);
            this.ProdRefreshButton.ForeColor = System.Drawing.Color.Black;
            this.ProdRefreshButton.IndicateFocus = true;
            this.ProdRefreshButton.Location = new System.Drawing.Point(1224, 291);
            this.ProdRefreshButton.Name = "ProdRefreshButton";
            this.ProdRefreshButton.Size = new System.Drawing.Size(114, 31);
            this.ProdRefreshButton.TabIndex = 37;
            this.ProdRefreshButton.Text = "Refresh";
            this.ProdRefreshButton.UseTransparentBackground = true;
            this.ProdRefreshButton.Click += new System.EventHandler(this.ProdRefreshButton_Click);
            // 
            // ProdDBDataGrid
            // 
            this.ProdDBDataGrid.AllowUserToAddRows = false;
            this.ProdDBDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.ProdDBDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdDBDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProdDBDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDBDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProdDBDataGrid.ColumnHeadersHeight = 54;
            this.ProdDBDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProdDBDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdID,
            this.Tag,
            this.TypeOfProduct,
            this.Quantity,
            this.UnitPrice,
            this.Date,
            this.ExpiryDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDBDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProdDBDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDBDataGrid.Location = new System.Drawing.Point(291, 328);
            this.ProdDBDataGrid.Name = "ProdDBDataGrid";
            this.ProdDBDataGrid.ReadOnly = true;
            this.ProdDBDataGrid.RowHeadersVisible = false;
            this.ProdDBDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.ProdDBDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProdDBDataGrid.RowTemplate.Height = 24;
            this.ProdDBDataGrid.Size = new System.Drawing.Size(1047, 390);
            this.ProdDBDataGrid.TabIndex = 2;
            this.ProdDBDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDBDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProdDBDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProdDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProdDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProdDBDataGrid.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.ProdDBDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDBDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProdDBDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.ProdDBDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDBDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProdDBDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProdDBDataGrid.ThemeStyle.HeaderStyle.Height = 54;
            this.ProdDBDataGrid.ThemeStyle.ReadOnly = true;
            this.ProdDBDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDBDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdDBDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDBDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdDBDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.ProdDBDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDBDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdDBDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDBDataGrid_CellContentClick);
            // 
            // ProdID
            // 
            this.ProdID.DataPropertyName = "ProdID";
            this.ProdID.HeaderText = "ID";
            this.ProdID.MinimumWidth = 6;
            this.ProdID.Name = "ProdID";
            this.ProdID.ReadOnly = true;
            this.ProdID.Visible = false;
            // 
            // Tag
            // 
            this.Tag.DataPropertyName = "Tag";
            this.Tag.HeaderText = "Tag";
            this.Tag.MinimumWidth = 6;
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
            // 
            // TypeOfProduct
            // 
            this.TypeOfProduct.DataPropertyName = "TypeOfProduct";
            this.TypeOfProduct.HeaderText = "Type of Product";
            this.TypeOfProduct.MinimumWidth = 6;
            this.TypeOfProduct.Name = "TypeOfProduct";
            this.TypeOfProduct.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date of Production";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.DataPropertyName = "EDate";
            this.ExpiryDate.HeaderText = "Date of Expiration";
            this.ExpiryDate.MinimumWidth = 6;
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // Production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.ProdDBDataGrid);
            this.Controls.Add(this.ProdRefreshButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProdDBLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel10);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Production";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production";
            this.Load += new System.EventHandler(this.Production_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MPortalHomePanel.ResumeLayout(false);
            this.MPortalHomePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProdLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ProdDateTimePanel.ResumeLayout(false);
            this.ProdDateTimePanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ProdDatePanel.ResumeLayout(false);
            this.ProdDatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDBDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProdExitLabel;
        private System.Windows.Forms.Label ProdTimeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.PictureBox ProdLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ProdDateTimePanel;
        private System.Windows.Forms.Label ProdDateLabel;
        private System.Windows.Forms.Timer ProdTimer1;
        private System.Windows.Forms.DateTimePicker ProdDateTimePicker;
        private System.Windows.Forms.Label SalesDateLabe;
        private System.Windows.Forms.Label ProdTagLabel;
        private System.Windows.Forms.Label ProdDBLabel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel ProdDatePanel;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button ProdClearButton;
        private Guna.UI2.WinForms.Guna2Button ProdDeleteButton;
        private Guna.UI2.WinForms.Guna2Button ProdUpdateButton;
        private Guna.UI2.WinForms.Guna2Button ProdSaveButton;
        private Guna.UI2.WinForms.Guna2TextBox ProdQuantityTB;
        private Guna.UI2.WinForms.Guna2TextBox ProdSearchTB;
        private Guna.UI2.WinForms.Guna2Button ProdRefreshButton;
        private Guna.UI2.WinForms.Guna2ComboBox ProdTagComboBox;
        private Guna.UI2.WinForms.Guna2DataGridView ProdDBDataGrid;
        private Guna.UI2.WinForms.Guna2TextBox ProdTypeOfProductTB;
        private System.Windows.Forms.Panel MPortalHomePanel;
        private Guna.UI2.WinForms.Guna2ImageButton MPortalHomeIcon;
        private System.Windows.Forms.Label MPortalHomeLabel;
        private Guna.UI2.WinForms.Guna2TextBox ProdUPriceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
    }
}