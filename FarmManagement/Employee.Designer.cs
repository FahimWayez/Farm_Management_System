
namespace FarmManagement
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MPortalHomePanel = new System.Windows.Forms.Panel();
            this.MPortalHomeIcon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.MPortalHomeLabel = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.EmpClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.EmpDeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.EmpUpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.EmpSaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.EmpLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmpDateTimePanel = new System.Windows.Forms.Panel();
            this.EmpTimeLabell = new System.Windows.Forms.Label();
            this.EmpDateLabel = new System.Windows.Forms.Label();
            this.EmpTimeLabel = new System.Windows.Forms.Label();
            this.EmpExitLabel = new System.Windows.Forms.Label();
            this.EmpTimer1 = new System.Windows.Forms.Timer(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.CattleDOBPanel = new System.Windows.Forms.Panel();
            this.EmpDOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EmpDOBLabel = new System.Windows.Forms.Label();
            this.EmpSearchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmpContact2TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmpContact1TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmpAddressTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmpPositionTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmpNameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmpDBLabel = new System.Windows.Forms.Label();
            this.EmpDBDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpContactNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpContactNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpRefreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.MPortalHomePanel.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.EmpDateTimePanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.CattleDOBPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDBDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.MPortalHomePanel);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.AdminLabel);
            this.panel1.Controls.Add(this.EmpLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 730);
            this.panel1.TabIndex = 8;
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
            this.MPortalHomeLabel.Location = new System.Drawing.Point(176, 32);
            this.MPortalHomeLabel.Name = "MPortalHomeLabel";
            this.MPortalHomeLabel.Size = new System.Drawing.Size(85, 26);
            this.MPortalHomeLabel.TabIndex = 1;
            this.MPortalHomeLabel.Text = "Home";
            this.MPortalHomeLabel.Click += new System.EventHandler(this.MPortalHomeLabel_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.EmpClearButton);
            this.panel12.Controls.Add(this.EmpDeleteButton);
            this.panel12.Controls.Add(this.EmpUpdateButton);
            this.panel12.Controls.Add(this.EmpSaveButton);
            this.panel12.Location = new System.Drawing.Point(3, 362);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(277, 217);
            this.panel12.TabIndex = 11;
            // 
            // EmpClearButton
            // 
            this.EmpClearButton.Animated = true;
            this.EmpClearButton.AutoRoundedCorners = true;
            this.EmpClearButton.BackColor = System.Drawing.Color.Transparent;
            this.EmpClearButton.BorderRadius = 18;
            this.EmpClearButton.BorderThickness = 3;
            this.EmpClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmpClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmpClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmpClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmpClearButton.FillColor = System.Drawing.SystemColors.Control;
            this.EmpClearButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.EmpClearButton.ForeColor = System.Drawing.Color.Black;
            this.EmpClearButton.Location = new System.Drawing.Point(62, 152);
            this.EmpClearButton.Name = "EmpClearButton";
            this.EmpClearButton.Size = new System.Drawing.Size(150, 38);
            this.EmpClearButton.TabIndex = 28;
            this.EmpClearButton.Text = "Clear";
            this.EmpClearButton.UseTransparentBackground = true;
            this.EmpClearButton.Click += new System.EventHandler(this.EmpClearButton_Click);
            // 
            // EmpDeleteButton
            // 
            this.EmpDeleteButton.Animated = true;
            this.EmpDeleteButton.AutoRoundedCorners = true;
            this.EmpDeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.EmpDeleteButton.BorderRadius = 18;
            this.EmpDeleteButton.BorderThickness = 3;
            this.EmpDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmpDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmpDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmpDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmpDeleteButton.FillColor = System.Drawing.SystemColors.Control;
            this.EmpDeleteButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.EmpDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.EmpDeleteButton.Location = new System.Drawing.Point(62, 108);
            this.EmpDeleteButton.Name = "EmpDeleteButton";
            this.EmpDeleteButton.Size = new System.Drawing.Size(150, 38);
            this.EmpDeleteButton.TabIndex = 27;
            this.EmpDeleteButton.Text = "Delete";
            this.EmpDeleteButton.UseTransparentBackground = true;
            this.EmpDeleteButton.Click += new System.EventHandler(this.EmpDeleteButton_Click);
            // 
            // EmpUpdateButton
            // 
            this.EmpUpdateButton.Animated = true;
            this.EmpUpdateButton.AutoRoundedCorners = true;
            this.EmpUpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.EmpUpdateButton.BorderRadius = 18;
            this.EmpUpdateButton.BorderThickness = 3;
            this.EmpUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmpUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmpUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmpUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmpUpdateButton.FillColor = System.Drawing.SystemColors.Control;
            this.EmpUpdateButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.EmpUpdateButton.ForeColor = System.Drawing.Color.Black;
            this.EmpUpdateButton.Location = new System.Drawing.Point(62, 64);
            this.EmpUpdateButton.Name = "EmpUpdateButton";
            this.EmpUpdateButton.Size = new System.Drawing.Size(150, 38);
            this.EmpUpdateButton.TabIndex = 26;
            this.EmpUpdateButton.Text = "Update";
            this.EmpUpdateButton.UseTransparentBackground = true;
            this.EmpUpdateButton.Click += new System.EventHandler(this.EmpUpdateButton_Click);
            // 
            // EmpSaveButton
            // 
            this.EmpSaveButton.Animated = true;
            this.EmpSaveButton.AutoRoundedCorners = true;
            this.EmpSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.EmpSaveButton.BorderRadius = 18;
            this.EmpSaveButton.BorderThickness = 3;
            this.EmpSaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmpSaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmpSaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmpSaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmpSaveButton.FillColor = System.Drawing.SystemColors.Control;
            this.EmpSaveButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.EmpSaveButton.ForeColor = System.Drawing.Color.Black;
            this.EmpSaveButton.Location = new System.Drawing.Point(62, 20);
            this.EmpSaveButton.Name = "EmpSaveButton";
            this.EmpSaveButton.Size = new System.Drawing.Size(150, 38);
            this.EmpSaveButton.TabIndex = 25;
            this.EmpSaveButton.Text = "Save";
            this.EmpSaveButton.UseTransparentBackground = true;
            this.EmpSaveButton.Click += new System.EventHandler(this.EmpSaveButton_Click);
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
            // EmpLogo
            // 
            this.EmpLogo.Image = ((System.Drawing.Image)(resources.GetObject("EmpLogo.Image")));
            this.EmpLogo.Location = new System.Drawing.Point(0, 0);
            this.EmpLogo.Name = "EmpLogo";
            this.EmpLogo.Size = new System.Drawing.Size(280, 183);
            this.EmpLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmpLogo.TabIndex = 0;
            this.EmpLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.EmpDateTimePanel);
            this.panel2.Controls.Add(this.EmpExitLabel);
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 55);
            this.panel2.TabIndex = 9;
            // 
            // EmpDateTimePanel
            // 
            this.EmpDateTimePanel.BackColor = System.Drawing.Color.Azure;
            this.EmpDateTimePanel.Controls.Add(this.EmpTimeLabell);
            this.EmpDateTimePanel.Controls.Add(this.EmpDateLabel);
            this.EmpDateTimePanel.Controls.Add(this.EmpTimeLabel);
            this.EmpDateTimePanel.Location = new System.Drawing.Point(10, 11);
            this.EmpDateTimePanel.Name = "EmpDateTimePanel";
            this.EmpDateTimePanel.Size = new System.Drawing.Size(1004, 33);
            this.EmpDateTimePanel.TabIndex = 6;
            // 
            // EmpTimeLabell
            // 
            this.EmpTimeLabell.AutoSize = true;
            this.EmpTimeLabell.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpTimeLabell.Location = new System.Drawing.Point(448, 3);
            this.EmpTimeLabell.Name = "EmpTimeLabell";
            this.EmpTimeLabell.Size = new System.Drawing.Size(108, 26);
            this.EmpTimeLabell.TabIndex = 2;
            this.EmpTimeLabell.Text = "Label2";
            // 
            // EmpDateLabel
            // 
            this.EmpDateLabel.AutoSize = true;
            this.EmpDateLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDateLabel.Location = new System.Drawing.Point(5, 5);
            this.EmpDateLabel.Name = "EmpDateLabel";
            this.EmpDateLabel.Size = new System.Drawing.Size(108, 26);
            this.EmpDateLabel.TabIndex = 1;
            this.EmpDateLabel.Text = "Label2";
            // 
            // EmpTimeLabel
            // 
            this.EmpTimeLabel.AutoSize = true;
            this.EmpTimeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpTimeLabel.Location = new System.Drawing.Point(400, 5);
            this.EmpTimeLabel.Name = "EmpTimeLabel";
            this.EmpTimeLabel.Size = new System.Drawing.Size(0, 26);
            this.EmpTimeLabel.TabIndex = 0;
            // 
            // EmpExitLabel
            // 
            this.EmpExitLabel.AutoSize = true;
            this.EmpExitLabel.BackColor = System.Drawing.Color.Red;
            this.EmpExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpExitLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.EmpExitLabel.Location = new System.Drawing.Point(1034, 0);
            this.EmpExitLabel.Name = "EmpExitLabel";
            this.EmpExitLabel.Size = new System.Drawing.Size(35, 32);
            this.EmpExitLabel.TabIndex = 4;
            this.EmpExitLabel.Text = "X";
            this.EmpExitLabel.Click += new System.EventHandler(this.EmpExitLabel_Click_1);
            // 
            // EmpTimer1
            // 
            this.EmpTimer1.Tick += new System.EventHandler(this.EmpTimer1_Tick);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.CattleDOBPanel);
            this.panel10.Controls.Add(this.EmpSearchTB);
            this.panel10.Controls.Add(this.EmpContact2TB);
            this.panel10.Controls.Add(this.EmpContact1TB);
            this.panel10.Controls.Add(this.EmpAddressTB);
            this.panel10.Controls.Add(this.EmpPositionTB);
            this.panel10.Controls.Add(this.EmpNameTB);
            this.panel10.Location = new System.Drawing.Point(291, 62);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1047, 267);
            this.panel10.TabIndex = 18;
            // 
            // CattleDOBPanel
            // 
            this.CattleDOBPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CattleDOBPanel.Controls.Add(this.EmpDOBDateTimePicker);
            this.CattleDOBPanel.Controls.Add(this.EmpDOBLabel);
            this.CattleDOBPanel.Location = new System.Drawing.Point(16, 175);
            this.CattleDOBPanel.Name = "CattleDOBPanel";
            this.CattleDOBPanel.Size = new System.Drawing.Size(339, 67);
            this.CattleDOBPanel.TabIndex = 25;
            // 
            // EmpDOBDateTimePicker
            // 
            this.EmpDOBDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.EmpDOBDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.EmpDOBDateTimePicker.CustomFormat = "";
            this.EmpDOBDateTimePicker.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDOBDateTimePicker.Location = new System.Drawing.Point(3, 34);
            this.EmpDOBDateTimePicker.Name = "EmpDOBDateTimePicker";
            this.EmpDOBDateTimePicker.Size = new System.Drawing.Size(336, 26);
            this.EmpDOBDateTimePicker.TabIndex = 15;
            this.EmpDOBDateTimePicker.Tag = "0";
            this.EmpDOBDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // EmpDOBLabel
            // 
            this.EmpDOBLabel.AutoSize = true;
            this.EmpDOBLabel.Location = new System.Drawing.Point(84, 5);
            this.EmpDOBLabel.Name = "EmpDOBLabel";
            this.EmpDOBLabel.Size = new System.Drawing.Size(195, 26);
            this.EmpDOBLabel.TabIndex = 14;
            this.EmpDOBLabel.Text = "Date of Birth";
            // 
            // EmpSearchTB
            // 
            this.EmpSearchTB.AcceptsTab = true;
            this.EmpSearchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpSearchTB.Animated = true;
            this.EmpSearchTB.AutoRoundedCorners = true;
            this.EmpSearchTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.EmpSearchTB.BorderRadius = 28;
            this.EmpSearchTB.BorderThickness = 3;
            this.EmpSearchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpSearchTB.DefaultText = "";
            this.EmpSearchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpSearchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpSearchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpSearchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpSearchTB.FillColor = System.Drawing.SystemColors.Control;
            this.EmpSearchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpSearchTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.EmpSearchTB.ForeColor = System.Drawing.Color.Black;
            this.EmpSearchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpSearchTB.Location = new System.Drawing.Point(470, 181);
            this.EmpSearchTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.EmpSearchTB.Name = "EmpSearchTB";
            this.EmpSearchTB.PasswordChar = '\0';
            this.EmpSearchTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.EmpSearchTB.PlaceholderText = "Search by Name";
            this.EmpSearchTB.SelectedText = "";
            this.EmpSearchTB.Size = new System.Drawing.Size(572, 59);
            this.EmpSearchTB.TabIndex = 24;
            this.EmpSearchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmpSearchTB.TextChanged += new System.EventHandler(this.EmpSearchTB_TextChanged);
            // 
            // EmpContact2TB
            // 
            this.EmpContact2TB.AcceptsTab = true;
            this.EmpContact2TB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpContact2TB.Animated = true;
            this.EmpContact2TB.BorderColor = System.Drawing.Color.SkyBlue;
            this.EmpContact2TB.BorderThickness = 3;
            this.EmpContact2TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpContact2TB.DefaultText = "";
            this.EmpContact2TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpContact2TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpContact2TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpContact2TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpContact2TB.FillColor = System.Drawing.SystemColors.Control;
            this.EmpContact2TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpContact2TB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.EmpContact2TB.ForeColor = System.Drawing.Color.Black;
            this.EmpContact2TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpContact2TB.Location = new System.Drawing.Point(545, 90);
            this.EmpContact2TB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.EmpContact2TB.Name = "EmpContact2TB";
            this.EmpContact2TB.PasswordChar = '\0';
            this.EmpContact2TB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.EmpContact2TB.PlaceholderText = "Contact Number 2";
            this.EmpContact2TB.SelectedText = "";
            this.EmpContact2TB.Size = new System.Drawing.Size(300, 59);
            this.EmpContact2TB.TabIndex = 23;
            this.EmpContact2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmpContact1TB
            // 
            this.EmpContact1TB.AcceptsTab = true;
            this.EmpContact1TB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpContact1TB.Animated = true;
            this.EmpContact1TB.BorderColor = System.Drawing.Color.SkyBlue;
            this.EmpContact1TB.BorderThickness = 3;
            this.EmpContact1TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpContact1TB.DefaultText = "";
            this.EmpContact1TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpContact1TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpContact1TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpContact1TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpContact1TB.FillColor = System.Drawing.SystemColors.Control;
            this.EmpContact1TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpContact1TB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.EmpContact1TB.ForeColor = System.Drawing.Color.Black;
            this.EmpContact1TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpContact1TB.Location = new System.Drawing.Point(201, 90);
            this.EmpContact1TB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.EmpContact1TB.Name = "EmpContact1TB";
            this.EmpContact1TB.PasswordChar = '\0';
            this.EmpContact1TB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.EmpContact1TB.PlaceholderText = "Contact Number 1";
            this.EmpContact1TB.SelectedText = "";
            this.EmpContact1TB.Size = new System.Drawing.Size(300, 59);
            this.EmpContact1TB.TabIndex = 22;
            this.EmpContact1TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmpAddressTB
            // 
            this.EmpAddressTB.AcceptsTab = true;
            this.EmpAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpAddressTB.Animated = true;
            this.EmpAddressTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.EmpAddressTB.BorderThickness = 3;
            this.EmpAddressTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpAddressTB.DefaultText = "";
            this.EmpAddressTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpAddressTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpAddressTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpAddressTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpAddressTB.FillColor = System.Drawing.SystemColors.Control;
            this.EmpAddressTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpAddressTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.EmpAddressTB.ForeColor = System.Drawing.Color.Black;
            this.EmpAddressTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpAddressTB.Location = new System.Drawing.Point(737, 12);
            this.EmpAddressTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.EmpAddressTB.Name = "EmpAddressTB";
            this.EmpAddressTB.PasswordChar = '\0';
            this.EmpAddressTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.EmpAddressTB.PlaceholderText = "Address";
            this.EmpAddressTB.SelectedText = "";
            this.EmpAddressTB.Size = new System.Drawing.Size(300, 59);
            this.EmpAddressTB.TabIndex = 21;
            this.EmpAddressTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmpPositionTB
            // 
            this.EmpPositionTB.AcceptsTab = true;
            this.EmpPositionTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpPositionTB.Animated = true;
            this.EmpPositionTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.EmpPositionTB.BorderThickness = 3;
            this.EmpPositionTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPositionTB.DefaultText = "";
            this.EmpPositionTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpPositionTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpPositionTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpPositionTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpPositionTB.FillColor = System.Drawing.SystemColors.Control;
            this.EmpPositionTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPositionTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.EmpPositionTB.ForeColor = System.Drawing.Color.Black;
            this.EmpPositionTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPositionTB.Location = new System.Drawing.Point(373, 12);
            this.EmpPositionTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.EmpPositionTB.Name = "EmpPositionTB";
            this.EmpPositionTB.PasswordChar = '\0';
            this.EmpPositionTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.EmpPositionTB.PlaceholderText = "Position";
            this.EmpPositionTB.SelectedText = "";
            this.EmpPositionTB.Size = new System.Drawing.Size(300, 59);
            this.EmpPositionTB.TabIndex = 20;
            this.EmpPositionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmpNameTB
            // 
            this.EmpNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpNameTB.Animated = true;
            this.EmpNameTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.EmpNameTB.BorderThickness = 3;
            this.EmpNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpNameTB.DefaultText = "";
            this.EmpNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpNameTB.FillColor = System.Drawing.SystemColors.Control;
            this.EmpNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpNameTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.EmpNameTB.ForeColor = System.Drawing.Color.Black;
            this.EmpNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpNameTB.Location = new System.Drawing.Point(16, 12);
            this.EmpNameTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.EmpNameTB.Name = "EmpNameTB";
            this.EmpNameTB.PasswordChar = '\0';
            this.EmpNameTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.EmpNameTB.PlaceholderText = "Name";
            this.EmpNameTB.SelectedText = "";
            this.EmpNameTB.Size = new System.Drawing.Size(300, 59);
            this.EmpNameTB.TabIndex = 19;
            this.EmpNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmpDBLabel
            // 
            this.EmpDBLabel.AutoSize = true;
            this.EmpDBLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmpDBLabel.Location = new System.Drawing.Point(700, 332);
            this.EmpDBLabel.Name = "EmpDBLabel";
            this.EmpDBLabel.Size = new System.Drawing.Size(202, 28);
            this.EmpDBLabel.TabIndex = 2;
            this.EmpDBLabel.Text = "Employee List";
            // 
            // EmpDBDataGrid
            // 
            this.EmpDBDataGrid.AllowUserToAddRows = false;
            this.EmpDBDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.EmpDBDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.EmpDBDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EmpDBDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpDBDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.EmpDBDataGrid.ColumnHeadersHeight = 51;
            this.EmpDBDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpDBDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpName,
            this.EmpPosition,
            this.EmpContactNumber1,
            this.EmpContactNumber2,
            this.EmpAddress,
            this.EmpDOB});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpDBDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.EmpDBDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpDBDataGrid.Location = new System.Drawing.Point(291, 362);
            this.EmpDBDataGrid.Name = "EmpDBDataGrid";
            this.EmpDBDataGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpDBDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.EmpDBDataGrid.RowHeadersVisible = false;
            this.EmpDBDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.EmpDBDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.EmpDBDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDBDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.EmpDBDataGrid.RowTemplate.Height = 24;
            this.EmpDBDataGrid.Size = new System.Drawing.Size(1047, 368);
            this.EmpDBDataGrid.TabIndex = 19;
            this.EmpDBDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDBDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmpDBDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmpDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmpDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmpDBDataGrid.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.EmpDBDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpDBDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.EmpDBDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.EmpDBDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDBDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpDBDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpDBDataGrid.ThemeStyle.HeaderStyle.Height = 51;
            this.EmpDBDataGrid.ThemeStyle.ReadOnly = true;
            this.EmpDBDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDBDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpDBDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDBDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpDBDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.EmpDBDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpDBDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpDBDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDBDataGrid_CellContentClick);
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpID";
            this.EmpID.FillWeight = 60F;
            this.EmpID.HeaderText = "ID";
            this.EmpID.MinimumWidth = 6;
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Name";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // EmpPosition
            // 
            this.EmpPosition.DataPropertyName = "EmpPosition";
            this.EmpPosition.HeaderText = "Position";
            this.EmpPosition.MinimumWidth = 6;
            this.EmpPosition.Name = "EmpPosition";
            this.EmpPosition.ReadOnly = true;
            // 
            // EmpContactNumber1
            // 
            this.EmpContactNumber1.DataPropertyName = "EmpContactNumber1";
            this.EmpContactNumber1.HeaderText = "Contact 1";
            this.EmpContactNumber1.MinimumWidth = 6;
            this.EmpContactNumber1.Name = "EmpContactNumber1";
            this.EmpContactNumber1.ReadOnly = true;
            // 
            // EmpContactNumber2
            // 
            this.EmpContactNumber2.DataPropertyName = "EmpContactNumber2";
            this.EmpContactNumber2.HeaderText = "Contact 2";
            this.EmpContactNumber2.MinimumWidth = 6;
            this.EmpContactNumber2.Name = "EmpContactNumber2";
            this.EmpContactNumber2.ReadOnly = true;
            // 
            // EmpAddress
            // 
            this.EmpAddress.DataPropertyName = "EmpAddress";
            this.EmpAddress.HeaderText = "Address";
            this.EmpAddress.MinimumWidth = 6;
            this.EmpAddress.Name = "EmpAddress";
            this.EmpAddress.ReadOnly = true;
            // 
            // EmpDOB
            // 
            this.EmpDOB.DataPropertyName = "DOB";
            this.EmpDOB.HeaderText = "Date of Birth";
            this.EmpDOB.MinimumWidth = 6;
            this.EmpDOB.Name = "EmpDOB";
            this.EmpDOB.ReadOnly = true;
            // 
            // EmpRefreshButton
            // 
            this.EmpRefreshButton.Animated = true;
            this.EmpRefreshButton.AutoRoundedCorners = true;
            this.EmpRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.EmpRefreshButton.BorderRadius = 14;
            this.EmpRefreshButton.BorderThickness = 1;
            this.EmpRefreshButton.DefaultAutoSize = true;
            this.EmpRefreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmpRefreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmpRefreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmpRefreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmpRefreshButton.FillColor = System.Drawing.SystemColors.Control;
            this.EmpRefreshButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F);
            this.EmpRefreshButton.ForeColor = System.Drawing.Color.Black;
            this.EmpRefreshButton.IndicateFocus = true;
            this.EmpRefreshButton.Location = new System.Drawing.Point(1224, 329);
            this.EmpRefreshButton.Name = "EmpRefreshButton";
            this.EmpRefreshButton.Size = new System.Drawing.Size(114, 31);
            this.EmpRefreshButton.TabIndex = 29;
            this.EmpRefreshButton.Text = "Refresh";
            this.EmpRefreshButton.UseTransparentBackground = true;
            this.EmpRefreshButton.Click += new System.EventHandler(this.EmpRefreshButton_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.EmpRefreshButton);
            this.Controls.Add(this.EmpDBDataGrid);
            this.Controls.Add(this.EmpDBLabel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee ";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MPortalHomePanel.ResumeLayout(false);
            this.MPortalHomePanel.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.EmpDateTimePanel.ResumeLayout(false);
            this.EmpDateTimePanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.CattleDOBPanel.ResumeLayout(false);
            this.CattleDOBPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDBDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.PictureBox EmpLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel EmpDateTimePanel;
        private System.Windows.Forms.Label EmpDateLabel;
        private System.Windows.Forms.Label EmpTimeLabel;
        private System.Windows.Forms.Label EmpExitLabel;
        private System.Windows.Forms.Timer EmpTimer1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label EmpDBLabel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label EmpTimeLabell;
        private Guna.UI2.WinForms.Guna2DataGridView EmpDBDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpContactNumber1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpContactNumber2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpDOB;
        private Guna.UI2.WinForms.Guna2TextBox EmpNameTB;
        private Guna.UI2.WinForms.Guna2TextBox EmpPositionTB;
        private Guna.UI2.WinForms.Guna2TextBox EmpAddressTB;
        private Guna.UI2.WinForms.Guna2TextBox EmpContact1TB;
        private Guna.UI2.WinForms.Guna2TextBox EmpContact2TB;
        private Guna.UI2.WinForms.Guna2TextBox EmpSearchTB;
        private Guna.UI2.WinForms.Guna2Button EmpClearButton;
        private Guna.UI2.WinForms.Guna2Button EmpDeleteButton;
        private Guna.UI2.WinForms.Guna2Button EmpUpdateButton;
        private Guna.UI2.WinForms.Guna2Button EmpSaveButton;
        private Guna.UI2.WinForms.Guna2Button EmpRefreshButton;
        private System.Windows.Forms.Panel CattleDOBPanel;
        private System.Windows.Forms.DateTimePicker EmpDOBDateTimePicker;
        private System.Windows.Forms.Label EmpDOBLabel;
        private System.Windows.Forms.Panel MPortalHomePanel;
        private Guna.UI2.WinForms.Guna2ImageButton MPortalHomeIcon;
        private System.Windows.Forms.Label MPortalHomeLabel;
    }
}