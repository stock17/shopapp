using shopapp.entities;
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
            void refreshInfo(List<Customer> customerList, List<Product> productList);
            void showCustomer(Customer customer);
            void showProduct(Product product);
        }

        public ShopAppPresenter(IMainForm mainform)
        {
            this.mainform = mainform;
            this.model = new ShopAppModel();
        }

        public void onStart()
        {
            mainform.refreshInfo(model.getCustomerList(), model.getProductList());
        }

        public void OnCustomerSelected(Customer customer)
        {
            mainform.showCustomer(customer);
        }

        public void onAddCustomer (Customer c)
        {
            model.addCustomer(c);
            mainform.refreshInfo(model.getCustomerList(), model.getProductList());
        }

        public void OnEditCustomer(Customer customer, int index)
        {
            model.EditCustomer(customer, index);
            mainform.refreshInfo(model.getCustomerList(), model.getProductList());
        }

        public void OnRemoveCustomer(int index)
        {
            model.RemoveCustomer(index);
            mainform.refreshInfo(model.getCustomerList(), model.getProductList());
        }

        public void onSave() {
            model.SaveData();
        }


        public void onAddProduct(Product product)
        {
            model.AddProduct(product);
            mainform.refreshInfo(model.getCustomerList(), model.getProductList());
        }

        public void OnEditProduct(Product product, int index)
        {
            model.EditProduct(product, index);
            mainform.refreshInfo(model.getCustomerList(), model.getProductList());
        }

        public void OnRemoveProduct(int index)
        {
            model.RemoveProduct(index);
            mainform.refreshInfo(model.getCustomerList(), model.getProductList());
        }

        public void OnProductSelected(Product product)
        {
            mainform.showProduct(product);
        }


    }
}
