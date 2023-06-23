using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FarmManagement
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection reg = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");

        private void Registration_Load(object sender, EventArgs e)
        {
            this.AcceptButton = RegNextButton;
        }

        private void RegNextButton_Click(object sender, EventArgs e)
        {
            if (RegNameTB.Text == "" || RegUNameTB.Text == "" || RegPassTB.Text == "" || RegPassConfirmTB.Text == "")
            {
                MessageBox.Show("Please fill in the required information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    reg.Open();

                    if (reg.State == ConnectionState.Open && RegPassTB.Text.Replace("'", "''") == RegPassConfirmTB.Text.Replace("'", "''"))
                    {
                        string Query = "insert into CusTable (CusName, userName, password) values('" + RegNameTB.Text.Replace("'", "''") + "', '" + RegUNameTB.Text.Replace("'", "''") + "', '" + RegPassTB.Text + "')";
                        SqlCommand regCommand = new SqlCommand(Query, reg);
                        regCommand.ExecuteNonQuery();

                        string Query2 = "insert into CredentialTable values('" + RegUNameTB.Text.Replace("'", "''") + "', '" + RegPassTB.Text.Replace("'", "''") + "', 'Customer')";
                        SqlCommand regCommand2 = new SqlCommand(Query2, reg);
                        regCommand2.ExecuteNonQuery();

                        RegistrationForm obj = new RegistrationForm(this);
                        obj.Show();
                        this.Hide();

                        reg.Close();
                    }

                    else
                    {
                        MessageBox.Show("Password do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    reg.Close();

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User Name already exists. Try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    reg.Close();
                }
            }
        }

        private void RegAlreadyButton_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void RegShowPassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (RegShowPassCB.Checked)
            {
                if (RegPassTB.PasswordChar == '*' && RegPassConfirmTB.PasswordChar == '*')
                {
                    RegPassTB.PasswordChar = '\0';
                    RegPassConfirmTB.PasswordChar = '\0';
                }
            }
            else
            {
                if (RegPassTB.PasswordChar == '\0' && RegPassConfirmTB.PasswordChar == '\0')
                {
                    RegPassTB.PasswordChar = '*';
                    RegPassConfirmTB.PasswordChar = '*';
                }
            }
           

        }
    }
}
