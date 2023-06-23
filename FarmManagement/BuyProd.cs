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
    public partial class BuyProd : Form
    {
        public BuyProd()
        {
            InitializeComponent();
            BuyProdTimer1.Start();
            //showOrderDetailsTable();
            //showProdDetails();
            //showDetails();
        }

        SqlConnection buyprod = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");

        

        /*private void showProdDetails()
        {
            buyprod.Open();
            string Query2 = "select UnitPrice from ProductionTable";
            SqlDataAdapter buyprodSda2 = new SqlDataAdapter(Query2, buyprod);
            SqlCommandBuilder buyprodScb2 = new SqlCommandBuilder(buyprodSda2);
            var buyprodDs2 = new DataSet();
            buyprodSda2.Fill(buyprodDs2);
            BuyProdDB2DataGrid.DataSource = buyprodDs2.Tables[0];
            buyprod.Close();
        }*/
        private void BuyProdExitLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BuyProdHomeLabel_Click(object sender, EventArgs e)
        {
            CustomerPortal obj = new CustomerPortal();
            obj.Show();
            this.Hide();
        }

        private void BuyProdHomeIcon_Click(object sender, EventArgs e)
        {
            CustomerPortal obj = new CustomerPortal();
            obj.Show();
            this.Hide();
        }

        private void BuyProdLogoutButton_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void BuyProdLogoutIcon_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void BuyProdTimer1_Tick(object sender, EventArgs e)
        {
            BuyProdTimeLabel.Text = DateTime.Now.ToLongTimeString();
            BuyProdDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void BuyProd_Load(object sender, EventArgs e)
        {
            guna2TextBox1.Text = Login.userName;
        }

        private void BuyProdPlaceOrderButton_Click(object sender, EventArgs e)
        {
            if (BuyProdQuantityTB.Text == "" || BuyProdTypeOfProdComboBox.SelectedIndex == -1 || BuyProdPaymentTypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    buyprod.Open();

                    if (buyprod.State == ConnectionState.Open)
                    {
                        string Query = "insert into OrderTable values('" + BuyProdTypeOfProdComboBox.SelectedItem.ToString() + "', '"+BuyProdPaymentTypeComboBox.SelectedItem.ToString()+"', '"+BuyProdQuantityTB.Text+"', '"+BuyProdDateTimePicker.Value.Date+"', '"+Login.userName+"')";
                        SqlCommand buyprodCommand = new SqlCommand(Query, buyprod);
                        buyprodCommand.ExecuteNonQuery();
                        MessageBox.Show("Order Placed Successfulyl!", "Place Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        buyprod.Close();
                    }


                    //refreshEmpPage();
                    //showOrderDetailsTable();
                    //clearButtonFunc();

                    buyprod.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    buyprod.Close();
                }
            }
        }

        
    }




}
