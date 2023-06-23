using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmManagement
{
    public partial class CustomerPortal : Form
    {

       
        public CustomerPortal()
        {
            InitializeComponent();
            CPortalTimer1.Start();
        }
       
        private void customerPortal_Load(object sender, EventArgs e)
        {
            CPortalNameTB.Text = "Hello, " + Login.userName;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            CPortalTimeLabel.Text = DateTime.Now.ToLongTimeString();
            CPortalDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void CPortalExitLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CPortalHomeIcon_Click(object sender, EventArgs e)
        {
            CustomerPortal obj = new CustomerPortal();
            obj.Show();
            this.Hide();
        }
        private void CPortalHomeLabel_Click(object sender, EventArgs e)
        {
            CustomerPortal obj = new CustomerPortal();
            obj.Show();
            this.Hide();
        }

        private void CPortalLogoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to sign out?", "Signing out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
        }

        private void CPortalLogoutIcon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to sign out?", "Signing out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
        }

        private void CPortalProfilePB_Click(object sender, EventArgs e)
        {
            CustomerProfile obj = new CustomerProfile();
            obj.Show();
            this.Hide();
        }

        private void CPortalProfileButton_Click(object sender, EventArgs e)
        {
            CustomerProfile obj = new CustomerProfile();
            obj.Show();
            this.Hide();
        }

        private void CPortalAvaIcon_Click(object sender, EventArgs e)
        {
            Availability obj = new Availability();
            obj.Show();
            this.Hide();
        }

        private void CPortalAvaLabel_Click(object sender, EventArgs e)
        {
            Availability obj = new Availability();
            obj.Show();
            this.Hide();
        }

        private void CPortalPProdIcon_Click(object sender, EventArgs e)
        {
            BuyProd obj = new BuyProd();
            obj.Show();
            this.Hide();
        }

        private void CPortalProdLabel_Click(object sender, EventArgs e)
        {
            BuyProd obj = new BuyProd();
            obj.Show();
            this.Hide();
        }
    }
}
