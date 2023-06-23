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
    public partial class CustomerProfileEdit : Form
    {
        public CustomerProfileEdit()
        {
            InitializeComponent();
        }

        SqlConnection cusprofileedit = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");

        private void CustomerProfileEdit_Load(object sender, EventArgs e)
        {
            CProfileEditNameShowTB.Text =  Login.userName;
        }

        private void CProfileEditUpdateButton_Click(object sender, EventArgs e)
        {
            if (CProfileEditNameTB.Text == "" || CProfileEditContact1TB.Text == "" || CProfileEditContact2TB.Text == "" || CProfileEditCardNoTB.Text == "" || CProfileEditAddressTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure want to update?", "Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cusprofileedit.Open();

                        if (cusprofileedit.State == ConnectionState.Open)
                        {
                            string Query = "update CusTable set CusName='" + CProfileEditNameTB.Text.Replace("'", "''") + "',  CusContactNumber1='" + CProfileEditContact1TB.Text.Replace("'", "''") + "', CusContactNumber2='" + CProfileEditContact2TB.Text.Replace("'", "''") + "', CusCardNumber='" + CProfileEditCardNoTB.Text.Replace("'", "''") + "',CusAddress='" + CProfileEditAddressTB.Text.Replace("'", "''") + "' where userName='" + CProfileEditNameShowTB.Text + "'";
                            SqlCommand cusCommand = new SqlCommand(Query, cusprofileedit);
                            cusCommand.ExecuteNonQuery();
                            MessageBox.Show("Customer details has been updated successfully!", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cusprofileedit.Close();
                        }

                        cusprofileedit.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cusprofileedit.Close();
                    }

                    
                }
            }
        }

        private void CProfileEditClearButton_Click(object sender, EventArgs e)
        {
            CProfileEditNameTB.Text = "" ;
            CProfileEditContact1TB.Text = "" ;
            CProfileEditContact2TB.Text = "";
            CProfileEditCardNoTB.Text = "";
            CProfileEditAddressTB.Text = "";
        }

        private void CProfileEditBackButton_Click(object sender, EventArgs e)
        {
            CustomerProfile obj = new CustomerProfile();
            obj.Show();
            this.Hide();
        }
    }
}
