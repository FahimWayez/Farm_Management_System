
namespace FarmManagement
{
    partial class Health
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Health));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MPortalHomePanel = new System.Windows.Forms.Panel();
            this.MPortalHomeIcon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.MPortalHomeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HealthClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.HealthDeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.HealthUpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.HealthSaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.HealthLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HealthDateTimePanel = new System.Windows.Forms.Panel();
            this.HealthDateLabel = new System.Windows.Forms.Label();
            this.HealthTimeLabel = new System.Windows.Forms.Label();
            this.HealthExitLabel = new System.Windows.Forms.Label();
            this.HealthTimer1 = new System.Windows.Forms.Timer(this.components);
            this.HealthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HealthDateLabe = new System.Windows.Forms.Label();
            this.HealthTagLabel = new System.Windows.Forms.Label();
            this.HealthDBLabel = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.HealthSearchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.HealthCostTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.HealthTreatmentTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.HealthTagComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.HealthSicknessTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.HealthDatePanel = new System.Windows.Forms.Panel();
            this.HealthRefreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.HealthDBDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Treatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.MPortalHomePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.HealthDateTimePanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.HealthDatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthDBDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.MPortalHomePanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.AdminLabel);
            this.panel1.Controls.Add(this.HealthLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 730);
            this.panel1.TabIndex = 23;
            // 
            // MPortalHomePanel
            // 
            this.MPortalHomePanel.BackColor = System.Drawing.SystemColors.Control;
            this.MPortalHomePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MPortalHomePanel.Controls.Add(this.MPortalHomeIcon);
            this.MPortalHomePanel.Controls.Add(this.MPortalHomeLabel);
            this.MPortalHomePanel.Location = new System.Drawing.Point(3, 189);
            this.MPortalHomePanel.Name = "MPortalHomePanel";
            this.MPortalHomePanel.Size = new System.Drawing.Size(267, 95);
            this.MPortalHomePanel.TabIndex = 29;
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
            this.MPortalHomeLabel.Location = new System.Drawing.Point(164, 32);
            this.MPortalHomeLabel.Name = "MPortalHomeLabel";
            this.MPortalHomeLabel.Size = new System.Drawing.Size(85, 26);
            this.MPortalHomeLabel.TabIndex = 1;
            this.MPortalHomeLabel.Text = "Home";
            this.MPortalHomeLabel.Click += new System.EventHandler(this.MPortalHomeLabel_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.HealthClearButton);
            this.panel3.Controls.Add(this.HealthDeleteButton);
            this.panel3.Controls.Add(this.HealthUpdateButton);
            this.panel3.Controls.Add(this.HealthSaveButton);
            this.panel3.Location = new System.Drawing.Point(3, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 217);
            this.panel3.TabIndex = 41;
            // 
            // HealthClearButton
            // 
            this.HealthClearButton.Animated = true;
            this.HealthClearButton.AutoRoundedCorners = true;
            this.HealthClearButton.BackColor = System.Drawing.Color.Transparent;
            this.HealthClearButton.BorderRadius = 18;
            this.HealthClearButton.BorderThickness = 3;
            this.HealthClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HealthClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HealthClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HealthClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HealthClearButton.FillColor = System.Drawing.SystemColors.Control;
            this.HealthClearButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.HealthClearButton.ForeColor = System.Drawing.Color.Black;
            this.HealthClearButton.Location = new System.Drawing.Point(62, 152);
            this.HealthClearButton.Name = "HealthClearButton";
            this.HealthClearButton.Size = new System.Drawing.Size(150, 38);
            this.HealthClearButton.TabIndex = 28;
            this.HealthClearButton.Text = "Clear";
            this.HealthClearButton.UseTransparentBackground = true;
            this.HealthClearButton.Click += new System.EventHandler(this.HealthClearButton_Click);
            // 
            // HealthDeleteButton
            // 
            this.HealthDeleteButton.Animated = true;
            this.HealthDeleteButton.AutoRoundedCorners = true;
            this.HealthDeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.HealthDeleteButton.BorderRadius = 18;
            this.HealthDeleteButton.BorderThickness = 3;
            this.HealthDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HealthDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HealthDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HealthDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HealthDeleteButton.FillColor = System.Drawing.SystemColors.Control;
            this.HealthDeleteButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.HealthDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.HealthDeleteButton.Location = new System.Drawing.Point(62, 108);
            this.HealthDeleteButton.Name = "HealthDeleteButton";
            this.HealthDeleteButton.Size = new System.Drawing.Size(150, 38);
            this.HealthDeleteButton.TabIndex = 27;
            this.HealthDeleteButton.Text = "Delete";
            this.HealthDeleteButton.UseTransparentBackground = true;
            this.HealthDeleteButton.Click += new System.EventHandler(this.HealthDeleteButton_Click);
            // 
            // HealthUpdateButton
            // 
            this.HealthUpdateButton.Animated = true;
            this.HealthUpdateButton.AutoRoundedCorners = true;
            this.HealthUpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.HealthUpdateButton.BorderRadius = 18;
            this.HealthUpdateButton.BorderThickness = 3;
            this.HealthUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HealthUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HealthUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HealthUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HealthUpdateButton.FillColor = System.Drawing.SystemColors.Control;
            this.HealthUpdateButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.HealthUpdateButton.ForeColor = System.Drawing.Color.Black;
            this.HealthUpdateButton.Location = new System.Drawing.Point(63, 64);
            this.HealthUpdateButton.Name = "HealthUpdateButton";
            this.HealthUpdateButton.Size = new System.Drawing.Size(150, 38);
            this.HealthUpdateButton.TabIndex = 26;
            this.HealthUpdateButton.Text = "Update";
            this.HealthUpdateButton.UseTransparentBackground = true;
            this.HealthUpdateButton.Click += new System.EventHandler(this.HealthUpdateButton_Click);
            // 
            // HealthSaveButton
            // 
            this.HealthSaveButton.Animated = true;
            this.HealthSaveButton.AutoRoundedCorners = true;
            this.HealthSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.HealthSaveButton.BorderRadius = 18;
            this.HealthSaveButton.BorderThickness = 3;
            this.HealthSaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HealthSaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HealthSaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HealthSaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HealthSaveButton.FillColor = System.Drawing.SystemColors.Control;
            this.HealthSaveButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.HealthSaveButton.ForeColor = System.Drawing.Color.Black;
            this.HealthSaveButton.Location = new System.Drawing.Point(62, 20);
            this.HealthSaveButton.Name = "HealthSaveButton";
            this.HealthSaveButton.Size = new System.Drawing.Size(150, 38);
            this.HealthSaveButton.TabIndex = 25;
            this.HealthSaveButton.Text = "Save";
            this.HealthSaveButton.UseTransparentBackground = true;
            this.HealthSaveButton.Click += new System.EventHandler(this.HealthSaveButton_Click);
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
            // HealthLogo
            // 
            this.HealthLogo.Image = ((System.Drawing.Image)(resources.GetObject("HealthLogo.Image")));
            this.HealthLogo.Location = new System.Drawing.Point(0, 0);
            this.HealthLogo.Name = "HealthLogo";
            this.HealthLogo.Size = new System.Drawing.Size(280, 183);
            this.HealthLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HealthLogo.TabIndex = 0;
            this.HealthLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.HealthDateTimePanel);
            this.panel2.Controls.Add(this.HealthExitLabel);
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 55);
            this.panel2.TabIndex = 24;
            // 
            // HealthDateTimePanel
            // 
            this.HealthDateTimePanel.BackColor = System.Drawing.Color.Azure;
            this.HealthDateTimePanel.Controls.Add(this.HealthDateLabel);
            this.HealthDateTimePanel.Controls.Add(this.HealthTimeLabel);
            this.HealthDateTimePanel.Location = new System.Drawing.Point(10, 11);
            this.HealthDateTimePanel.Name = "HealthDateTimePanel";
            this.HealthDateTimePanel.Size = new System.Drawing.Size(1004, 33);
            this.HealthDateTimePanel.TabIndex = 6;
            // 
            // HealthDateLabel
            // 
            this.HealthDateLabel.AutoSize = true;
            this.HealthDateLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthDateLabel.Location = new System.Drawing.Point(5, 5);
            this.HealthDateLabel.Name = "HealthDateLabel";
            this.HealthDateLabel.Size = new System.Drawing.Size(108, 26);
            this.HealthDateLabel.TabIndex = 1;
            this.HealthDateLabel.Text = "Label2";
            // 
            // HealthTimeLabel
            // 
            this.HealthTimeLabel.AutoSize = true;
            this.HealthTimeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthTimeLabel.Location = new System.Drawing.Point(400, 5);
            this.HealthTimeLabel.Name = "HealthTimeLabel";
            this.HealthTimeLabel.Size = new System.Drawing.Size(108, 26);
            this.HealthTimeLabel.TabIndex = 0;
            this.HealthTimeLabel.Text = "Label1";
            // 
            // HealthExitLabel
            // 
            this.HealthExitLabel.AutoSize = true;
            this.HealthExitLabel.BackColor = System.Drawing.Color.Red;
            this.HealthExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthExitLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.HealthExitLabel.Location = new System.Drawing.Point(1034, 0);
            this.HealthExitLabel.Name = "HealthExitLabel";
            this.HealthExitLabel.Size = new System.Drawing.Size(35, 32);
            this.HealthExitLabel.TabIndex = 4;
            this.HealthExitLabel.Text = "X";
            this.HealthExitLabel.Click += new System.EventHandler(this.HealthExitLabel_Click);
            // 
            // HealthTimer1
            // 
            this.HealthTimer1.Tick += new System.EventHandler(this.HealthTimer1_Tick);
            // 
            // HealthDateTimePicker
            // 
            this.HealthDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.HealthDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.HealthDateTimePicker.CustomFormat = "";
            this.HealthDateTimePicker.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthDateTimePicker.Location = new System.Drawing.Point(3, 31);
            this.HealthDateTimePicker.Name = "HealthDateTimePicker";
            this.HealthDateTimePicker.Size = new System.Drawing.Size(336, 26);
            this.HealthDateTimePicker.TabIndex = 15;
            this.HealthDateTimePicker.Tag = "0";
            // 
            // HealthDateLabe
            // 
            this.HealthDateLabe.AutoSize = true;
            this.HealthDateLabe.Location = new System.Drawing.Point(123, 2);
            this.HealthDateLabe.Name = "HealthDateLabe";
            this.HealthDateLabe.Size = new System.Drawing.Size(78, 26);
            this.HealthDateLabe.TabIndex = 14;
            this.HealthDateLabe.Text = "Date";
            // 
            // HealthTagLabel
            // 
            this.HealthTagLabel.AutoSize = true;
            this.HealthTagLabel.Location = new System.Drawing.Point(119, 3);
            this.HealthTagLabel.Name = "HealthTagLabel";
            this.HealthTagLabel.Size = new System.Drawing.Size(62, 26);
            this.HealthTagLabel.TabIndex = 12;
            this.HealthTagLabel.Text = "Tag";
            // 
            // HealthDBLabel
            // 
            this.HealthDBLabel.AutoSize = true;
            this.HealthDBLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HealthDBLabel.Location = new System.Drawing.Point(639, 302);
            this.HealthDBLabel.Name = "HealthDBLabel";
            this.HealthDBLabel.Size = new System.Drawing.Size(315, 28);
            this.HealthDBLabel.TabIndex = 2;
            this.HealthDBLabel.Text = "Cattle Health Report";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.HealthSearchTB);
            this.panel10.Controls.Add(this.HealthCostTB);
            this.panel10.Controls.Add(this.HealthTreatmentTB);
            this.panel10.Controls.Add(this.HealthTagLabel);
            this.panel10.Controls.Add(this.HealthTagComboBox);
            this.panel10.Controls.Add(this.HealthSicknessTB);
            this.panel10.Controls.Add(this.HealthDatePanel);
            this.panel10.Location = new System.Drawing.Point(291, 62);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1047, 237);
            this.panel10.TabIndex = 26;
            // 
            // HealthSearchTB
            // 
            this.HealthSearchTB.AcceptsTab = true;
            this.HealthSearchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthSearchTB.Animated = true;
            this.HealthSearchTB.AutoRoundedCorners = true;
            this.HealthSearchTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.HealthSearchTB.BorderRadius = 25;
            this.HealthSearchTB.BorderThickness = 3;
            this.HealthSearchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HealthSearchTB.DefaultText = "";
            this.HealthSearchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HealthSearchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HealthSearchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HealthSearchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HealthSearchTB.FillColor = System.Drawing.SystemColors.Control;
            this.HealthSearchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthSearchTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.HealthSearchTB.ForeColor = System.Drawing.Color.Black;
            this.HealthSearchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthSearchTB.Location = new System.Drawing.Point(470, 173);
            this.HealthSearchTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.HealthSearchTB.Name = "HealthSearchTB";
            this.HealthSearchTB.PasswordChar = '\0';
            this.HealthSearchTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.HealthSearchTB.PlaceholderText = "Search by Tag";
            this.HealthSearchTB.SelectedText = "";
            this.HealthSearchTB.Size = new System.Drawing.Size(572, 52);
            this.HealthSearchTB.TabIndex = 37;
            this.HealthSearchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HealthSearchTB.TextChanged += new System.EventHandler(this.HealthSearchTB_TextChanged);
            // 
            // HealthCostTB
            // 
            this.HealthCostTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthCostTB.Animated = true;
            this.HealthCostTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.HealthCostTB.BorderThickness = 3;
            this.HealthCostTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HealthCostTB.DefaultText = "";
            this.HealthCostTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HealthCostTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HealthCostTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HealthCostTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HealthCostTB.FillColor = System.Drawing.SystemColors.Control;
            this.HealthCostTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthCostTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.HealthCostTB.ForeColor = System.Drawing.Color.Black;
            this.HealthCostTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthCostTB.Location = new System.Drawing.Point(363, 88);
            this.HealthCostTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.HealthCostTB.Name = "HealthCostTB";
            this.HealthCostTB.PasswordChar = '\0';
            this.HealthCostTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.HealthCostTB.PlaceholderText = "Cost";
            this.HealthCostTB.SelectedText = "";
            this.HealthCostTB.Size = new System.Drawing.Size(300, 33);
            this.HealthCostTB.TabIndex = 40;
            this.HealthCostTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HealthTreatmentTB
            // 
            this.HealthTreatmentTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthTreatmentTB.Animated = true;
            this.HealthTreatmentTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.HealthTreatmentTB.BorderThickness = 3;
            this.HealthTreatmentTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HealthTreatmentTB.DefaultText = "";
            this.HealthTreatmentTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HealthTreatmentTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HealthTreatmentTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HealthTreatmentTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HealthTreatmentTB.FillColor = System.Drawing.SystemColors.Control;
            this.HealthTreatmentTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthTreatmentTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.HealthTreatmentTB.ForeColor = System.Drawing.Color.Black;
            this.HealthTreatmentTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthTreatmentTB.Location = new System.Drawing.Point(742, 32);
            this.HealthTreatmentTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.HealthTreatmentTB.Name = "HealthTreatmentTB";
            this.HealthTreatmentTB.PasswordChar = '\0';
            this.HealthTreatmentTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.HealthTreatmentTB.PlaceholderText = "Treatment";
            this.HealthTreatmentTB.SelectedText = "";
            this.HealthTreatmentTB.Size = new System.Drawing.Size(300, 33);
            this.HealthTreatmentTB.TabIndex = 39;
            this.HealthTreatmentTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HealthTagComboBox
            // 
            this.HealthTagComboBox.BackColor = System.Drawing.Color.Transparent;
            this.HealthTagComboBox.BorderColor = System.Drawing.Color.SkyBlue;
            this.HealthTagComboBox.BorderThickness = 3;
            this.HealthTagComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HealthTagComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HealthTagComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthTagComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthTagComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HealthTagComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.HealthTagComboBox.ItemHeight = 30;
            this.HealthTagComboBox.Location = new System.Drawing.Point(36, 32);
            this.HealthTagComboBox.Name = "HealthTagComboBox";
            this.HealthTagComboBox.Size = new System.Drawing.Size(249, 36);
            this.HealthTagComboBox.TabIndex = 37;
            // 
            // HealthSicknessTB
            // 
            this.HealthSicknessTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthSicknessTB.Animated = true;
            this.HealthSicknessTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.HealthSicknessTB.BorderThickness = 3;
            this.HealthSicknessTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HealthSicknessTB.DefaultText = "";
            this.HealthSicknessTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HealthSicknessTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HealthSicknessTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HealthSicknessTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HealthSicknessTB.FillColor = System.Drawing.SystemColors.Control;
            this.HealthSicknessTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthSicknessTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.HealthSicknessTB.ForeColor = System.Drawing.Color.Black;
            this.HealthSicknessTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthSicknessTB.Location = new System.Drawing.Point(363, 32);
            this.HealthSicknessTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.HealthSicknessTB.Name = "HealthSicknessTB";
            this.HealthSicknessTB.PasswordChar = '\0';
            this.HealthSicknessTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.HealthSicknessTB.PlaceholderText = "Sickness";
            this.HealthSicknessTB.SelectedText = "";
            this.HealthSicknessTB.Size = new System.Drawing.Size(300, 33);
            this.HealthSicknessTB.TabIndex = 38;
            this.HealthSicknessTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HealthDatePanel
            // 
            this.HealthDatePanel.Controls.Add(this.HealthDateTimePicker);
            this.HealthDatePanel.Controls.Add(this.HealthDateLabe);
            this.HealthDatePanel.Location = new System.Drawing.Point(10, 161);
            this.HealthDatePanel.Name = "HealthDatePanel";
            this.HealthDatePanel.Size = new System.Drawing.Size(339, 64);
            this.HealthDatePanel.TabIndex = 16;
            // 
            // HealthRefreshButton
            // 
            this.HealthRefreshButton.Animated = true;
            this.HealthRefreshButton.AutoRoundedCorners = true;
            this.HealthRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.HealthRefreshButton.BorderRadius = 14;
            this.HealthRefreshButton.BorderThickness = 1;
            this.HealthRefreshButton.DefaultAutoSize = true;
            this.HealthRefreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HealthRefreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HealthRefreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HealthRefreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HealthRefreshButton.FillColor = System.Drawing.SystemColors.Control;
            this.HealthRefreshButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F);
            this.HealthRefreshButton.ForeColor = System.Drawing.Color.Black;
            this.HealthRefreshButton.IndicateFocus = true;
            this.HealthRefreshButton.Location = new System.Drawing.Point(1219, 305);
            this.HealthRefreshButton.Name = "HealthRefreshButton";
            this.HealthRefreshButton.Size = new System.Drawing.Size(114, 31);
            this.HealthRefreshButton.TabIndex = 38;
            this.HealthRefreshButton.Text = "Refresh";
            this.HealthRefreshButton.UseTransparentBackground = true;
            this.HealthRefreshButton.Click += new System.EventHandler(this.HealthRefreshButton_Click);
            // 
            // HealthDBDataGrid
            // 
            this.HealthDBDataGrid.AllowUserToAddRows = false;
            this.HealthDBDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.HealthDBDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HealthDBDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HealthDBDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.HealthDBDataGrid.ColumnHeadersHeight = 28;
            this.HealthDBDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.HealthDBDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tag,
            this.Sickness,
            this.Treatment,
            this.Cost,
            this.Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HealthDBDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.HealthDBDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HealthDBDataGrid.Location = new System.Drawing.Point(291, 342);
            this.HealthDBDataGrid.Name = "HealthDBDataGrid";
            this.HealthDBDataGrid.ReadOnly = true;
            this.HealthDBDataGrid.RowHeadersVisible = false;
            this.HealthDBDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.HealthDBDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.HealthDBDataGrid.RowTemplate.Height = 24;
            this.HealthDBDataGrid.Size = new System.Drawing.Size(1047, 388);
            this.HealthDBDataGrid.TabIndex = 39;
            this.HealthDBDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.HealthDBDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.HealthDBDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.HealthDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.HealthDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.HealthDBDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.HealthDBDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HealthDBDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.HealthDBDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.HealthDBDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthDBDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.HealthDBDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.HealthDBDataGrid.ThemeStyle.HeaderStyle.Height = 28;
            this.HealthDBDataGrid.ThemeStyle.ReadOnly = true;
            this.HealthDBDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.HealthDBDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.HealthDBDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthDBDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.HealthDBDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.HealthDBDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HealthDBDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.HealthDBDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HealthDBDataGrid_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "HealthID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Tag
            // 
            this.Tag.DataPropertyName = "Tag";
            this.Tag.HeaderText = "Tag";
            this.Tag.MinimumWidth = 6;
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
            // 
            // Sickness
            // 
            this.Sickness.DataPropertyName = "Sickness";
            this.Sickness.HeaderText = "Sickness";
            this.Sickness.MinimumWidth = 6;
            this.Sickness.Name = "Sickness";
            this.Sickness.ReadOnly = true;
            // 
            // Treatment
            // 
            this.Treatment.DataPropertyName = "Treatment";
            this.Treatment.HeaderText = "Treatment";
            this.Treatment.MinimumWidth = 6;
            this.Treatment.Name = "Treatment";
            this.Treatment.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Health
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.HealthDBDataGrid);
            this.Controls.Add(this.HealthRefreshButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HealthDBLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel10);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Health";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "health";
            this.Load += new System.EventHandler(this.health_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MPortalHomePanel.ResumeLayout(false);
            this.MPortalHomePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HealthLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HealthDateTimePanel.ResumeLayout(false);
            this.HealthDateTimePanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.HealthDatePanel.ResumeLayout(false);
            this.HealthDatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthDBDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.PictureBox HealthLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel HealthDateTimePanel;
        private System.Windows.Forms.Label HealthDateLabel;
        private System.Windows.Forms.Label HealthTimeLabel;
        private System.Windows.Forms.Label HealthExitLabel;
        private System.Windows.Forms.Timer HealthTimer1;
        private System.Windows.Forms.DateTimePicker HealthDateTimePicker;
        private System.Windows.Forms.Label HealthDateLabe;
        private System.Windows.Forms.Label HealthTagLabel;
        private System.Windows.Forms.Label HealthDBLabel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel HealthDatePanel;
        private Guna.UI2.WinForms.Guna2ComboBox HealthTagComboBox;
        private Guna.UI2.WinForms.Guna2TextBox HealthCostTB;
        private Guna.UI2.WinForms.Guna2TextBox HealthTreatmentTB;
        private Guna.UI2.WinForms.Guna2TextBox HealthSicknessTB;
        private Guna.UI2.WinForms.Guna2TextBox HealthSearchTB;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button HealthClearButton;
        private Guna.UI2.WinForms.Guna2Button HealthDeleteButton;
        private Guna.UI2.WinForms.Guna2Button HealthUpdateButton;
        private Guna.UI2.WinForms.Guna2Button HealthSaveButton;
        private Guna.UI2.WinForms.Guna2Button HealthRefreshButton;
        private Guna.UI2.WinForms.Guna2DataGridView HealthDBDataGrid;
        private System.Windows.Forms.Panel MPortalHomePanel;
        private Guna.UI2.WinForms.Guna2ImageButton MPortalHomeIcon;
        private System.Windows.Forms.Label MPortalHomeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Treatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}