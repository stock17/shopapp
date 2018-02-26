using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopapp
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
            Form1 mainform = new Form1();


            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer(0, "John Connor", true, 14, 3));
            customerList.Add(new Customer(1, "Sarah Connor", false, 36, 2));
            customerList.Add(new Customer(2, "T-800", true, 100, 0));

            mainform.refreshInfo(customerList);

            Application.Run(mainform);


            

            
        }
    }
}
