
namespace FarmManagement
{
    partial class StartingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingForm));
            this.StartingPagePictureLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.StartingPagePB = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.StartingPagePleaseWaitLabel = new System.Windows.Forms.Label();
            this.StartingPageWelcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StartingPagePictureLogo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartingPagePictureLogo
            // 
            this.StartingPagePictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("StartingPagePictureLogo.Image")));
            this.StartingPagePictureLogo.ImageRotate = 0F;
            this.StartingPagePictureLogo.Location = new System.Drawing.Point(12, 13);
            this.StartingPagePictureLogo.Name = "StartingPagePictureLogo";
            this.StartingPagePictureLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.StartingPagePictureLogo.Size = new System.Drawing.Size(467, 431);
            this.StartingPagePictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartingPagePictureLogo.TabIndex = 2;
            this.StartingPagePictureLogo.TabStop = false;
            // 
            // timerLoading
            // 
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.StartingPagePB);
            this.guna2Panel1.Controls.Add(this.StartingPagePleaseWaitLabel);
            this.guna2Panel1.Controls.Add(this.StartingPageWelcomeLabel);
            this.guna2Panel1.Controls.Add(this.StartingPagePictureLogo);
            this.guna2Panel1.Location = new System.Drawing.Point(166, 121);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(999, 459);
            this.guna2Panel1.TabIndex = 3;
            // 
            // StartingPagePB
            // 
            this.StartingPagePB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.StartingPagePB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingPagePB.ForeColor = System.Drawing.Color.Black;
            this.StartingPagePB.Location = new System.Drawing.Point(630, 195);
            this.StartingPagePB.Minimum = 0;
            this.StartingPagePB.Name = "StartingPagePB";
            this.StartingPagePB.ProgressColor = System.Drawing.Color.SkyBlue;
            this.StartingPagePB.ProgressColor2 = System.Drawing.Color.SkyBlue;
            this.StartingPagePB.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.StartingPagePB.ShowText = true;
            this.StartingPagePB.Size = new System.Drawing.Size(160, 160);
            this.StartingPagePB.TabIndex = 6;
            this.StartingPagePB.Text = "guna2CircleProgressBar1";
            // 
            // StartingPagePleaseWaitLabel
            // 
            this.StartingPagePleaseWaitLabel.AutoSize = true;
            this.StartingPagePleaseWaitLabel.Location = new System.Drawing.Point(646, 369);
            this.StartingPagePleaseWaitLabel.Name = "StartingPagePleaseWaitLabel";
            this.StartingPagePleaseWaitLabel.Size = new System.Drawing.Size(165, 23);
            this.StartingPagePleaseWaitLabel.TabIndex = 5;
            this.StartingPagePleaseWaitLabel.Text = "Please Wait...";
            // 
            // StartingPageWelcomeLabel
            // 
            this.StartingPageWelcomeLabel.AutoSize = true;
            this.StartingPageWelcomeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingPageWelcomeLabel.Location = new System.Drawing.Point(597, 114);
            this.StartingPageWelcomeLabel.Name = "StartingPageWelcomeLabel";
            this.StartingPageWelcomeLabel.Size = new System.Drawing.Size(273, 53);
            this.StartingPageWelcomeLabel.TabIndex = 4;
            this.StartingPageWelcomeLabel.Text = "Welcome";
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StartingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StartingPagePictureLogo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox StartingPagePictureLogo;
        private System.Windows.Forms.Timer timerLoading;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar StartingPagePB;
        private System.Windows.Forms.Label StartingPagePleaseWaitLabel;
        private System.Windows.Forms.Label StartingPageWelcomeLabel;
    }
}

