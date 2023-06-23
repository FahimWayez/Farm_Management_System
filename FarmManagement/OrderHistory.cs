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
    public partial class OrderHistory : Form
    {
        public OrderHistory()
        {
            InitializeComponent();
        }

        SqlConnection orderhistory = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");

        private void showDetails()
        {
            orderhistory.Open();
            string Query = "select CusName from CusTable where userName= '" + Login.userName + "'";
            string Query2 = "select CusID from CusTable where userName= '" + Login.userName + "'";
            string Query3 = "select CusAddress from CusTable where userName= '" + Login.userName + "'";
            string Query4 = "select CusContactNumber1 from CusTable where userName= '" + Login.userName + "'";
            string Query5 = "select CusContactNumber2 from CusTable where userName= '" + Login.userName + "'";
            SqlDataAdapter cusSda = new SqlDataAdapter(Query, orderhistory);
            SqlDataAdapter cusSda2 = new SqlDataAdapter(Query2, orderhistory);
            SqlDataAdapter cusSda3 = new SqlDataAdapter(Query3, orderhistory);
            SqlDataAdapter cusSda4 = new SqlDataAdapter(Query4, orderhistory);
            SqlDataAdapter cusSda5 = new SqlDataAdapter(Query5, orderhistory);
            SqlCommandBuilder cusScb = new SqlCommandBuilder(cusSda);
            SqlCommandBuilder cusScb2 = new SqlCommandBuilder(cusSda2);
            SqlCommandBuilder cusScb3 = new SqlCommandBuilder(cusSda3);
            SqlCommandBuilder cusScb4 = new SqlCommandBuilder(cusSda4);
            SqlCommandBuilder cusScb5 = new SqlCommandBuilder(cusSda5);
            var cusDs = new DataSet();
            var cusDs2 = new DataSet();
            var cusDs3 = new DataSet();
            var cusDs4 = new DataSet();
            var cusDs5 = new DataSet();
            cusSda.Fill(cusDs);
            cusSda2.Fill(cusDs2);
            cusSda3.Fill(cusDs3);
            cusSda4.Fill(cusDs4);
            cusSda5.Fill(cusDs5);
            OrderHistoryCusNameGrid.DataSource = cusDs.Tables[0];
            OrderHistoryCusIDGrid.DataSource = cusDs2.Tables[0];
            OrderHistoryCusAddressGrid.DataSource = cusDs2.Tables[0];
            OrderHistoryCusContact1Grid.DataSource = cusDs3.Tables[0];
            OrderHistoryCusContact2Grid.DataSource = cusDs4.Tables[0];

            orderhistory.Close();
        }

        private void showOrderDetailsTable()
        {
            orderhistory.Open();
            string Query = "select * from OrderTable where userName = '" + Login.userName + "'";
            SqlDataAdapter orderhistorySda = new SqlDataAdapter(Query, orderhistory);
            SqlCommandBuilder orderhistoryScb = new SqlCommandBuilder(orderhistorySda);
            var orderhistoryDs = new DataSet();
            orderhistorySda.Fill(orderhistoryDs);
            OrderHistoryDBDataGrid.DataSource = orderhistoryDs.Tables[0];
            orderhistory.Close();
        }

        private void OrderHistoryExitLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
