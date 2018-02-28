using shopapp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.presenter
{
    class ShopAppPresenter
    {
        private ShopAppModel model;

        private IMainForm mainform;        

        public interface IMainForm
        {
            void refreshInfo(List<Customer> list);
            void showCustomer(Customer customer);
        }

        public ShopAppPresenter(IMainForm mainform)
        {
            this.mainform = mainform;
            this.model = new ShopAppModel();
        }

        public void onStart()
        {
            mainform.refreshInfo(model.getCustomerList());
        }

        public void OnCustomerSelected(Customer customer)
        {
            mainform.showCustomer(customer);
        }

        public void onAddCustomer (Customer c)
        {
            model.addCustomer(c);
            mainform.refreshInfo(model.getCustomerList());
        }

        public void OnEditCustomer(Customer customer, int index)
        {
            model.EditCustomer(customer, index);
            mainform.refreshInfo(model.getCustomerList());
        }

        public void OnRemoveCustomer(int index)
        {
            model.RemoveCustomer(index);
            mainform.refreshInfo(model.getCustomerList());
        }
    }
}
