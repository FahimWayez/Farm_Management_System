
namespace FarmManagement
{
    partial class Cattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cattle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CattleDOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CattleDOBLabel = new System.Windows.Forms.Label();
            this.CattleDBLabel = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.CattleWeightTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CattleSearchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CattleAgeTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CattleBreedTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CattleDOBPanel = new System.Windows.Forms.Panel();
            this.CattleColorTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MPortalHomePanel = new System.Windows.Forms.Panel();
            this.MPortalHomeIcon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.MPortalHomeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CattleClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.CattleDeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.CattleUpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.CattleSaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.CattleLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CattleDateTimePanel = new System.Windows.Forms.Panel();
            this.CattleDateLabel = new System.Windows.Forms.Label();
            this.CattleTimeLabel = new System.Windows.Forms.Label();
            this.CattleExitLabel = new System.Windows.Forms.Label();
            this.CuttleTimer1 = new System.Windows.Forms.Timer(this.components);
            this.CattleRefreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.CattleDBDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CattleAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10.SuspendLayout();
            this.CattleDOBPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MPortalHomePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CattleLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.CattleDateTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CattleDBDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CattleDOBDateTimePicker
            // 
            this.CattleDOBDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.CattleDOBDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.CattleDOBDateTimePicker.CustomFormat = "";
            this.CattleDOBDateTimePicker.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CattleDOBDateTimePicker.Location = new System.Drawing.Point(4, 31);
            this.CattleDOBDateTimePicker.Name = "CattleDOBDateTimePicker";
            this.CattleDOBDateTimePicker.Size = new System.Drawing.Size(336, 26);
            this.CattleDOBDateTimePicker.TabIndex = 15;
            this.CattleDOBDateTimePicker.Tag = "0";
            this.CattleDOBDateTimePicker.ValueChanged += new System.EventHandler(this.CattleDOBDateTimePicker_ValueChanged);
            this.CattleDOBDateTimePicker.MouseLeave += new System.EventHandler(this.CattleDOBDateTimePicker_MouseLeave);
            // 
            // CattleDOBLabel
            // 
            this.CattleDOBLabel.AutoSize = true;
            this.CattleDOBLabel.Location = new System.Drawing.Point(73, 2);
            this.CattleDOBLabel.Name = "CattleDOBLabel";
            this.CattleDOBLabel.Size = new System.Drawing.Size(195, 26);
            this.CattleDOBLabel.TabIndex = 14;
            this.CattleDOBLabel.Text = "Date of Birth";
            // 
            // CattleDBLabel
            // 
            this.CattleDBLabel.AutoSize = true;
            this.CattleDBLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CattleDBLabel.Location = new System.Drawing.Point(696, 341);
            this.CattleDBLabel.Name = "CattleDBLabel";
            this.CattleDBLabel.Size = new System.Drawing.Size(167, 28);
            this.CattleDBLabel.TabIndex = 2;
            this.CattleDBLabel.Text = "Cattle List";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.CattleWeightTB);
            this.panel10.Controls.Add(this.CattleSearchTB);
            this.panel10.Controls.Add(this.CattleAgeTB);
            this.panel10.Controls.Add(this.CattleBreedTB);
            this.panel10.Controls.Add(this.CattleDOBPanel);
            this.panel10.Controls.Add(this.CattleColorTB);
            this.panel10.Location = new System.Drawing.Point(291, 62);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1047, 276);
            this.panel10.TabIndex = 22;
            // 
            // CattleWeightTB
            // 
            this.CattleWeightTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CattleWeightTB.Animated = true;
            this.CattleWeightTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.CattleWeightTB.BorderThickness = 3;
            this.CattleWeightTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CattleWeightTB.DefaultText = "";
            this.CattleWeightTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CattleWeightTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CattleWeightTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CattleWeightTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CattleWeightTB.FillColor = System.Drawing.SystemColors.Control;
            this.CattleWeightTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CattleWeightTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.CattleWeightTB.ForeColor = System.Drawing.Color.Black;
            this.CattleWeightTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CattleWeightTB.Location = new System.Drawing.Point(649, 86);
            this.CattleWeightTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CattleWeightTB.Name = "CattleWeightTB";
            this.CattleWeightTB.PasswordChar = '\0';
            this.CattleWeightTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.CattleWeightTB.PlaceholderText = "Weight";
            this.CattleWeightTB.SelectedText = "";
            this.CattleWeightTB.Size = new System.Drawing.Size(300, 59);
            this.CattleWeightTB.TabIndex = 29;
            this.CattleWeightTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CattleSearchTB
            // 
            this.CattleSearchTB.AcceptsTab = true;
            this.CattleSearchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CattleSearchTB.Animated = true;
            this.CattleSearchTB.AutoRoundedCorners = true;
            this.CattleSearchTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.CattleSearchTB.BorderRadius = 28;
            this.CattleSearchTB.BorderThickness = 3;
            this.CattleSearchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CattleSearchTB.DefaultText = "";
            this.CattleSearchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CattleSearchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CattleSearchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CattleSearchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CattleSearchTB.FillColor = System.Drawing.SystemColors.Control;
            this.CattleSearchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CattleSearchTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.CattleSearchTB.ForeColor = System.Drawing.Color.Black;
            this.CattleSearchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CattleSearchTB.Location = new System.Drawing.Point(470, 163);
            this.CattleSearchTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CattleSearchTB.Name = "CattleSearchTB";
            this.CattleSearchTB.PasswordChar = '\0';
            this.CattleSearchTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.CattleSearchTB.PlaceholderText = "Search by Tag";
            this.CattleSearchTB.SelectedText = "";
            this.CattleSearchTB.Size = new System.Drawing.Size(572, 59);
            this.CattleSearchTB.TabIndex = 25;
            this.CattleSearchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CattleSearchTB.TextChanged += new System.EventHandler(this.CattleSearchTB_TextChanged);
            // 
            // CattleAgeTB
            // 
            this.CattleAgeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CattleAgeTB.Animated = true;
            this.CattleAgeTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.CattleAgeTB.BorderThickness = 3;
            this.CattleAgeTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CattleAgeTB.DefaultText = "";
            this.CattleAgeTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CattleAgeTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CattleAgeTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CattleAgeTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CattleAgeTB.FillColor = System.Drawing.SystemColors.Control;
            this.CattleAgeTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CattleAgeTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.CattleAgeTB.ForeColor = System.Drawing.Color.Black;
            this.CattleAgeTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CattleAgeTB.Location = new System.Drawing.Point(101, 86);
            this.CattleAgeTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CattleAgeTB.Name = "CattleAgeTB";
            this.CattleAgeTB.PasswordChar = '\0';
            this.CattleAgeTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.CattleAgeTB.PlaceholderText = "Age";
            this.CattleAgeTB.ReadOnly = true;
            this.CattleAgeTB.SelectedText = "";
            this.CattleAgeTB.Size = new System.Drawing.Size(300, 59);
            this.CattleAgeTB.TabIndex = 28;
            this.CattleAgeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CattleBreedTB
            // 
            this.CattleBreedTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CattleBreedTB.Animated = true;
            this.CattleBreedTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.CattleBreedTB.BorderThickness = 3;
            this.CattleBreedTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CattleBreedTB.DefaultText = "";
            this.CattleBreedTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CattleBreedTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CattleBreedTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CattleBreedTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CattleBreedTB.FillColor = System.Drawing.SystemColors.Control;
            this.CattleBreedTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CattleBreedTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.CattleBreedTB.ForeColor = System.Drawing.Color.Black;
            this.CattleBreedTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CattleBreedTB.Location = new System.Drawing.Point(649, 12);
            this.CattleBreedTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CattleBreedTB.Name = "CattleBreedTB";
            this.CattleBreedTB.PasswordChar = '\0';
            this.CattleBreedTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.CattleBreedTB.PlaceholderText = "Breed";
            this.CattleBreedTB.SelectedText = "";
            this.CattleBreedTB.Size = new System.Drawing.Size(300, 59);
            this.CattleBreedTB.TabIndex = 27;
            this.CattleBreedTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CattleDOBPanel
            // 
            this.CattleDOBPanel.Controls.Add(this.CattleDOBDateTimePicker);
            this.CattleDOBPanel.Controls.Add(this.CattleDOBLabel);
            this.CattleDOBPanel.Location = new System.Drawing.Point(10, 161);
            this.CattleDOBPanel.Name = "CattleDOBPanel";
            this.CattleDOBPanel.Size = new System.Drawing.Size(345, 63);
            this.CattleDOBPanel.TabIndex = 16;
            // 
            // CattleColorTB
            // 
            this.CattleColorTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CattleColorTB.Animated = true;
            this.CattleColorTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.CattleColorTB.BorderThickness = 3;
            this.CattleColorTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CattleColorTB.DefaultText = "";
            this.CattleColorTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CattleColorTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CattleColorTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CattleColorTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CattleColorTB.FillColor = System.Drawing.SystemColors.Control;
            this.CattleColorTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CattleColorTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.CattleColorTB.ForeColor = System.Drawing.Color.Black;
            this.CattleColorTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CattleColorTB.Location = new System.Drawing.Point(101, 12);
            this.CattleColorTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CattleColorTB.Name = "CattleColorTB";
            this.CattleColorTB.PasswordChar = '\0';
            this.CattleColorTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.CattleColorTB.PlaceholderText = "Color";
            this.CattleColorTB.SelectedText = "";
            this.CattleColorTB.Size = new System.Drawing.Size(300, 59);
            this.CattleColorTB.TabIndex = 26;
            this.CattleColorTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.MPortalHomePanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.AdminLabel);
            this.panel1.Controls.Add(this.CattleLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 730);
            this.panel1.TabIndex = 19;
            // 
            // MPortalHomePanel
            // 
            this.MPortalHomePanel.BackColor = System.Drawing.SystemColors.Control;
            this.MPortalHomePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MPortalHomePanel.Controls.Add(this.MPortalHomeIcon);
            this.MPortalHomePanel.Controls.Add(this.MPortalHomeLabel);
            this.MPortalHomePanel.Location = new System.Drawing.Point(3, 191);
            this.MPortalHomePanel.Name = "MPortalHomePanel";
            this.MPortalHomePanel.Size = new System.Drawing.Size(267, 95);
            this.MPortalHomePanel.TabIndex = 31;
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
            this.panel3.Controls.Add(this.CattleClearButton);
            this.panel3.Controls.Add(this.CattleDeleteButton);
            this.panel3.Controls.Add(this.CattleUpdateButton);
            this.panel3.Controls.Add(this.CattleSaveButton);
            this.panel3.Location = new System.Drawing.Point(3, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 217);
            this.panel3.TabIndex = 12;
            // 
            // CattleClearButton
            // 
            this.CattleClearButton.Animated = true;
            this.CattleClearButton.AutoRoundedCorners = true;
            this.CattleClearButton.BackColor = System.Drawing.Color.Transparent;
            this.CattleClearButton.BorderRadius = 18;
            this.CattleClearButton.BorderThickness = 3;
            this.CattleClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CattleClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CattleClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CattleClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CattleClearButton.FillColor = System.Drawing.SystemColors.Control;
            this.CattleClearButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.CattleClearButton.ForeColor = System.Drawing.Color.Black;
            this.CattleClearButton.Location = new System.Drawing.Point(62, 152);
            this.CattleClearButton.Name = "CattleClearButton";
            this.CattleClearButton.Size = new System.Drawing.Size(150, 38);
            this.CattleClearButton.TabIndex = 28;
            this.CattleClearButton.Text = "Clear";
            this.CattleClearButton.UseTransparentBackground = true;
            this.CattleClearButton.Click += new System.EventHandler(this.CattleClearButton_Click);
            // 
            // CattleDeleteButton
            // 
            this.CattleDeleteButton.Animated = true;
            this.CattleDeleteButton.AutoRoundedCorners = true;
            this.CattleDeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.CattleDeleteButton.BorderRadius = 18;
            this.CattleDeleteButton.BorderThickness = 3;
            this.CattleDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CattleDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CattleDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CattleDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CattleDeleteButton.FillColor = System.Drawing.SystemColors.Control;
            this.CattleDeleteButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.CattleDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.CattleDeleteButton.Location = new System.Drawing.Point(62, 108);
            this.CattleDeleteButton.Name = "CattleDeleteButton";
            this.CattleDeleteButton.Size = new System.Drawing.Size(150, 38);
            this.CattleDeleteButton.TabIndex = 27;
            this.CattleDeleteButton.Text = "Delete";
            this.CattleDeleteButton.UseTransparentBackground = true;
            this.CattleDeleteButton.Click += new System.EventHandler(this.CattleDeleteButton_Click);
            // 
            // CattleUpdateButton
            // 
            this.CattleUpdateButton.Animated = true;
            this.CattleUpdateButton.AutoRoundedCorners = true;
            this.CattleUpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.CattleUpdateButton.BorderRadius = 18;
            this.CattleUpdateButton.BorderThickness = 3;
            this.CattleUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CattleUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CattleUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CattleUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CattleUpdateButton.FillColor = System.Drawing.SystemColors.Control;
            this.CattleUpdateButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.CattleUpdateButton.ForeColor = System.Drawing.Color.Black;
            this.CattleUpdateButton.Location = new System.Drawing.Point(62, 64);
            this.CattleUpdateButton.Name = "CattleUpdateButton";
            this.CattleUpdateButton.Size = new System.Drawing.Size(150, 38);
            this.CattleUpdateButton.TabIndex = 26;
            this.CattleUpdateButton.Text = "Update";
            this.CattleUpdateButton.UseTransparentBackground = true;
            this.CattleUpdateButton.Click += new System.EventHandler(this.CattleUpdateButton_Click);
            // 
            // CattleSaveButton
            // 
            this.CattleSaveButton.Animated = true;
            this.CattleSaveButton.AutoRoundedCorners = true;
            this.CattleSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.CattleSaveButton.BorderRadius = 18;
            this.CattleSaveButton.BorderThickness = 3;
            this.CattleSaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CattleSaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CattleSaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CattleSaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CattleSaveButton.FillColor = System.Drawing.SystemColors.Control;
            this.CattleSaveButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.CattleSaveButton.ForeColor = System.Drawing.Color.Black;
            this.CattleSaveButton.Location = new System.Drawing.Point(62, 20);
            this.CattleSaveButton.Name = "CattleSaveButton";
            this.CattleSaveButton.Size = new System.Drawing.Size(150, 38);
            this.CattleSaveButton.TabIndex = 25;
            this.CattleSaveButton.Text = "Save";
            this.CattleSaveButton.UseTransparentBackground = true;
            this.CattleSaveButton.Click += new System.EventHandler(this.CattleSaveButton_Click);
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
            // CattleLogo
            // 
            this.CattleLogo.Image = ((System.Drawing.Image)(resources.GetObject("CattleLogo.Image")));
            this.CattleLogo.Location = new System.Drawing.Point(0, 0);
            this.CattleLogo.Name = "CattleLogo";
            this.CattleLogo.Size = new System.Drawing.Size(280, 183);
            this.CattleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CattleLogo.TabIndex = 0;
            this.CattleLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.CattleDateTimePanel);
            this.panel2.Controls.Add(this.CattleExitLabel);
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 55);
            this.panel2.TabIndex = 20;
            // 
            // CattleDateTimePanel
            // 
            this.CattleDateTimePanel.BackColor = System.Drawing.Color.Azure;
            this.CattleDateTimePanel.Controls.Add(this.CattleDateLabel);
            this.CattleDateTimePanel.Controls.Add(this.CattleTimeLabel);
            this.CattleDateTimePanel.Location = new System.Drawing.Point(10, 11);
            this.CattleDateTimePanel.Name = "CattleDateTimePanel";
            this.CattleDateTimePanel.Size = new System.Drawing.Size(1004, 33);
            this.CattleDateTimePanel.TabIndex = 6;
            // 
            // CattleDateLabel
            // 
            this.CattleDateLabel.AutoSize = true;
            this.CattleDateLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CattleDateLabel.Location = new System.Drawing.Point(5, 5);
            this.CattleDateLabel.Name = "CattleDateLabel";
            this.CattleDateLabel.Size = new System.Drawing.Size(108, 26);
            this.CattleDateLabel.TabIndex = 1;
            this.CattleDateLabel.Text = "Label2";
            // 
            // CattleTimeLabel
            // 
            this.CattleTimeLabel.AutoSize = true;
            this.CattleTimeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CattleTimeLabel.Location = new System.Drawing.Point(400, 5);
            this.CattleTimeLabel.Name = "CattleTimeLabel";
            this.CattleTimeLabel.Size = new System.Drawing.Size(108, 26);
            this.CattleTimeLabel.TabIndex = 0;
            this.CattleTimeLabel.Text = "Label1";
            // 
            // CattleExitLabel
            // 
            this.CattleExitLabel.AutoSize = true;
            this.CattleExitLabel.BackColor = System.Drawing.Color.Red;
            this.CattleExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CattleExitLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CattleExitLabel.Location = new System.Drawing.Point(1031, 0);
            this.CattleExitLabel.Name = "CattleExitLabel";
            this.CattleExitLabel.Size = new System.Drawing.Size(35, 32);
            this.CattleExitLabel.TabIndex = 4;
            this.CattleExitLabel.Text = "X";
            this.CattleExitLabel.Click += new System.EventHandler(this.CuttleExitLabel_Click);
            // 
            // CuttleTimer1
            // 
            this.CuttleTimer1.Tick += new System.EventHandler(this.CuttleTimer1_Tick);
            // 
            // CattleRefreshButton
            // 
            this.CattleRefreshButton.Animated = true;
            this.CattleRefreshButton.AutoRoundedCorners = true;
            this.CattleRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.CattleRefreshButton.BorderRadius = 14;
            this.CattleRefreshButton.BorderThickness = 1;
            this.CattleRefreshButton.DefaultAutoSize = true;
            this.CattleRefreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CattleRefreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CattleRefreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CattleRefreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CattleRefreshButton.FillColor = System.Drawing.SystemColors.Control;
            this.CattleRefreshButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F);
            this.CattleRefreshButton.ForeColor = System.Drawing.Color.Black;
            this.CattleRefreshButton.IndicateFocus = true;
            this.CattleRefreshButton.Location = new System.Drawing.Point(1221, 338);
            this.CattleRefreshButton.Name = "CattleRefreshButton";
            this.CattleRefreshButton.Size = new System.Drawing.Size(114, 31);
            this.CattleRefreshButton.TabIndex = 30;
            this.CattleRefreshButton.Text = "Refresh";
            this.CattleRefreshButton.UseTransparentBackground = true;
            this.CattleRefreshButton.Click += new System.EventHandler(this.CattleRefreshButton_Click_1);
            // 
            // CattleDBDataGrid
            // 
            this.CattleDBDataGrid.AllowUserToAddRows = false;
            this.CattleDBDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CattleDBDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CattleDBDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CattleDBDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CattleDBDataGrid.ColumnHeadersHeight = 51;
            this.CattleDBDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CattleDBDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag,
            this.Color,
            this.Breed,
            this.CattleAge,
            this.Weight,
            this.DOB});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CattleDBDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.CattleDBDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CattleDBDataGrid.Location = new System.Drawing.Point(291, 372);
            this.CattleDBDataGrid.Name = "CattleDBDataGrid";
            this.CattleDBDataGrid.ReadOnly = true;
            this.CattleDBDataGrid.RowHeadersVisible = false;
            this.CattleDBDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.CattleDBDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CattleDBDataGrid.RowTemplate.Height = 24;
            this.CattleDBDataGrid.Size = new System.Drawing.Size(1047, 358);
            this.CattleDBDataGrid.TabIndex = 31;
            this.CattleDBDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CattleDBDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CattleDBDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CattleDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CattleDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CattleDBDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CattleDBDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CattleDBDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.CattleDBDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.CattleDBDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CattleDBDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CattleDBDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CattleDBDataGrid.ThemeStyle.HeaderStyle.Height = 51;
            this.CattleDBDataGrid.ThemeStyle.ReadOnly = true;
            this.CattleDBDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CattleDBDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CattleDBDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CattleDBDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CattleDBDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.CattleDBDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CattleDBDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CattleDBDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CattleDBDataGrid_CellContentClick);
            // 
            // Tag
            // 
            this.Tag.DataPropertyName = "Tag";
            this.Tag.HeaderText = "Tag";
            this.Tag.MinimumWidth = 6;
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Breed
            // 
            this.Breed.DataPropertyName = "Breed";
            this.Breed.HeaderText = "Breed";
            this.Breed.MinimumWidth = 6;
            this.Breed.Name = "Breed";
            this.Breed.ReadOnly = true;
            // 
            // CattleAge
            // 
            this.CattleAge.DataPropertyName = "Age";
            this.CattleAge.HeaderText = "Age";
            this.CattleAge.MinimumWidth = 6;
            this.CattleAge.Name = "CattleAge";
            this.CattleAge.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "Date of Birth";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // Cattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.CattleDBDataGrid);
            this.Controls.Add(this.CattleRefreshButton);
            this.Controls.Add(this.CattleDBLabel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Cattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cuttle";
            this.Load += new System.EventHandler(this.cuttle_Load);
            this.panel10.ResumeLayout(false);
            this.CattleDOBPanel.ResumeLayout(false);
            this.CattleDOBPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MPortalHomePanel.ResumeLayout(false);
            this.MPortalHomePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CattleLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CattleDateTimePanel.ResumeLayout(false);
            this.CattleDateTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CattleDBDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker CattleDOBDateTimePicker;
        private System.Windows.Forms.Label CattleDOBLabel;
        private System.Windows.Forms.Label CattleDBLabel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel CattleDOBPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.PictureBox CattleLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CattleDateTimePanel;
        private System.Windows.Forms.Label CattleDateLabel;
        private System.Windows.Forms.Label CattleTimeLabel;
        private System.Windows.Forms.Label CattleExitLabel;
        private System.Windows.Forms.Timer CuttleTimer1;
        private Guna.UI2.WinForms.Guna2TextBox CattleSearchTB;
        private Guna.UI2.WinForms.Guna2TextBox CattleWeightTB;
        private Guna.UI2.WinForms.Guna2TextBox CattleAgeTB;
        private Guna.UI2.WinForms.Guna2TextBox CattleBreedTB;
        private Guna.UI2.WinForms.Guna2TextBox CattleColorTB;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button CattleClearButton;
        private Guna.UI2.WinForms.Guna2Button CattleDeleteButton;
        private Guna.UI2.WinForms.Guna2Button CattleUpdateButton;
        private Guna.UI2.WinForms.Guna2Button CattleSaveButton;
        private Guna.UI2.WinForms.Guna2Button CattleRefreshButton;
        private Guna.UI2.WinForms.Guna2DataGridView CattleDBDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CattleAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.Panel MPortalHomePanel;
        private Guna.UI2.WinForms.Guna2ImageButton MPortalHomeIcon;
        private System.Windows.Forms.Label MPortalHomeLabel;
    }
}