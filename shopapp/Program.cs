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
            Application.Run(new Form1());

            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer { Name = "John Connor", Age = 14, Sex = true, Status = 3 });
            customerList.Add(new Customer { Name = "Sarah Connor", Age = 36, Sex = false, Status = 2 });
            customerList.Add(new Customer { Name = "T-800", Age = 100, Sex = true, Status = 0 });
        }
    }
}
