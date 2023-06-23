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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection login = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");
        public static string userName;
        public static string password;
        public static string showUName
        {
            get => userName;
            set => userName = value;
        }
        public static string showPass
        {
            get => password;
            set => password = value;
        }
        private void LoginExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void LoginHide_Click(object sender, EventArgs e)
        {
            if (LoginPasswordTB.PasswordChar == '\0')
            {
                LoginUnhide.BringToFront();
                LoginPasswordTB.PasswordChar = '*';
            }
        }

        private void LoginUnhide_Click(object sender, EventArgs e)
        {
            if (LoginPasswordTB.PasswordChar == '*')
            {
                LoginHide.BringToFront();
                LoginPasswordTB.PasswordChar = '\0';
            }
        }
        private void LoginClearButton_Click(object sender, EventArgs e)
        {
            LoginUsernameTB.Text = "";
            LoginPasswordTB.Text = "";
        }

        private void LoginLoginButton_Click(object sender, EventArgs e)
        {
            if(LoginUsernameTB.Text == "" || LoginPasswordTB.Text == "")
            {
                MessageBox.Show("Please type your username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    login.Open();
                    string Query = "select * from CredentialTable where userName= '" + LoginUsernameTB.Text + "' and password= '" + LoginPasswordTB.Text + "' and role = 'Customer'";
                    string Query2 = "select * from CredentialTable where userName= '" + LoginUsernameTB.Text + "' and password= '" + LoginPasswordTB.Text + "' and role = 'Admin'";
                    SqlDataAdapter sda = new SqlDataAdapter(Query, login);
                    SqlDataAdapter sda2 = new SqlDataAdapter(Query2, login);
                    DataTable dt = new DataTable();
                    DataTable dt2 = new DataTable();
                    sda.Fill(dt);
                    sda2.Fill(dt2);

                    if (dt.Rows.Count == 1)
                    {
                        userName = LoginUsernameTB.Text;
                        password = LoginPasswordTB.Text;
                        CustomerPortal obj = new CustomerPortal();
                        obj.Show();
                        this.Hide();
                        login.Close();
                    }

                    else if(dt2.Rows.Count == 1)
                    {
                        userName = LoginUsernameTB.Text;
                        password = LoginPasswordTB.Text;
                        ManagerPortal obj = new ManagerPortal();
                        obj.Show();
                        this.Hide();
                        login.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please check your credentials", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    login.Close();                                                                                                                                                                               
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration obj = new Registration();
            obj.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = LoginLoginButton;
        }
    }
}
