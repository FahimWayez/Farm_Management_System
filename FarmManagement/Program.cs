using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new StartingForm());
            //Application.Run(new Login());
            //Application.Run(new Employee());
            //Application.Run(new Customer());
            //Application.Run(new Cattle());
            //Application.Run(new Health()); 
            //Application.Run(new Production()); 
            //Application.Run(new Sales()); 
            //Application.Run(new Accounts()); 
            //Application.Run(new ManagerPortal()); 
            //Application.Run(new CustomerPortal()); 
            //Application.Run(new Registration()); 
            //Application.Run(new RegistrationForm()); 
            //Application.Run(new CustomerProfile()); 
            //Application.Run(new Availability()); 

        }
    }
}
