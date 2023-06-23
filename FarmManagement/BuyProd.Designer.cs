
namespace FarmManagement
{
    partial class BuyProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyProd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MPortalHomePanel = new System.Windows.Forms.Panel();
            this.BuyProdHomeIcon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BuyProdHomeLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CPortalLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CPortalDateTimePanel = new System.Windows.Forms.Panel();
            this.BuyProdDateLabel = new System.Windows.Forms.Label();
            this.BuyProdTimeLabel = new System.Windows.Forms.Label();
            this.CPortalLogoutPanel = new System.Windows.Forms.Panel();
            this.BuyProdLogoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.BuyProdLogoutIcon = new System.Windows.Forms.PictureBox();
            this.BuyProdExitLabel = new System.Windows.Forms.Label();
            this.CPortalWelcomeLabel = new System.Windows.Forms.Label();
            this.BuyProdTimer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.BuyProdPaymentTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SalesDateLabe = new System.Windows.Forms.Label();
            this.BuyProdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BuyProdQuantityTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.BuyProdTypeOfProdComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BuyProdPlaceOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.MPortalHomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPortalLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.CPortalDateTimePanel.SuspendLayout();
            this.CPortalLogoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyProdLogoutIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.MPortalHomePanel);
            this.panel1.Controls.Add(this.CustomerLabel);
            this.panel1.Controls.Add(this.CPortalLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 730);
            this.panel1.TabIndex = 9;
            // 
            // MPortalHomePanel
            // 
            this.MPortalHomePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MPortalHomePanel.Controls.Add(this.BuyProdHomeIcon);
            this.MPortalHomePanel.Controls.Add(this.BuyProdHomeLabel);
            this.MPortalHomePanel.Location = new System.Drawing.Point(6, 186);
            this.MPortalHomePanel.Name = "MPortalHomePanel";
            this.MPortalHomePanel.Size = new System.Drawing.Size(267, 95);
            this.MPortalHomePanel.TabIndex = 6;
            // 
            // BuyProdHomeIcon
            // 
            this.BuyProdHomeIcon.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BuyProdHomeIcon.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.BuyProdHomeIcon.HoverState.ImageSize = new System.Drawing.Size(170, 100);
            this.BuyProdHomeIcon.Image = ((System.Drawing.Image)(resources.GetObject("BuyProdHomeIcon.Image")));
            this.BuyProdHomeIcon.ImageOffset = new System.Drawing.Point(0, 0);
            this.BuyProdHomeIcon.ImageRotate = 0F;
            this.BuyProdHomeIcon.ImageSize = new System.Drawing.Size(160, 90);
            this.BuyProdHomeIcon.IndicateFocus = true;
            this.BuyProdHomeIcon.Location = new System.Drawing.Point(-2, -2);
            this.BuyProdHomeIcon.Name = "BuyProdHomeIcon";
            this.BuyProdHomeIcon.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.BuyProdHomeIcon.PressedState.ImageSize = new System.Drawing.Size(170, 100);
            this.BuyProdHomeIcon.Size = new System.Drawing.Size(160, 90);
            this.BuyProdHomeIcon.TabIndex = 18;
            this.BuyProdHomeIcon.Click += new System.EventHandler(this.BuyProdHomeIcon_Click);
            // 
            // BuyProdHomeLabel
            // 
            this.BuyProdHomeLabel.AutoSize = true;
            this.BuyProdHomeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProdHomeLabel.Location = new System.Drawing.Point(176, 32);
            this.BuyProdHomeLabel.Name = "BuyProdHomeLabel";
            this.BuyProdHomeLabel.Size = new System.Drawing.Size(85, 26);
            this.BuyProdHomeLabel.TabIndex = 1;
            this.BuyProdHomeLabel.Text = "Home";
            this.BuyProdHomeLabel.Click += new System.EventHandler(this.BuyProdHomeLabel_Click);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.BackColor = System.Drawing.Color.Azure;
            this.CustomerLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(66, 681);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(146, 26);
            this.CustomerLabel.TabIndex = 2;
            this.CustomerLabel.Text = "Customer";
            // 
            // CPortalLogo
            // 
            this.CPortalLogo.Image = ((System.Drawing.Image)(resources.GetObject("CPortalLogo.Image")));
            this.CPortalLogo.Location = new System.Drawing.Point(0, 0);
            this.CPortalLogo.Name = "CPortalLogo";
            this.CPortalLogo.Size = new System.Drawing.Size(280, 180);
            this.CPortalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CPortalLogo.TabIndex = 0;
            this.CPortalLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.CPortalDateTimePanel);
            this.panel2.Controls.Add(this.CPortalLogoutPanel);
            this.panel2.Controls.Add(this.BuyProdExitLabel);
            this.panel2.Controls.Add(this.CPortalWelcomeLabel);
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 183);
            this.panel2.TabIndex = 10;
            // 
            // CPortalDateTimePanel
            // 
            this.CPortalDateTimePanel.BackColor = System.Drawing.Color.Azure;
            this.CPortalDateTimePanel.Controls.Add(this.BuyProdDateLabel);
            this.CPortalDateTimePanel.Controls.Add(this.BuyProdTimeLabel);
            this.CPortalDateTimePanel.Location = new System.Drawing.Point(3, 102);
            this.CPortalDateTimePanel.Name = "CPortalDateTimePanel";
            this.CPortalDateTimePanel.Size = new System.Drawing.Size(891, 33);
            this.CPortalDateTimePanel.TabIndex = 6;
            // 
            // BuyProdDateLabel
            // 
            this.BuyProdDateLabel.AutoSize = true;
            this.BuyProdDateLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProdDateLabel.Location = new System.Drawing.Point(5, 5);
            this.BuyProdDateLabel.Name = "BuyProdDateLabel";
            this.BuyProdDateLabel.Size = new System.Drawing.Size(108, 26);
            this.BuyProdDateLabel.TabIndex = 1;
            this.BuyProdDateLabel.Text = "Label2";
            // 
            // BuyProdTimeLabel
            // 
            this.BuyProdTimeLabel.AutoSize = true;
            this.BuyProdTimeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProdTimeLabel.Location = new System.Drawing.Point(400, 5);
            this.BuyProdTimeLabel.Name = "BuyProdTimeLabel";
            this.BuyProdTimeLabel.Size = new System.Drawing.Size(108, 26);
            this.BuyProdTimeLabel.TabIndex = 0;
            this.BuyProdTimeLabel.Text = "Label1";
            // 
            // CPortalLogoutPanel
            // 
            this.CPortalLogoutPanel.BackColor = System.Drawing.Color.Azure;
            this.CPortalLogoutPanel.Controls.Add(this.BuyProdLogoutButton);
            this.CPortalLogoutPanel.Controls.Add(this.BuyProdLogoutIcon);
            this.CPortalLogoutPanel.Location = new System.Drawing.Point(891, 102);
            this.CPortalLogoutPanel.Name = "CPortalLogoutPanel";
            this.CPortalLogoutPanel.Size = new System.Drawing.Size(178, 33);
            this.CPortalLogoutPanel.TabIndex = 12;
            // 
            // BuyProdLogoutButton
            // 
            this.BuyProdLogoutButton.Animated = true;
            this.BuyProdLogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.BuyProdLogoutButton.BorderThickness = 1;
            this.BuyProdLogoutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BuyProdLogoutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BuyProdLogoutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BuyProdLogoutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BuyProdLogoutButton.FillColor = System.Drawing.SystemColors.Control;
            this.BuyProdLogoutButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F);
            this.BuyProdLogoutButton.ForeColor = System.Drawing.Color.Black;
            this.BuyProdLogoutButton.Location = new System.Drawing.Point(50, 0);
            this.BuyProdLogoutButton.Name = "BuyProdLogoutButton";
            this.BuyProdLogoutButton.Size = new System.Drawing.Size(125, 31);
            this.BuyProdLogoutButton.TabIndex = 34;
            this.BuyProdLogoutButton.Text = "Sign Out";
            this.BuyProdLogoutButton.Click += new System.EventHandler(this.BuyProdLogoutButton_Click);
            // 
            // BuyProdLogoutIcon
            // 
            this.BuyProdLogoutIcon.Image = ((System.Drawing.Image)(resources.GetObject("BuyProdLogoutIcon.Image")));
            this.BuyProdLogoutIcon.Location = new System.Drawing.Point(0, 0);
            this.BuyProdLogoutIcon.Name = "BuyProdLogoutIcon";
            this.BuyProdLogoutIcon.Size = new System.Drawing.Size(49, 31);
            this.BuyProdLogoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuyProdLogoutIcon.TabIndex = 32;
            this.BuyProdLogoutIcon.TabStop = false;
            this.BuyProdLogoutIcon.Click += new System.EventHandler(this.BuyProdLogoutIcon_Click);
            // 
            // BuyProdExitLabel
            // 
            this.BuyProdExitLabel.AutoSize = true;
            this.BuyProdExitLabel.BackColor = System.Drawing.Color.Red;
            this.BuyProdExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProdExitLabel.Location = new System.Drawing.Point(1034, 0);
            this.BuyProdExitLabel.Name = "BuyProdExitLabel";
            this.BuyProdExitLabel.Size = new System.Drawing.Size(35, 32);
            this.BuyProdExitLabel.TabIndex = 4;
            this.BuyProdExitLabel.Text = "X";
            this.BuyProdExitLabel.Click += new System.EventHandler(this.BuyProdExitLabel_Click);
            // 
            // CPortalWelcomeLabel
            // 
            this.CPortalWelcomeLabel.AutoSize = true;
            this.CPortalWelcomeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPortalWelcomeLabel.Location = new System.Drawing.Point(245, 9);
            this.CPortalWelcomeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CPortalWelcomeLabel.Name = "CPortalWelcomeLabel";
            this.CPortalWelcomeLabel.Size = new System.Drawing.Size(567, 37);
            this.CPortalWelcomeLabel.TabIndex = 2;
            this.CPortalWelcomeLabel.Text = "Welcome TO Your Dashboard";
            // 
            // BuyProdTimer1
            // 
            this.BuyProdTimer1.Tick += new System.EventHandler(this.BuyProdTimer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "Payment Type";
            // 
            // BuyProdPaymentTypeComboBox
            // 
            this.BuyProdPaymentTypeComboBox.AutoRoundedCorners = true;
            this.BuyProdPaymentTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.BuyProdPaymentTypeComboBox.BorderColor = System.Drawing.Color.SkyBlue;
            this.BuyProdPaymentTypeComboBox.BorderRadius = 17;
            this.BuyProdPaymentTypeComboBox.BorderThickness = 3;
            this.BuyProdPaymentTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BuyProdPaymentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuyProdPaymentTypeComboBox.FillColor = System.Drawing.SystemColors.Control;
            this.BuyProdPaymentTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BuyProdPaymentTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BuyProdPaymentTypeComboBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProdPaymentTypeComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuyProdPaymentTypeComboBox.ItemHeight = 30;
            this.BuyProdPaymentTypeComboBox.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.BuyProdPaymentTypeComboBox.Location = new System.Drawing.Point(336, 401);
            this.BuyProdPaymentTypeComboBox.Name = "BuyProdPaymentTypeComboBox";
            this.BuyProdPaymentTypeComboBox.Size = new System.Drawing.Size(300, 36);
            this.BuyProdPaymentTypeComboBox.TabIndex = 44;
            // 
            // SalesDateLabe
            // 
            this.SalesDateLabe.AutoSize = true;
            this.SalesDateLabe.Location = new System.Drawing.Point(316, 582);
            this.SalesDateLabe.Name = "SalesDateLabe";
            this.SalesDateLabe.Size = new System.Drawing.Size(350, 26);
            this.SalesDateLabe.TabIndex = 14;
            this.SalesDateLabe.Text = "Preferred Delivery Date";
            // 
            // BuyProdDateTimePicker
            // 
            this.BuyProdDateTimePicker.CalendarFont = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProdDateTimePicker.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProdDateTimePicker.Location = new System.Drawing.Point(322, 626);
            this.BuyProdDateTimePicker.Name = "BuyProdDateTimePicker";
            this.BuyProdDateTimePicker.Size = new System.Drawing.Size(336, 26);
            this.BuyProdDateTimePicker.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 42;
            this.label1.Text = "Type of Product";
            // 
            // BuyProdQuantityTB
            // 
            this.BuyProdQuantityTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyProdQuantityTB.Animated = true;
            this.BuyProdQuantityTB.AutoRoundedCorners = true;
            this.BuyProdQuantityTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.BuyProdQuantityTB.BorderRadius = 17;
            this.BuyProdQuantityTB.BorderThickness = 3;
            this.BuyProdQuantityTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BuyProdQuantityTB.DefaultText = "";
            this.BuyProdQuantityTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BuyProdQuantityTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BuyProdQuantityTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BuyProdQuantityTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BuyProdQuantityTB.FillColor = System.Drawing.SystemColors.Control;
            this.BuyProdQuantityTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BuyProdQuantityTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.BuyProdQuantityTB.ForeColor = System.Drawing.Color.Black;
            this.BuyProdQuantityTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BuyProdQuantityTB.Location = new System.Drawing.Point(336, 305);
            this.BuyProdQuantityTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BuyProdQuantityTB.Name = "BuyProdQuantityTB";
            this.BuyProdQuantityTB.PasswordChar = '\0';
            this.BuyProdQuantityTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.BuyProdQuantityTB.PlaceholderText = "Quantity";
            this.BuyProdQuantityTB.SelectedText = "";
            this.BuyProdQuantityTB.Size = new System.Drawing.Size(300, 36);
            this.BuyProdQuantityTB.TabIndex = 46;
            this.BuyProdQuantityTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuyProdTypeOfProdComboBox
            // 
            this.BuyProdTypeOfProdComboBox.AutoRoundedCorners = true;
            this.BuyProdTypeOfProdComboBox.BackColor = System.Drawing.Color.Transparent;
            this.BuyProdTypeOfProdComboBox.BorderColor = System.Drawing.Color.SkyBlue;
            this.BuyProdTypeOfProdComboBox.BorderRadius = 17;
            this.BuyProdTypeOfProdComboBox.BorderThickness = 3;
            this.BuyProdTypeOfProdComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BuyProdTypeOfProdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuyProdTypeOfProdComboBox.FillColor = System.Drawing.SystemColors.Control;
            this.BuyProdTypeOfProdComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BuyProdTypeOfProdComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BuyProdTypeOfProdComboBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F);
            this.BuyProdTypeOfProdComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuyProdTypeOfProdComboBox.ItemHeight = 30;
            this.BuyProdTypeOfProdComboBox.Items.AddRange(new object[] {
            "Milk"});
            this.BuyProdTypeOfProdComboBox.Location = new System.Drawing.Point(336, 235);
            this.BuyProdTypeOfProdComboBox.Name = "BuyProdTypeOfProdComboBox";
            this.BuyProdTypeOfProdComboBox.Size = new System.Drawing.Size(300, 36);
            this.BuyProdTypeOfProdComboBox.TabIndex = 47;
            // 
            // BuyProdPlaceOrderButton
            // 
            this.BuyProdPlaceOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BuyProdPlaceOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BuyProdPlaceOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BuyProdPlaceOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BuyProdPlaceOrderButton.FillColor = System.Drawing.Color.SkyBlue;
            this.BuyProdPlaceOrderButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProdPlaceOrderButton.ForeColor = System.Drawing.Color.White;
            this.BuyProdPlaceOrderButton.Location = new System.Drawing.Point(397, 673);
            this.BuyProdPlaceOrderButton.Name = "BuyProdPlaceOrderButton";
            this.BuyProdPlaceOrderButton.Size = new System.Drawing.Size(180, 45);
            this.BuyProdPlaceOrderButton.TabIndex = 49;
            this.BuyProdPlaceOrderButton.Text = "Place Order";
            this.BuyProdPlaceOrderButton.Click += new System.EventHandler(this.BuyProdPlaceOrderButton_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(26, 547);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 51;
            this.guna2TextBox1.Visible = false;
            // 
            // BuyProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.BuyProdPlaceOrderButton);
            this.Controls.Add(this.BuyProdTypeOfProdComboBox);
            this.Controls.Add(this.BuyProdQuantityTB);
            this.Controls.Add(this.BuyProdDateTimePicker);
            this.Controls.Add(this.SalesDateLabe);
            this.Controls.Add(this.BuyProdPaymentTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BuyProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                               ";
            this.Load += new System.EventHandler(this.BuyProd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MPortalHomePanel.ResumeLayout(false);
            this.MPortalHomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPortalLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CPortalDateTimePanel.ResumeLayout(false);
            this.CPortalDateTimePanel.PerformLayout();
            this.CPortalLogoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuyProdLogoutIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MPortalHomePanel;
        private Guna.UI2.WinForms.Guna2ImageButton BuyProdHomeIcon;
        private System.Windows.Forms.Label BuyProdHomeLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.PictureBox CPortalLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CPortalDateTimePanel;
        private System.Windows.Forms.Label BuyProdDateLabel;
        private System.Windows.Forms.Label BuyProdTimeLabel;
        private System.Windows.Forms.Panel CPortalLogoutPanel;
        private Guna.UI2.WinForms.Guna2Button BuyProdLogoutButton;
        private System.Windows.Forms.PictureBox BuyProdLogoutIcon;
        private System.Windows.Forms.Label BuyProdExitLabel;
        private System.Windows.Forms.Label CPortalWelcomeLabel;
        private System.Windows.Forms.Timer BuyProdTimer1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox BuyProdPaymentTypeComboBox;
        private System.Windows.Forms.Label SalesDateLabe;
        private System.Windows.Forms.DateTimePicker BuyProdDateTimePicker;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox BuyProdQuantityTB;
        private Guna.UI2.WinForms.Guna2ComboBox BuyProdTypeOfProdComboBox;
        private Guna.UI2.WinForms.Guna2Button BuyProdPlaceOrderButton;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}