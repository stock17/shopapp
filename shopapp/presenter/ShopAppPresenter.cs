using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.presenter
{
    class ShopAppPresenter
    {
        private IMainForm mainform;

        public interface IMainForm
        {
            void refreshInfo(List<Customer> list);
        }

        public ShopAppPresenter(IMainForm mainform)
        {
            this.mainform = mainform;
        }

        public void onStart()
        {
            // fake request to database
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer(0, "John Connor", true, 14, 3));
            customerList.Add(new Customer(1, "Sarah Connor", false, 36, 2));
            customerList.Add(new Customer(2, "T-800", true, 100, 0));


            mainform.refreshInfo(customerList);
        }
    }
}
