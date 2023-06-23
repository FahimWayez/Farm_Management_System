
namespace FarmManagement
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SalesDateLabel = new System.Windows.Forms.Label();
            this.SalesTimer1 = new System.Windows.Forms.Timer(this.components);
            this.SalesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SalesDateLabe = new System.Windows.Forms.Label();
            this.SalesCusIDLabel = new System.Windows.Forms.Label();
            this.SalesDBLabel = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.SalesTotalPriceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.SalesUnitPriceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.SalesQuantityTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.SalesTagComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SalesTagLabel = new System.Windows.Forms.Label();
            this.SalesSearchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.SalesCusIDComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SalesDatePanel = new System.Windows.Forms.Panel();
            this.SalesExitLabel = new System.Windows.Forms.Label();
            this.SalesTimeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MPortalHomePanel = new System.Windows.Forms.Panel();
            this.MPortalHomeIcon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.MPortalHomeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SalesClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.SalesDeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.SalesUpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.SalesSaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.SalesLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SalesDateTimePanel = new System.Windows.Forms.Panel();
            this.SalesRefreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.SalesDBDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10.SuspendLayout();
            this.SalesDatePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MPortalHomePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SalesDateTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDBDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesDateLabel
            // 
            this.SalesDateLabel.AutoSize = true;
            this.SalesDateLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDateLabel.Location = new System.Drawing.Point(5, 5);
            this.SalesDateLabel.Name = "SalesDateLabel";
            this.SalesDateLabel.Size = new System.Drawing.Size(108, 26);
            this.SalesDateLabel.TabIndex = 1;
            this.SalesDateLabel.Text = "Label2";
            // 
            // SalesTimer1
            // 
            this.SalesTimer1.Tick += new System.EventHandler(this.SalesTimer1_Tick);
            // 
            // SalesDateTimePicker
            // 
            this.SalesDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.SalesDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.SalesDateTimePicker.CustomFormat = "";
            this.SalesDateTimePicker.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDateTimePicker.Location = new System.Drawing.Point(3, 31);
            this.SalesDateTimePicker.Name = "SalesDateTimePicker";
            this.SalesDateTimePicker.Size = new System.Drawing.Size(336, 26);
            this.SalesDateTimePicker.TabIndex = 15;
            this.SalesDateTimePicker.Tag = "0";
            // 
            // SalesDateLabe
            // 
            this.SalesDateLabe.AutoSize = true;
            this.SalesDateLabe.Location = new System.Drawing.Point(123, 2);
            this.SalesDateLabe.Name = "SalesDateLabe";
            this.SalesDateLabe.Size = new System.Drawing.Size(78, 26);
            this.SalesDateLabe.TabIndex = 14;
            this.SalesDateLabe.Text = "Date";
            // 
            // SalesCusIDLabel
            // 
            this.SalesCusIDLabel.AutoSize = true;
            this.SalesCusIDLabel.Location = new System.Drawing.Point(41, 10);
            this.SalesCusIDLabel.Name = "SalesCusIDLabel";
            this.SalesCusIDLabel.Size = new System.Drawing.Size(180, 26);
            this.SalesCusIDLabel.TabIndex = 12;
            this.SalesCusIDLabel.Text = "Customer ID";
            // 
            // SalesDBLabel
            // 
            this.SalesDBLabel.AutoSize = true;
            this.SalesDBLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SalesDBLabel.Location = new System.Drawing.Point(696, 297);
            this.SalesDBLabel.Name = "SalesDBLabel";
            this.SalesDBLabel.Size = new System.Drawing.Size(200, 28);
            this.SalesDBLabel.TabIndex = 2;
            this.SalesDBLabel.Text = "Sales Details";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.SalesTotalPriceTB);
            this.panel10.Controls.Add(this.SalesUnitPriceTB);
            this.panel10.Controls.Add(this.SalesQuantityTB);
            this.panel10.Controls.Add(this.SalesTagComboBox);
            this.panel10.Controls.Add(this.SalesTagLabel);
            this.panel10.Controls.Add(this.SalesSearchTB);
            this.panel10.Controls.Add(this.SalesCusIDComboBox);
            this.panel10.Controls.Add(this.SalesDatePanel);
            this.panel10.Controls.Add(this.SalesCusIDLabel);
            this.panel10.Location = new System.Drawing.Point(291, 62);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1047, 232);
            this.panel10.TabIndex = 30;
            // 
            // SalesTotalPriceTB
            // 
            this.SalesTotalPriceTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesTotalPriceTB.Animated = true;
            this.SalesTotalPriceTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.SalesTotalPriceTB.BorderThickness = 3;
            this.SalesTotalPriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalesTotalPriceTB.DefaultText = "";
            this.SalesTotalPriceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SalesTotalPriceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SalesTotalPriceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalesTotalPriceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalesTotalPriceTB.FillColor = System.Drawing.SystemColors.Control;
            this.SalesTotalPriceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesTotalPriceTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.SalesTotalPriceTB.ForeColor = System.Drawing.Color.Black;
            this.SalesTotalPriceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesTotalPriceTB.Location = new System.Drawing.Point(591, 96);
            this.SalesTotalPriceTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SalesTotalPriceTB.Name = "SalesTotalPriceTB";
            this.SalesTotalPriceTB.PasswordChar = '\0';
            this.SalesTotalPriceTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.SalesTotalPriceTB.PlaceholderText = "Total Price";
            this.SalesTotalPriceTB.SelectedText = "";
            this.SalesTotalPriceTB.Size = new System.Drawing.Size(250, 36);
            this.SalesTotalPriceTB.TabIndex = 43;
            this.SalesTotalPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SalesTotalPriceTB.Leave += new System.EventHandler(this.SalesTotalPriceTB_Leave);
            // 
            // SalesUnitPriceTB
            // 
            this.SalesUnitPriceTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesUnitPriceTB.Animated = true;
            this.SalesUnitPriceTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.SalesUnitPriceTB.BorderThickness = 3;
            this.SalesUnitPriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalesUnitPriceTB.DefaultText = "";
            this.SalesUnitPriceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SalesUnitPriceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SalesUnitPriceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalesUnitPriceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalesUnitPriceTB.FillColor = System.Drawing.SystemColors.Control;
            this.SalesUnitPriceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesUnitPriceTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.SalesUnitPriceTB.ForeColor = System.Drawing.Color.Black;
            this.SalesUnitPriceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesUnitPriceTB.Location = new System.Drawing.Point(220, 96);
            this.SalesUnitPriceTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SalesUnitPriceTB.Name = "SalesUnitPriceTB";
            this.SalesUnitPriceTB.PasswordChar = '\0';
            this.SalesUnitPriceTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.SalesUnitPriceTB.PlaceholderText = "Unit Price";
            this.SalesUnitPriceTB.SelectedText = "";
            this.SalesUnitPriceTB.Size = new System.Drawing.Size(250, 36);
            this.SalesUnitPriceTB.TabIndex = 42;
            this.SalesUnitPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesQuantityTB
            // 
            this.SalesQuantityTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesQuantityTB.Animated = true;
            this.SalesQuantityTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.SalesQuantityTB.BorderThickness = 3;
            this.SalesQuantityTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalesQuantityTB.DefaultText = "";
            this.SalesQuantityTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SalesQuantityTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SalesQuantityTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalesQuantityTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalesQuantityTB.FillColor = System.Drawing.SystemColors.Control;
            this.SalesQuantityTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesQuantityTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.SalesQuantityTB.ForeColor = System.Drawing.Color.Black;
            this.SalesQuantityTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesQuantityTB.Location = new System.Drawing.Point(779, 39);
            this.SalesQuantityTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SalesQuantityTB.Name = "SalesQuantityTB";
            this.SalesQuantityTB.PasswordChar = '\0';
            this.SalesQuantityTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.SalesQuantityTB.PlaceholderText = "Quantity";
            this.SalesQuantityTB.SelectedText = "";
            this.SalesQuantityTB.Size = new System.Drawing.Size(250, 36);
            this.SalesQuantityTB.TabIndex = 41;
            this.SalesQuantityTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesTagComboBox
            // 
            this.SalesTagComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SalesTagComboBox.BorderColor = System.Drawing.Color.SkyBlue;
            this.SalesTagComboBox.BorderThickness = 3;
            this.SalesTagComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SalesTagComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SalesTagComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesTagComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesTagComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SalesTagComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SalesTagComboBox.ItemHeight = 30;
            this.SalesTagComboBox.Location = new System.Drawing.Point(418, 39);
            this.SalesTagComboBox.Name = "SalesTagComboBox";
            this.SalesTagComboBox.Size = new System.Drawing.Size(250, 36);
            this.SalesTagComboBox.TabIndex = 40;
            this.SalesTagComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesTagLabel
            // 
            this.SalesTagLabel.AutoSize = true;
            this.SalesTagLabel.Location = new System.Drawing.Point(502, 10);
            this.SalesTagLabel.Name = "SalesTagLabel";
            this.SalesTagLabel.Size = new System.Drawing.Size(62, 26);
            this.SalesTagLabel.TabIndex = 39;
            this.SalesTagLabel.Text = "Tag";
            // 
            // SalesSearchTB
            // 
            this.SalesSearchTB.AcceptsTab = true;
            this.SalesSearchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesSearchTB.Animated = true;
            this.SalesSearchTB.AutoRoundedCorners = true;
            this.SalesSearchTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.SalesSearchTB.BorderRadius = 23;
            this.SalesSearchTB.BorderThickness = 3;
            this.SalesSearchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalesSearchTB.DefaultText = "";
            this.SalesSearchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SalesSearchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SalesSearchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalesSearchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalesSearchTB.FillColor = System.Drawing.SystemColors.Control;
            this.SalesSearchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesSearchTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.SalesSearchTB.ForeColor = System.Drawing.Color.Black;
            this.SalesSearchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesSearchTB.Location = new System.Drawing.Point(470, 173);
            this.SalesSearchTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SalesSearchTB.Name = "SalesSearchTB";
            this.SalesSearchTB.PasswordChar = '\0';
            this.SalesSearchTB.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.SalesSearchTB.PlaceholderText = "Search by Order ID";
            this.SalesSearchTB.SelectedText = "";
            this.SalesSearchTB.Size = new System.Drawing.Size(572, 49);
            this.SalesSearchTB.TabIndex = 38;
            this.SalesSearchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SalesSearchTB.TextChanged += new System.EventHandler(this.SalesSearchTB_TextChanged);
            // 
            // SalesCusIDComboBox
            // 
            this.SalesCusIDComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SalesCusIDComboBox.BorderColor = System.Drawing.Color.SkyBlue;
            this.SalesCusIDComboBox.BorderThickness = 3;
            this.SalesCusIDComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SalesCusIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SalesCusIDComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesCusIDComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalesCusIDComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SalesCusIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SalesCusIDComboBox.ItemHeight = 30;
            this.SalesCusIDComboBox.Location = new System.Drawing.Point(11, 39);
            this.SalesCusIDComboBox.Name = "SalesCusIDComboBox";
            this.SalesCusIDComboBox.Size = new System.Drawing.Size(250, 36);
            this.SalesCusIDComboBox.TabIndex = 38;
            this.SalesCusIDComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesDatePanel
            // 
            this.SalesDatePanel.Controls.Add(this.SalesDateTimePicker);
            this.SalesDatePanel.Controls.Add(this.SalesDateLabe);
            this.SalesDatePanel.Location = new System.Drawing.Point(8, 164);
            this.SalesDatePanel.Name = "SalesDatePanel";
            this.SalesDatePanel.Size = new System.Drawing.Size(339, 58);
            this.SalesDatePanel.TabIndex = 16;
            // 
            // SalesExitLabel
            // 
            this.SalesExitLabel.AutoSize = true;
            this.SalesExitLabel.BackColor = System.Drawing.Color.Red;
            this.SalesExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesExitLabel.Location = new System.Drawing.Point(1034, 0);
            this.SalesExitLabel.Name = "SalesExitLabel";
            this.SalesExitLabel.Size = new System.Drawing.Size(35, 32);
            this.SalesExitLabel.TabIndex = 4;
            this.SalesExitLabel.Text = "X";
            this.SalesExitLabel.Click += new System.EventHandler(this.SalesExitLabel_Click);
            // 
            // SalesTimeLabel
            // 
            this.SalesTimeLabel.AutoSize = true;
            this.SalesTimeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTimeLabel.Location = new System.Drawing.Point(400, 5);
            this.SalesTimeLabel.Name = "SalesTimeLabel";
            this.SalesTimeLabel.Size = new System.Drawing.Size(108, 26);
            this.SalesTimeLabel.TabIndex = 0;
            this.SalesTimeLabel.Text = "Label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.MPortalHomePanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.AdminLabel);
            this.panel1.Controls.Add(this.SalesLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 730);
            this.panel1.TabIndex = 27;
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
            this.MPortalHomePanel.TabIndex = 30;
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
            this.panel3.Controls.Add(this.SalesClearButton);
            this.panel3.Controls.Add(this.SalesDeleteButton);
            this.panel3.Controls.Add(this.SalesUpdateButton);
            this.panel3.Controls.Add(this.SalesSaveButton);
            this.panel3.Location = new System.Drawing.Point(3, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 217);
            this.panel3.TabIndex = 31;
            // 
            // SalesClearButton
            // 
            this.SalesClearButton.Animated = true;
            this.SalesClearButton.AutoRoundedCorners = true;
            this.SalesClearButton.BackColor = System.Drawing.Color.Transparent;
            this.SalesClearButton.BorderRadius = 18;
            this.SalesClearButton.BorderThickness = 3;
            this.SalesClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SalesClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SalesClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SalesClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SalesClearButton.FillColor = System.Drawing.SystemColors.Control;
            this.SalesClearButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.SalesClearButton.ForeColor = System.Drawing.Color.Black;
            this.SalesClearButton.Location = new System.Drawing.Point(62, 152);
            this.SalesClearButton.Name = "SalesClearButton";
            this.SalesClearButton.Size = new System.Drawing.Size(150, 38);
            this.SalesClearButton.TabIndex = 28;
            this.SalesClearButton.Text = "Clear";
            this.SalesClearButton.UseTransparentBackground = true;
            this.SalesClearButton.Click += new System.EventHandler(this.SalesClearButton_Click);
            // 
            // SalesDeleteButton
            // 
            this.SalesDeleteButton.Animated = true;
            this.SalesDeleteButton.AutoRoundedCorners = true;
            this.SalesDeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.SalesDeleteButton.BorderRadius = 18;
            this.SalesDeleteButton.BorderThickness = 3;
            this.SalesDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SalesDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SalesDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SalesDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SalesDeleteButton.FillColor = System.Drawing.SystemColors.Control;
            this.SalesDeleteButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.SalesDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.SalesDeleteButton.Location = new System.Drawing.Point(62, 108);
            this.SalesDeleteButton.Name = "SalesDeleteButton";
            this.SalesDeleteButton.Size = new System.Drawing.Size(150, 38);
            this.SalesDeleteButton.TabIndex = 27;
            this.SalesDeleteButton.Text = "Delete";
            this.SalesDeleteButton.UseTransparentBackground = true;
            this.SalesDeleteButton.Click += new System.EventHandler(this.SalesDeleteButton_Click);
            // 
            // SalesUpdateButton
            // 
            this.SalesUpdateButton.Animated = true;
            this.SalesUpdateButton.AutoRoundedCorners = true;
            this.SalesUpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.SalesUpdateButton.BorderRadius = 18;
            this.SalesUpdateButton.BorderThickness = 3;
            this.SalesUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SalesUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SalesUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SalesUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SalesUpdateButton.FillColor = System.Drawing.SystemColors.Control;
            this.SalesUpdateButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.SalesUpdateButton.ForeColor = System.Drawing.Color.Black;
            this.SalesUpdateButton.Location = new System.Drawing.Point(62, 64);
            this.SalesUpdateButton.Name = "SalesUpdateButton";
            this.SalesUpdateButton.Size = new System.Drawing.Size(150, 38);
            this.SalesUpdateButton.TabIndex = 26;
            this.SalesUpdateButton.Text = "Update";
            this.SalesUpdateButton.UseTransparentBackground = true;
            this.SalesUpdateButton.Click += new System.EventHandler(this.SalesUpdateButton_Click);
            // 
            // SalesSaveButton
            // 
            this.SalesSaveButton.Animated = true;
            this.SalesSaveButton.AutoRoundedCorners = true;
            this.SalesSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SalesSaveButton.BorderRadius = 18;
            this.SalesSaveButton.BorderThickness = 3;
            this.SalesSaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SalesSaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SalesSaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SalesSaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SalesSaveButton.FillColor = System.Drawing.SystemColors.Control;
            this.SalesSaveButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F);
            this.SalesSaveButton.ForeColor = System.Drawing.Color.Black;
            this.SalesSaveButton.Location = new System.Drawing.Point(62, 20);
            this.SalesSaveButton.Name = "SalesSaveButton";
            this.SalesSaveButton.Size = new System.Drawing.Size(150, 38);
            this.SalesSaveButton.TabIndex = 25;
            this.SalesSaveButton.Text = "Save";
            this.SalesSaveButton.UseTransparentBackground = true;
            this.SalesSaveButton.Click += new System.EventHandler(this.SalesSaveButton_Click);
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
            // SalesLogo
            // 
            this.SalesLogo.Image = ((System.Drawing.Image)(resources.GetObject("SalesLogo.Image")));
            this.SalesLogo.Location = new System.Drawing.Point(0, 0);
            this.SalesLogo.Name = "SalesLogo";
            this.SalesLogo.Size = new System.Drawing.Size(280, 183);
            this.SalesLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalesLogo.TabIndex = 0;
            this.SalesLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.SalesDateTimePanel);
            this.panel2.Controls.Add(this.SalesExitLabel);
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 55);
            this.panel2.TabIndex = 28;
            // 
            // SalesDateTimePanel
            // 
            this.SalesDateTimePanel.BackColor = System.Drawing.Color.Azure;
            this.SalesDateTimePanel.Controls.Add(this.SalesDateLabel);
            this.SalesDateTimePanel.Controls.Add(this.SalesTimeLabel);
            this.SalesDateTimePanel.Location = new System.Drawing.Point(10, 11);
            this.SalesDateTimePanel.Name = "SalesDateTimePanel";
            this.SalesDateTimePanel.Size = new System.Drawing.Size(1004, 33);
            this.SalesDateTimePanel.TabIndex = 6;
            // 
            // SalesRefreshButton
            // 
            this.SalesRefreshButton.Animated = true;
            this.SalesRefreshButton.AutoRoundedCorners = true;
            this.SalesRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.SalesRefreshButton.BorderRadius = 14;
            this.SalesRefreshButton.BorderThickness = 1;
            this.SalesRefreshButton.DefaultAutoSize = true;
            this.SalesRefreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SalesRefreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SalesRefreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SalesRefreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SalesRefreshButton.FillColor = System.Drawing.SystemColors.Control;
            this.SalesRefreshButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F);
            this.SalesRefreshButton.ForeColor = System.Drawing.Color.Black;
            this.SalesRefreshButton.IndicateFocus = true;
            this.SalesRefreshButton.Location = new System.Drawing.Point(1224, 300);
            this.SalesRefreshButton.Name = "SalesRefreshButton";
            this.SalesRefreshButton.Size = new System.Drawing.Size(114, 31);
            this.SalesRefreshButton.TabIndex = 31;
            this.SalesRefreshButton.Text = "Refresh";
            this.SalesRefreshButton.UseTransparentBackground = true;
            this.SalesRefreshButton.Click += new System.EventHandler(this.SalesRefreshButton_Click);
            // 
            // SalesDBDataGrid
            // 
            this.SalesDBDataGrid.AllowUserToAddRows = false;
            this.SalesDBDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SalesDBDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SalesDBDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesDBDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SalesDBDataGrid.ColumnHeadersHeight = 47;
            this.SalesDBDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SalesDBDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CustomerID,
            this.Tag,
            this.Quantity,
            this.UnitPrice,
            this.TotalPrice,
            this.Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesDBDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.SalesDBDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesDBDataGrid.Location = new System.Drawing.Point(291, 332);
            this.SalesDBDataGrid.Name = "SalesDBDataGrid";
            this.SalesDBDataGrid.ReadOnly = true;
            this.SalesDBDataGrid.RowHeadersVisible = false;
            this.SalesDBDataGrid.RowHeadersWidth = 51;
            this.SalesDBDataGrid.RowTemplate.Height = 24;
            this.SalesDBDataGrid.Size = new System.Drawing.Size(1047, 398);
            this.SalesDBDataGrid.TabIndex = 34;
            this.SalesDBDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SalesDBDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SalesDBDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SalesDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SalesDBDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SalesDBDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SalesDBDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesDBDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SalesDBDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.SalesDBDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDBDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SalesDBDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SalesDBDataGrid.ThemeStyle.HeaderStyle.Height = 47;
            this.SalesDBDataGrid.ThemeStyle.ReadOnly = true;
            this.SalesDBDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SalesDBDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SalesDBDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDBDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SalesDBDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.SalesDBDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesDBDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderId";
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // Tag
            // 
            this.Tag.DataPropertyName = "Tag";
            this.Tag.HeaderText = "Tag";
            this.Tag.MinimumWidth = 6;
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
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
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.SalesDBDataGrid);
            this.Controls.Add(this.SalesRefreshButton);
            this.Controls.Add(this.SalesDBLabel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.SalesDatePanel.ResumeLayout(false);
            this.SalesDatePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MPortalHomePanel.ResumeLayout(false);
            this.MPortalHomePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.SalesDateTimePanel.ResumeLayout(false);
            this.SalesDateTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDBDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SalesDateLabel;
        private System.Windows.Forms.Timer SalesTimer1;
        private System.Windows.Forms.DateTimePicker SalesDateTimePicker;
        private System.Windows.Forms.Label SalesDateLabe;
        private System.Windows.Forms.Label SalesCusIDLabel;
        private System.Windows.Forms.Label SalesDBLabel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel SalesDatePanel;
        private System.Windows.Forms.Label SalesExitLabel;
        private System.Windows.Forms.Label SalesTimeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.PictureBox SalesLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SalesDateTimePanel;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button SalesClearButton;
        private Guna.UI2.WinForms.Guna2Button SalesDeleteButton;
        private Guna.UI2.WinForms.Guna2Button SalesUpdateButton;
        private Guna.UI2.WinForms.Guna2Button SalesSaveButton;
        private Guna.UI2.WinForms.Guna2ComboBox SalesCusIDComboBox;
        private Guna.UI2.WinForms.Guna2TextBox SalesSearchTB;
        private System.Windows.Forms.Panel MPortalHomePanel;
        private Guna.UI2.WinForms.Guna2ImageButton MPortalHomeIcon;
        private System.Windows.Forms.Label MPortalHomeLabel;
        private Guna.UI2.WinForms.Guna2Button SalesRefreshButton;
        private Guna.UI2.WinForms.Guna2ComboBox SalesTagComboBox;
        private System.Windows.Forms.Label SalesTagLabel;
        private Guna.UI2.WinForms.Guna2TextBox SalesTotalPriceTB;
        private Guna.UI2.WinForms.Guna2TextBox SalesUnitPriceTB;
        private Guna.UI2.WinForms.Guna2TextBox SalesQuantityTB;
        private Guna.UI2.WinForms.Guna2DataGridView SalesDBDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}