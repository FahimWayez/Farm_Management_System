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
    public partial class CustomerProfile : Form
    {
        public CustomerProfile()
        {
            InitializeComponent();
            showCusProfileTable();
        }

        SqlConnection cusprofile = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");
        private void CprofileBackButton_Click(object sender, EventArgs e)
        {
            CustomerPortal obj = new CustomerPortal();
            obj.Show();
            this.Hide();
        }

        private void showCusProfileTable()
        {
            cusprofile.Open();
            string Query = "select CusName from CusTable where userName= '" + Login.userName + "'";
            string Query2 = "select userName from CusTable where userName= '" + Login.userName + "'";
            string Query3 = "select CusContactNumber1 from CusTable where userName= '" + Login.userName + "'";
            string Query4 = "select CusContactNumber2 from CusTable where userName= '" + Login.userName + "'";
            string Query5 = "select CusID from CusTable where userName= '" + Login.userName + "'";
            string Query7 = "select CusCardNumber from CusTable where userName= '" + Login.userName + "'";
            string Query8 = "select CusAddress from CusTable where userName= '" + Login.userName + "'";
            SqlDataAdapter cusSda = new SqlDataAdapter(Query, cusprofile);
            SqlDataAdapter cusSda2 = new SqlDataAdapter(Query2, cusprofile);
            SqlDataAdapter cusSda3 = new SqlDataAdapter(Query3, cusprofile);
            SqlDataAdapter cusSda4 = new SqlDataAdapter(Query4, cusprofile);
            SqlDataAdapter cusSda5 = new SqlDataAdapter(Query5, cusprofile);
            SqlDataAdapter cusSda7 = new SqlDataAdapter(Query7, cusprofile);
            SqlDataAdapter cusSda8 = new SqlDataAdapter(Query8, cusprofile);
            SqlCommandBuilder cusScb = new SqlCommandBuilder(cusSda);
            SqlCommandBuilder cusScb2 = new SqlCommandBuilder(cusSda2);
            SqlCommandBuilder cusScb3 = new SqlCommandBuilder(cusSda3);
            SqlCommandBuilder cusScb4 = new SqlCommandBuilder(cusSda4);
            SqlCommandBuilder cusScb5 = new SqlCommandBuilder(cusSda5);
            SqlCommandBuilder cusScb7 = new SqlCommandBuilder(cusSda7);
            SqlCommandBuilder cusScb8 = new SqlCommandBuilder(cusSda8);
            var cusDs = new DataSet();
            var cusDs2 = new DataSet();
            var cusDs3 = new DataSet();
            var cusDs4 = new DataSet();
            var cusDs5 = new DataSet();
            var cusDs7 = new DataSet();
            var cusDs8 = new DataSet();
            cusSda.Fill(cusDs);
            cusSda2.Fill(cusDs2);
            cusSda3.Fill(cusDs3);
            cusSda4.Fill(cusDs4);
            cusSda5.Fill(cusDs5);
            cusSda7.Fill(cusDs7);
            cusSda8.Fill(cusDs8);
            CProfileCusNameDataGrid.DataSource = cusDs.Tables[0];
            CProfileCusUNameDataGrid.DataSource = cusDs2.Tables[0];
            CProfileCusContact1DataGrid.DataSource = cusDs3.Tables[0];
            CProfileCusContact2DataGrid.DataSource = cusDs4.Tables[0];
            CProfileCusIDDataGrid.DataSource = cusDs5.Tables[0];
            CProfileCusCardNoDataGrid.DataSource = cusDs7.Tables[0];
            CProfileCusAddressDataGrid.DataSource = cusDs8.Tables[0];

            CProfileCusPassTB.Text = Login.password;
            cusprofile.Close();
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            string usrName = Login.userName;
            string password = Login.password;
        }

        private void CProfileEditButton_Click_1(object sender, EventArgs e)
        {
            CustomerProfileEdit obj = new CustomerProfileEdit();
            obj.Show();
            this.Hide();
        }

        private void CProfileHide_Click(object sender, EventArgs e)
        {
            if (CProfileCusPassTB.PasswordChar == '\0')
            {
                CProfileUnhide.BringToFront();
                CProfileCusPassTB.PasswordChar = '*';
            }
        }

        private void CProfileUnhide_Click(object sender, EventArgs e)
        {
            if (CProfileCusPassTB.PasswordChar == '*')
            {
                CProfileHide.BringToFront();
                CProfileCusPassTB.PasswordChar = '\0';
            }
        }
    }
}
