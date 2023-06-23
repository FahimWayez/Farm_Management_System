
namespace FarmManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginLoginButton = new System.Windows.Forms.Button();
            this.LoginClearButton = new System.Windows.Forms.Button();
            this.LoginLabel1 = new System.Windows.Forms.Label();
            this.LoginUserLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LoginCompanyLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LoginUsernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginPasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LoginHide = new System.Windows.Forms.PictureBox();
            this.LoginExitButton = new System.Windows.Forms.Button();
            this.LoginUnhide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginUserLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginCompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginUnhide)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLoginButton
            // 
            this.LoginLoginButton.BackColor = System.Drawing.Color.SkyBlue;
            this.LoginLoginButton.Location = new System.Drawing.Point(494, 623);
            this.LoginLoginButton.Name = "LoginLoginButton";
            this.LoginLoginButton.Size = new System.Drawing.Size(120, 30);
            this.LoginLoginButton.TabIndex = 4;
            this.LoginLoginButton.Text = "Login";
            this.LoginLoginButton.UseVisualStyleBackColor = false;
            this.LoginLoginButton.Click += new System.EventHandler(this.LoginLoginButton_Click);
            // 
            // LoginClearButton
            // 
            this.LoginClearButton.BackColor = System.Drawing.Color.SkyBlue;
            this.LoginClearButton.Location = new System.Drawing.Point(288, 623);
            this.LoginClearButton.Name = "LoginClearButton";
            this.LoginClearButton.Size = new System.Drawing.Size(120, 30);
            this.LoginClearButton.TabIndex = 1;
            this.LoginClearButton.Text = "Clear";
            this.LoginClearButton.UseVisualStyleBackColor = false;
            this.LoginClearButton.Click += new System.EventHandler(this.LoginClearButton_Click);
            // 
            // LoginLabel1
            // 
            this.LoginLabel1.AutoSize = true;
            this.LoginLabel1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel1.Location = new System.Drawing.Point(91, 344);
            this.LoginLabel1.Name = "LoginLabel1";
            this.LoginLabel1.Size = new System.Drawing.Size(571, 23);
            this.LoginLabel1.TabIndex = 1;
            this.LoginLabel1.Text = "Please Login With Your User Name And Password";
            // 
            // LoginUserLogo
            // 
            this.LoginUserLogo.BackColor = System.Drawing.Color.Transparent;
            this.LoginUserLogo.FillColor = System.Drawing.Color.SkyBlue;
            this.LoginUserLogo.Image = ((System.Drawing.Image)(resources.GetObject("LoginUserLogo.Image")));
            this.LoginUserLogo.ImageRotate = 0F;
            this.LoginUserLogo.Location = new System.Drawing.Point(186, 52);
            this.LoginUserLogo.Name = "LoginUserLogo";
            this.LoginUserLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.LoginUserLogo.Size = new System.Drawing.Size(276, 275);
            this.LoginUserLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoginUserLogo.TabIndex = 6;
            this.LoginUserLogo.TabStop = false;
            this.LoginUserLogo.UseTransparentBackground = true;
            // 
            // LoginCompanyLogo
            // 
            this.LoginCompanyLogo.BackColor = System.Drawing.Color.Transparent;
            this.LoginCompanyLogo.Image = ((System.Drawing.Image)(resources.GetObject("LoginCompanyLogo.Image")));
            this.LoginCompanyLogo.ImageRotate = 0F;
            this.LoginCompanyLogo.Location = new System.Drawing.Point(887, 199);
            this.LoginCompanyLogo.Name = "LoginCompanyLogo";
            this.LoginCompanyLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.LoginCompanyLogo.Size = new System.Drawing.Size(389, 352);
            this.LoginCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginCompanyLogo.TabIndex = 7;
            this.LoginCompanyLogo.TabStop = false;
            // 
            // LoginUsernameTB
            // 
            this.LoginUsernameTB.Animated = true;
            this.LoginUsernameTB.AutoRoundedCorners = true;
            this.LoginUsernameTB.BorderRadius = 26;
            this.LoginUsernameTB.BorderThickness = 5;
            this.LoginUsernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginUsernameTB.DefaultText = "";
            this.LoginUsernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginUsernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginUsernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginUsernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginUsernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginUsernameTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.LoginUsernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginUsernameTB.Location = new System.Drawing.Point(66, 383);
            this.LoginUsernameTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.LoginUsernameTB.Name = "LoginUsernameTB";
            this.LoginUsernameTB.PasswordChar = '\0';
            this.LoginUsernameTB.PlaceholderText = "User Name";
            this.LoginUsernameTB.SelectedText = "";
            this.LoginUsernameTB.Size = new System.Drawing.Size(548, 54);
            this.LoginUsernameTB.TabIndex = 8;
            this.LoginUsernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginPasswordTB
            // 
            this.LoginPasswordTB.Animated = true;
            this.LoginPasswordTB.AutoRoundedCorners = true;
            this.LoginPasswordTB.BorderRadius = 26;
            this.LoginPasswordTB.BorderThickness = 5;
            this.LoginPasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginPasswordTB.DefaultText = "";
            this.LoginPasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginPasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginPasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginPasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginPasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPasswordTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.LoginPasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPasswordTB.Location = new System.Drawing.Point(66, 464);
            this.LoginPasswordTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.LoginPasswordTB.Name = "LoginPasswordTB";
            this.LoginPasswordTB.PasswordChar = '*';
            this.LoginPasswordTB.PlaceholderText = "Password";
            this.LoginPasswordTB.SelectedText = "";
            this.LoginPasswordTB.Size = new System.Drawing.Size(548, 54);
            this.LoginPasswordTB.TabIndex = 10;
            this.LoginPasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(259, 558);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(178, 23);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New? Register ";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.SkyBlue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginHide
            // 
            this.LoginHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginHide.Image = ((System.Drawing.Image)(resources.GetObject("LoginHide.Image")));
            this.LoginHide.Location = new System.Drawing.Point(622, 478);
            this.LoginHide.Name = "LoginHide";
            this.LoginHide.Size = new System.Drawing.Size(40, 26);
            this.LoginHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginHide.TabIndex = 5;
            this.LoginHide.TabStop = false;
            this.LoginHide.Click += new System.EventHandler(this.LoginHide_Click);
            // 
            // LoginExitButton
            // 
            this.LoginExitButton.BackColor = System.Drawing.Color.SkyBlue;
            this.LoginExitButton.Location = new System.Drawing.Point(77, 623);
            this.LoginExitButton.Name = "LoginExitButton";
            this.LoginExitButton.Size = new System.Drawing.Size(120, 30);
            this.LoginExitButton.TabIndex = 14;
            this.LoginExitButton.Text = "Exit";
            this.LoginExitButton.UseVisualStyleBackColor = false;
            this.LoginExitButton.Click += new System.EventHandler(this.LoginExitButton_Click);
            // 
            // LoginUnhide
            // 
            this.LoginUnhide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginUnhide.Image = ((System.Drawing.Image)(resources.GetObject("LoginUnhide.Image")));
            this.LoginUnhide.Location = new System.Drawing.Point(622, 478);
            this.LoginUnhide.Name = "LoginUnhide";
            this.LoginUnhide.Size = new System.Drawing.Size(40, 26);
            this.LoginUnhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginUnhide.TabIndex = 15;
            this.LoginUnhide.TabStop = false;
            this.LoginUnhide.Click += new System.EventHandler(this.LoginUnhide_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.LoginUnhide);
            this.Controls.Add(this.LoginExitButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LoginPasswordTB);
            this.Controls.Add(this.LoginUsernameTB);
            this.Controls.Add(this.LoginCompanyLogo);
            this.Controls.Add(this.LoginUserLogo);
            this.Controls.Add(this.LoginLoginButton);
            this.Controls.Add(this.LoginHide);
            this.Controls.Add(this.LoginClearButton);
            this.Controls.Add(this.LoginLabel1);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "am";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginUserLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginCompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginUnhide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoginLoginButton;
        private System.Windows.Forms.Button LoginClearButton;
        private System.Windows.Forms.Label LoginLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox LoginUserLogo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox LoginCompanyLogo;
        private Guna.UI2.WinForms.Guna2TextBox LoginUsernameTB;
        private Guna.UI2.WinForms.Guna2TextBox LoginPasswordTB;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox LoginHide;
        private System.Windows.Forms.Button LoginExitButton;
        private System.Windows.Forms.PictureBox LoginUnhide;
    }
}