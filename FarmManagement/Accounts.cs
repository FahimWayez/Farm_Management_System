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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
            AccTimer1.Start();
        }

        private void AccExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccTimer1_Tick(object sender, EventArgs e)
        {
            AccTimeLabel.Text = DateTime.Now.ToLongTimeString();
            AccDateLabel.Text = DateTime.Now.ToLongDateString();
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            ManagerPortal obj = new ManagerPortal();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ManagerPortal obj = new ManagerPortal();
            obj.Show();
            this.Hide();
        }
    }
}
