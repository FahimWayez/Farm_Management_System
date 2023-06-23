
namespace FarmManagement
{
    partial class Availability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Availability));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AvaBuyNowPb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AvaBuyNowLabel = new System.Windows.Forms.Label();
            this.MPortalHomePanel = new System.Windows.Forms.Panel();
            this.AvaHomeIcon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AvaHomeLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CPortalLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CPortalDateTimePanel = new System.Windows.Forms.Panel();
            this.AvaDateLabel = new System.Windows.Forms.Label();
            this.AvaTimeLabel = new System.Windows.Forms.Label();
            this.CPortalLogoutPanel = new System.Windows.Forms.Panel();
            this.AvaLogoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.AvaLogoutIcon = new System.Windows.Forms.PictureBox();
            this.AvaExitLabel = new System.Windows.Forms.Label();
            this.CPortalWelcomeLabel = new System.Windows.Forms.Label();
            this.AvaTimer1 = new System.Windows.Forms.Timer(this.components);
            this.AvaDBDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvaRefreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.AvaDBLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvaBuyNowPb)).BeginInit();
            this.MPortalHomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPortalLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.CPortalDateTimePanel.SuspendLayout();
            this.CPortalLogoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvaLogoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvaDBDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.AvaBuyNowPb);
            this.panel1.Controls.Add(this.AvaBuyNowLabel);
            this.panel1.Controls.Add(this.MPortalHomePanel);
            this.panel1.Controls.Add(this.CustomerLabel);
            this.panel1.Controls.Add(this.CPortalLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 730);
            this.panel1.TabIndex = 7;
            // 
            // AvaBuyNowPb
            // 
            this.AvaBuyNowPb.Image = ((System.Drawing.Image)(resources.GetObject("AvaBuyNowPb.Image")));
            this.AvaBuyNowPb.ImageRotate = 0F;
            this.AvaBuyNowPb.Location = new System.Drawing.Point(31, 358);
            this.AvaBuyNowPb.Name = "AvaBuyNowPb";
            this.AvaBuyNowPb.Size = new System.Drawing.Size(212, 178);
            this.AvaBuyNowPb.TabIndex = 7;
            this.AvaBuyNowPb.TabStop = false;
            this.AvaBuyNowPb.Click += new System.EventHandler(this.AvaBuyNowPb_Click);
            // 
            // AvaBuyNowLabel
            // 
            this.AvaBuyNowLabel.AutoSize = true;
            this.AvaBuyNowLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaBuyNowLabel.Location = new System.Drawing.Point(46, 539);
            this.AvaBuyNowLabel.Name = "AvaBuyNowLabel";
            this.AvaBuyNowLabel.Size = new System.Drawing.Size(234, 74);
            this.AvaBuyNowLabel.TabIndex = 1;
            this.AvaBuyNowLabel.Text = "Click here \r\nto buy now!\r\n";
            this.AvaBuyNowLabel.Click += new System.EventHandler(this.AvaBuyNowLabel_Click);
            // 
            // MPortalHomePanel
            // 
            this.MPortalHomePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MPortalHomePanel.Controls.Add(this.AvaHomeIcon);
            this.MPortalHomePanel.Controls.Add(this.AvaHomeLabel);
            this.MPortalHomePanel.Location = new System.Drawing.Point(6, 186);
            this.MPortalHomePanel.Name = "MPortalHomePanel";
            this.MPortalHomePanel.Size = new System.Drawing.Size(267, 95);
            this.MPortalHomePanel.TabIndex = 6;
            // 
            // AvaHomeIcon
            // 
            this.AvaHomeIcon.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AvaHomeIcon.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.AvaHomeIcon.HoverState.ImageSize = new System.Drawing.Size(170, 100);
            this.AvaHomeIcon.Image = ((System.Drawing.Image)(resources.GetObject("AvaHomeIcon.Image")));
            this.AvaHomeIcon.ImageOffset = new System.Drawing.Point(0, 0);
            this.AvaHomeIcon.ImageRotate = 0F;
            this.AvaHomeIcon.ImageSize = new System.Drawing.Size(160, 90);
            this.AvaHomeIcon.IndicateFocus = true;
            this.AvaHomeIcon.Location = new System.Drawing.Point(-2, -2);
            this.AvaHomeIcon.Name = "AvaHomeIcon";
            this.AvaHomeIcon.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.AvaHomeIcon.PressedState.ImageSize = new System.Drawing.Size(170, 100);
            this.AvaHomeIcon.Size = new System.Drawing.Size(160, 90);
            this.AvaHomeIcon.TabIndex = 18;
            this.AvaHomeIcon.Click += new System.EventHandler(this.AvaHomeIcon_Click);
            // 
            // AvaHomeLabel
            // 
            this.AvaHomeLabel.AutoSize = true;
            this.AvaHomeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaHomeLabel.Location = new System.Drawing.Point(176, 32);
            this.AvaHomeLabel.Name = "AvaHomeLabel";
            this.AvaHomeLabel.Size = new System.Drawing.Size(85, 26);
            this.AvaHomeLabel.TabIndex = 1;
            this.AvaHomeLabel.Text = "Home";
            this.AvaHomeLabel.Click += new System.EventHandler(this.AvaHomeLabel_Click);
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
            this.panel2.Controls.Add(this.AvaExitLabel);
            this.panel2.Controls.Add(this.CPortalWelcomeLabel);
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 183);
            this.panel2.TabIndex = 8;
            // 
            // CPortalDateTimePanel
            // 
            this.CPortalDateTimePanel.BackColor = System.Drawing.Color.Azure;
            this.CPortalDateTimePanel.Controls.Add(this.AvaDateLabel);
            this.CPortalDateTimePanel.Controls.Add(this.AvaTimeLabel);
            this.CPortalDateTimePanel.Location = new System.Drawing.Point(3, 102);
            this.CPortalDateTimePanel.Name = "CPortalDateTimePanel";
            this.CPortalDateTimePanel.Size = new System.Drawing.Size(891, 33);
            this.CPortalDateTimePanel.TabIndex = 6;
            // 
            // AvaDateLabel
            // 
            this.AvaDateLabel.AutoSize = true;
            this.AvaDateLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaDateLabel.Location = new System.Drawing.Point(5, 5);
            this.AvaDateLabel.Name = "AvaDateLabel";
            this.AvaDateLabel.Size = new System.Drawing.Size(108, 26);
            this.AvaDateLabel.TabIndex = 1;
            this.AvaDateLabel.Text = "Label2";
            // 
            // AvaTimeLabel
            // 
            this.AvaTimeLabel.AutoSize = true;
            this.AvaTimeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaTimeLabel.Location = new System.Drawing.Point(400, 5);
            this.AvaTimeLabel.Name = "AvaTimeLabel";
            this.AvaTimeLabel.Size = new System.Drawing.Size(108, 26);
            this.AvaTimeLabel.TabIndex = 0;
            this.AvaTimeLabel.Text = "Label1";
            // 
            // CPortalLogoutPanel
            // 
            this.CPortalLogoutPanel.BackColor = System.Drawing.Color.Azure;
            this.CPortalLogoutPanel.Controls.Add(this.AvaLogoutButton);
            this.CPortalLogoutPanel.Controls.Add(this.AvaLogoutIcon);
            this.CPortalLogoutPanel.Location = new System.Drawing.Point(891, 102);
            this.CPortalLogoutPanel.Name = "CPortalLogoutPanel";
            this.CPortalLogoutPanel.Size = new System.Drawing.Size(178, 33);
            this.CPortalLogoutPanel.TabIndex = 12;
            // 
            // AvaLogoutButton
            // 
            this.AvaLogoutButton.Animated = true;
            this.AvaLogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.AvaLogoutButton.BorderThickness = 1;
            this.AvaLogoutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AvaLogoutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AvaLogoutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AvaLogoutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AvaLogoutButton.FillColor = System.Drawing.SystemColors.Control;
            this.AvaLogoutButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F);
            this.AvaLogoutButton.ForeColor = System.Drawing.Color.Black;
            this.AvaLogoutButton.Location = new System.Drawing.Point(50, 0);
            this.AvaLogoutButton.Name = "AvaLogoutButton";
            this.AvaLogoutButton.Size = new System.Drawing.Size(125, 31);
            this.AvaLogoutButton.TabIndex = 34;
            this.AvaLogoutButton.Text = "Sign Out";
            this.AvaLogoutButton.Click += new System.EventHandler(this.AvaLogoutButton_Click);
            // 
            // AvaLogoutIcon
            // 
            this.AvaLogoutIcon.Image = ((System.Drawing.Image)(resources.GetObject("AvaLogoutIcon.Image")));
            this.AvaLogoutIcon.Location = new System.Drawing.Point(0, 0);
            this.AvaLogoutIcon.Name = "AvaLogoutIcon";
            this.AvaLogoutIcon.Size = new System.Drawing.Size(49, 31);
            this.AvaLogoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvaLogoutIcon.TabIndex = 32;
            this.AvaLogoutIcon.TabStop = false;
            this.AvaLogoutIcon.Click += new System.EventHandler(this.AvaLogoutIcon_Click);
            // 
            // AvaExitLabel
            // 
            this.AvaExitLabel.AutoSize = true;
            this.AvaExitLabel.BackColor = System.Drawing.Color.Red;
            this.AvaExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaExitLabel.Location = new System.Drawing.Point(1034, 0);
            this.AvaExitLabel.Name = "AvaExitLabel";
            this.AvaExitLabel.Size = new System.Drawing.Size(35, 32);
            this.AvaExitLabel.TabIndex = 4;
            this.AvaExitLabel.Text = "X";
            this.AvaExitLabel.Click += new System.EventHandler(this.AvaExitLabel_Click);
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
            // AvaTimer1
            // 
            this.AvaTimer1.Tick += new System.EventHandler(this.AvaTimer1_Tick);
            // 
            // AvaDBDataGrid
            // 
            this.AvaDBDataGrid.AllowUserToAddRows = false;
            this.AvaDBDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.AvaDBDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.AvaDBDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AvaDBDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AvaDBDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.AvaDBDataGrid.ColumnHeadersHeight = 54;
            this.AvaDBDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AvaDBDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdID,
            this.Tag,
            this.TypeOfProduct,
            this.Quantity,
            this.UnitPrice,
            this.Date});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AvaDBDataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.AvaDBDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AvaDBDataGrid.Location = new System.Drawing.Point(284, 246);
            this.AvaDBDataGrid.Name = "AvaDBDataGrid";
            this.AvaDBDataGrid.ReadOnly = true;
            this.AvaDBDataGrid.RowHeadersVisible = false;
            this.AvaDBDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.AvaDBDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.AvaDBDataGrid.RowTemplate.Height = 24;
            this.AvaDBDataGrid.Size = new System.Drawing.Size(1063, 472);
            this.AvaDBDataGrid.TabIndex = 38;
            this.AvaDBDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AvaDBDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AvaDBDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AvaDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AvaDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AvaDBDataGrid.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.AvaDBDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AvaDBDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AvaDBDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.AvaDBDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaDBDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AvaDBDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AvaDBDataGrid.ThemeStyle.HeaderStyle.Height = 54;
            this.AvaDBDataGrid.ThemeStyle.ReadOnly = true;
            this.AvaDBDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AvaDBDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AvaDBDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaDBDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AvaDBDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.AvaDBDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AvaDBDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.Tag.Visible = false;
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
            this.Quantity.HeaderText = "Availability";
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
            // AvaRefreshButton
            // 
            this.AvaRefreshButton.Animated = true;
            this.AvaRefreshButton.AutoRoundedCorners = true;
            this.AvaRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.AvaRefreshButton.BorderRadius = 14;
            this.AvaRefreshButton.BorderThickness = 1;
            this.AvaRefreshButton.DefaultAutoSize = true;
            this.AvaRefreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AvaRefreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AvaRefreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AvaRefreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AvaRefreshButton.FillColor = System.Drawing.SystemColors.Control;
            this.AvaRefreshButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F);
            this.AvaRefreshButton.ForeColor = System.Drawing.Color.Black;
            this.AvaRefreshButton.IndicateFocus = true;
            this.AvaRefreshButton.Location = new System.Drawing.Point(1224, 190);
            this.AvaRefreshButton.Name = "AvaRefreshButton";
            this.AvaRefreshButton.Size = new System.Drawing.Size(114, 31);
            this.AvaRefreshButton.TabIndex = 40;
            this.AvaRefreshButton.Text = "Refresh";
            this.AvaRefreshButton.UseTransparentBackground = true;
            this.AvaRefreshButton.Click += new System.EventHandler(this.AvaRefreshButton_Click);
            // 
            // AvaDBLabel
            // 
            this.AvaDBLabel.AutoSize = true;
            this.AvaDBLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AvaDBLabel.Location = new System.Drawing.Point(639, 196);
            this.AvaDBLabel.Name = "AvaDBLabel";
            this.AvaDBLabel.Size = new System.Drawing.Size(349, 28);
            this.AvaDBLabel.TabIndex = 39;
            this.AvaDBLabel.Text = "availability of Products";
            // 
            // Availability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.AvaDBDataGrid);
            this.Controls.Add(this.AvaRefreshButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AvaDBLabel);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Availability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Availability";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvaBuyNowPb)).EndInit();
            this.MPortalHomePanel.ResumeLayout(false);
            this.MPortalHomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPortalLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CPortalDateTimePanel.ResumeLayout(false);
            this.CPortalDateTimePanel.PerformLayout();
            this.CPortalLogoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvaLogoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvaDBDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.PictureBox CPortalLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CPortalDateTimePanel;
        private System.Windows.Forms.Label AvaDateLabel;
        private System.Windows.Forms.Label AvaTimeLabel;
        private System.Windows.Forms.Panel CPortalLogoutPanel;
        private Guna.UI2.WinForms.Guna2Button AvaLogoutButton;
        private System.Windows.Forms.PictureBox AvaLogoutIcon;
        private System.Windows.Forms.Label AvaExitLabel;
        private System.Windows.Forms.Label CPortalWelcomeLabel;
        private System.Windows.Forms.Panel MPortalHomePanel;
        private Guna.UI2.WinForms.Guna2ImageButton AvaHomeIcon;
        private System.Windows.Forms.Label AvaHomeLabel;
        private System.Windows.Forms.Timer AvaTimer1;
        private Guna.UI2.WinForms.Guna2DataGridView AvaDBDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private Guna.UI2.WinForms.Guna2Button AvaRefreshButton;
        private System.Windows.Forms.Label AvaDBLabel;
        private Guna.UI2.WinForms.Guna2PictureBox AvaBuyNowPb;
        private System.Windows.Forms.Label AvaBuyNowLabel;
    }
}