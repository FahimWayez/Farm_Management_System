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
    public partial class ManagerPortal : Form
    {

        bool sideBarExpand; 
        public ManagerPortal()
        {
            InitializeComponent();

            MPortalTimer1.Start();
        }

        SqlConnection mportal = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");
        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MPortalTimeLabel.Text = DateTime.Now.ToLongTimeString();
            MPortalDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void MPortalLogoutButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to sign out?", "Signing out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
        }

        private void MPortalLogoutIcon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to sign out?", "Signing out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
        }

        private void MPortalExitLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void MPortalGTEmpPB_Click_1(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.Show();
            this.Hide();
        }

        private void MPortalGTEmpButton_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.Show();
            this.Hide();
        }


        private void MPortalGTCusPB_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void MPortalGTCusButton_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void MPortalGTCattlePB_Click_1(object sender, EventArgs e)
        {
            Cattle obj = new Cattle();
            obj.Show();
            this.Hide();
        }

        private void MPortalGTCattleButton_Click(object sender, EventArgs e)
        {
            Cattle obj = new Cattle();
            obj.Show();
            this.Hide();
        }
        private void MPortalGTHealthPB_Click_1(object sender, EventArgs e)
        {
            Health obj = new Health();
            obj.Show();
            this.Hide();
        } 
        private void MPortalGTHealthButton_Click(object sender, EventArgs e)
        {
            Health obj = new Health();
            obj.Show();
            this.Hide();
        }

        private void MPortalGTProdPB_Click_1(object sender, EventArgs e)
        {
            Production obj = new Production();
            obj.Show();
            this.Hide();
        }

        private void MPortalGTProdButton_Click(object sender, EventArgs e)
        {
            Production obj = new Production();
            obj.Show();
            this.Hide();
        }

        private void MPortalGTSalesPB_Click_1(object sender, EventArgs e)
        {
            Sales obj = new Sales();
            obj.Show();
            this.Hide();
        }

        private void MPortalGTSalesButton_Click(object sender, EventArgs e)
        {
            Sales obj = new Sales();
            obj.Show();
            this.Hide();
        }

        private void MPortalGTAccPB_Click_1(object sender, EventArgs e)
        {
            Accounts obj = new Accounts();
            obj.Show();
            this.Hide();
        }

        private void MPortalGTAccButton_Click(object sender, EventArgs e)
        {
            Accounts obj = new Accounts();
            obj.Show();
            this.Hide();
        }

        private void MPortalHomeIcon_Click(object sender, EventArgs e)
        {
            ManagerPortal obj = new ManagerPortal();
            obj.Show();
            this.Hide();
        }

        private void MPortalHomeLabel_Click(object sender, EventArgs e)
        {
            ManagerPortal obj = new ManagerPortal();
            obj.Show();
            this.Hide();
        }

        private void ManagerPortal_Load(object sender, EventArgs e)
        {
            MPortalNameTB.Text = "Hello, " + Login.userName;
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                panel1.Width -= 10; 
                MPortalLogo.Width -= 10;
                MPortalLogo.Height -= 8;
                if (panel1.Width == panel1.MinimumSize.Width && MPortalLogo.Width == MPortalLogo.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                panel1.Width += 10;
                MPortalLogo.Width += 10;
                MPortalLogo.Height += 8;
                if (panel1.Width == panel1.MaximumSize.Width && MPortalLogo.Width == MPortalLogo.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    SideBarTimer.Stop();
                }
            }

        }

        private void MenuIcon_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }
    }
}
