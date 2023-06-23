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
    public partial class Availability : Form
    {
        public Availability()
        {
            InitializeComponent();
            AvaTimer1.Start();
            showAvaTable();
        }

        SqlConnection ava = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");
        private void AvaExitLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AvaLogoutButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to sign out?", "Signing out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
        }

        private void AvaLogoutIcon_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to sign out?", "Signing out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
        }

        private void AvaHomeLabel_Click(object sender, EventArgs e)
        {
            CustomerPortal obj = new CustomerPortal();
            obj.Show();
            this.Hide();
        }

        private void AvaHomeIcon_Click(object sender, EventArgs e)
        {
            CustomerPortal obj = new CustomerPortal();
            obj.Show();
            this.Hide();
        }

        private void AvaTimer1_Tick(object sender, EventArgs e)
        {
            AvaTimeLabel.Text = DateTime.Now.ToLongTimeString();
            AvaDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void AvaRefreshButton_Click(object sender, EventArgs e)
        {
            Availability obj = new Availability();
            obj.Show();
            this.Hide();
        }


        private void showAvaTable()
        {
            ava.Open();
            string Query = "select * from ProductionTable";
            SqlDataAdapter avaSda = new SqlDataAdapter(Query, ava);
            SqlCommandBuilder avaScb = new SqlCommandBuilder(avaSda);
            var avaDs = new DataSet();
            avaSda.Fill(avaDs);
            AvaDBDataGrid.DataSource = avaDs.Tables[0];

            ava.Close();
        }

        private void AvaBuyNowLabel_Click(object sender, EventArgs e)
        {
            BuyProd obj = new BuyProd();
            obj.Show();
            this.Hide();
        }

        private void AvaBuyNowPb_Click(object sender, EventArgs e)
        {
            BuyProd obj = new BuyProd();
            obj.Show();
            this.Hide();
        }
    }
}
