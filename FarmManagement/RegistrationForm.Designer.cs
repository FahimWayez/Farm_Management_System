
namespace FarmManagement
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.RegistrationFormCompanyLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.RegFormContact1TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegFormContact2TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegFormCardNoTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegFormAddressTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegFormNextButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationFormCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrationFormCompanyLogo
            // 
            this.RegistrationFormCompanyLogo.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationFormCompanyLogo.Image = ((System.Drawing.Image)(resources.GetObject("RegistrationFormCompanyLogo.Image")));
            this.RegistrationFormCompanyLogo.ImageRotate = 0F;
            this.RegistrationFormCompanyLogo.Location = new System.Drawing.Point(177, 3);
            this.RegistrationFormCompanyLogo.Name = "RegistrationFormCompanyLogo";
            this.RegistrationFormCompanyLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.RegistrationFormCompanyLogo.Size = new System.Drawing.Size(230, 200);
            this.RegistrationFormCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RegistrationFormCompanyLogo.TabIndex = 9;
            this.RegistrationFormCompanyLogo.TabStop = false;
            // 
            // RegFormContact1TB
            // 
            this.RegFormContact1TB.BorderColor = System.Drawing.Color.SkyBlue;
            this.RegFormContact1TB.BorderThickness = 2;
            this.RegFormContact1TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegFormContact1TB.DefaultText = "";
            this.RegFormContact1TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegFormContact1TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegFormContact1TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegFormContact1TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegFormContact1TB.FillColor = System.Drawing.SystemColors.Control;
            this.RegFormContact1TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegFormContact1TB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F);
            this.RegFormContact1TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegFormContact1TB.Location = new System.Drawing.Point(47, 257);
            this.RegFormContact1TB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RegFormContact1TB.Name = "RegFormContact1TB";
            this.RegFormContact1TB.PasswordChar = '\0';
            this.RegFormContact1TB.PlaceholderText = "Contact Number 1";
            this.RegFormContact1TB.SelectedText = "";
            this.RegFormContact1TB.Size = new System.Drawing.Size(510, 43);
            this.RegFormContact1TB.TabIndex = 15;
            // 
            // RegFormContact2TB
            // 
            this.RegFormContact2TB.BorderColor = System.Drawing.Color.SkyBlue;
            this.RegFormContact2TB.BorderThickness = 2;
            this.RegFormContact2TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegFormContact2TB.DefaultText = "";
            this.RegFormContact2TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegFormContact2TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegFormContact2TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegFormContact2TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegFormContact2TB.FillColor = System.Drawing.SystemColors.Control;
            this.RegFormContact2TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegFormContact2TB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F);
            this.RegFormContact2TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegFormContact2TB.Location = new System.Drawing.Point(47, 326);
            this.RegFormContact2TB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RegFormContact2TB.Name = "RegFormContact2TB";
            this.RegFormContact2TB.PasswordChar = '\0';
            this.RegFormContact2TB.PlaceholderText = "Contact Number 2 (Optional)";
            this.RegFormContact2TB.SelectedText = "";
            this.RegFormContact2TB.Size = new System.Drawing.Size(510, 43);
            this.RegFormContact2TB.TabIndex = 16;
            // 
            // RegFormCardNoTB
            // 
            this.RegFormCardNoTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.RegFormCardNoTB.BorderThickness = 2;
            this.RegFormCardNoTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegFormCardNoTB.DefaultText = "";
            this.RegFormCardNoTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegFormCardNoTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegFormCardNoTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegFormCardNoTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegFormCardNoTB.FillColor = System.Drawing.SystemColors.Control;
            this.RegFormCardNoTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegFormCardNoTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F);
            this.RegFormCardNoTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegFormCardNoTB.Location = new System.Drawing.Point(47, 397);
            this.RegFormCardNoTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RegFormCardNoTB.Name = "RegFormCardNoTB";
            this.RegFormCardNoTB.PasswordChar = '\0';
            this.RegFormCardNoTB.PlaceholderText = "Card Number";
            this.RegFormCardNoTB.SelectedText = "";
            this.RegFormCardNoTB.Size = new System.Drawing.Size(510, 43);
            this.RegFormCardNoTB.TabIndex = 17;
            // 
            // RegFormAddressTB
            // 
            this.RegFormAddressTB.BorderColor = System.Drawing.Color.SkyBlue;
            this.RegFormAddressTB.BorderThickness = 2;
            this.RegFormAddressTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegFormAddressTB.DefaultText = "";
            this.RegFormAddressTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegFormAddressTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegFormAddressTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegFormAddressTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegFormAddressTB.FillColor = System.Drawing.SystemColors.Control;
            this.RegFormAddressTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegFormAddressTB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F);
            this.RegFormAddressTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegFormAddressTB.Location = new System.Drawing.Point(47, 470);
            this.RegFormAddressTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RegFormAddressTB.Name = "RegFormAddressTB";
            this.RegFormAddressTB.PasswordChar = '\0';
            this.RegFormAddressTB.PlaceholderText = "Present Address";
            this.RegFormAddressTB.SelectedText = "";
            this.RegFormAddressTB.Size = new System.Drawing.Size(510, 43);
            this.RegFormAddressTB.TabIndex = 18;
            // 
            // RegFormNextButton
            // 
            this.RegFormNextButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegFormNextButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegFormNextButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegFormNextButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegFormNextButton.FillColor = System.Drawing.Color.SkyBlue;
            this.RegFormNextButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F);
            this.RegFormNextButton.ForeColor = System.Drawing.Color.White;
            this.RegFormNextButton.Location = new System.Drawing.Point(205, 529);
            this.RegFormNextButton.Name = "RegFormNextButton";
            this.RegFormNextButton.Size = new System.Drawing.Size(180, 45);
            this.RegFormNextButton.TabIndex = 21;
            this.RegFormNextButton.Text = "Register";
            this.RegFormNextButton.Click += new System.EventHandler(this.RegFormNextButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Please Fill in the required details";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 660);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegFormNextButton);
            this.Controls.Add(this.RegFormAddressTB);
            this.Controls.Add(this.RegFormCardNoTB);
            this.Controls.Add(this.RegFormContact2TB);
            this.Controls.Add(this.RegFormContact1TB);
            this.Controls.Add(this.RegistrationFormCompanyLogo);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationFormCompanyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox RegistrationFormCompanyLogo;
        private Guna.UI2.WinForms.Guna2TextBox RegFormContact1TB;
        private Guna.UI2.WinForms.Guna2TextBox RegFormContact2TB;
        private Guna.UI2.WinForms.Guna2TextBox RegFormCardNoTB;
        private Guna.UI2.WinForms.Guna2TextBox RegFormAddressTB;
        private Guna.UI2.WinForms.Guna2Button RegFormNextButton;
        private System.Windows.Forms.Label label2;
    }
}