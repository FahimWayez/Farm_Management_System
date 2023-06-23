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
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
           
        }
        private void StartingForm_Load(object sender, EventArgs e)
        {
            timerLoading.Start();
        }


        int startPoint = 0;

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            startPoint += 5;
            StartingPagePB.Value = startPoint;

            if (StartingPagePB.Value == 100)
            {
                StartingPagePB.Value = 0;
                timerLoading.Stop();

                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
        }
    }
}
 