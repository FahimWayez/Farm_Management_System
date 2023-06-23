using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmManagement
{
    public partial class RegistrationForm : Form
    {
        private Registration registration;
        public RegistrationForm(Registration registration)
        {
            InitializeComponent();
            this.registration = registration;
        }

        SqlConnection reg = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");

        private void RegFormNextButton_Click(object sender, EventArgs e)
        {
            if (RegFormContact1TB.Text == "" || RegFormCardNoTB.Text == "" || RegFormAddressTB.Text == "")
            {
                MessageBox.Show("Please Fill in the required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    reg.Open();

                    if (reg.State == ConnectionState.Open)
                    {
                        string Query = "update CusTable set CusContactNumber1= '" + RegFormContact1TB.Text.Replace("'", "''") + "', CusContactNumber2='" + RegFormContact2TB.Text.Replace("'", "''") + "', CusCardNumber='" + RegFormCardNoTB.Text.Replace("'", "''") + "', CusAddress='" + RegFormAddressTB.Text.Replace("'", "''") + "' where CusName='" + registration.RegNameTB.Text + "'";
                        SqlCommand regCommand = new SqlCommand(Query, reg);
                        regCommand.ExecuteNonQuery();

                        Guna.UI2.WinForms.Guna2Button RegFormYesButton = new Guna.UI2.WinForms.Guna2Button();
                        RegFormYesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                        RegFormYesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                        RegFormYesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                        RegFormYesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                        RegFormYesButton.FillColor = System.Drawing.Color.SkyBlue;
                        RegFormYesButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F);
                        RegFormYesButton.ForeColor = System.Drawing.Color.White;
                        RegFormYesButton.Location = new System.Drawing.Point(47, 529);
                        RegFormYesButton.Name = "RegFormYesButton";
                        RegFormYesButton.Size = new System.Drawing.Size(180, 45);
                        RegFormYesButton.TabIndex = 21;
                        RegFormYesButton.Text = "Yes, I want to login now";
                        RegFormYesButton.Click += new System.EventHandler(RegFormYesButton_Click);

                        Guna.UI2.WinForms.Guna2Button RegFormNoButton = new Guna.UI2.WinForms.Guna2Button();
                        RegFormYesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                        RegFormNoButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                        RegFormNoButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                        RegFormNoButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                        RegFormNoButton.FillColor = System.Drawing.Color.SkyBlue;
                        RegFormNoButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F);
                        RegFormNoButton.ForeColor = System.Drawing.Color.White;
                        RegFormNoButton.Location = new System.Drawing.Point(377, 529);
                        RegFormNoButton.Name = "RegFormNoButton";
                        RegFormNoButton.Size = new System.Drawing.Size(180, 45);
                        RegFormNoButton.TabIndex = 21;
                        RegFormNoButton.Text = "No, I want to quit";
                        RegFormNoButton.Click += new System.EventHandler(RegFormNoButton_Click);

                        this.Controls.Add(RegFormYesButton);
                        this.Controls.Add(RegFormNoButton);
                        this.Controls.Remove(RegFormNextButton);

                        reg.Close();
                    }
                    reg.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    reg.Close();
                }   
            }
            
            
        }

        private void RegFormYesButton_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void RegFormNoButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = RegFormNextButton;
        }
    }
}
