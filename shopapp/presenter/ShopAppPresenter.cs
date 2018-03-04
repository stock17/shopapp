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
            void refreshInfo(List<Customer> customerList, List<Product> productList, List<Order> orderList);
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
            RefreshMainForm();
        }

        public void onSave()
        {
            model.SaveData();
        }

        private void RefreshMainForm()
        {
            mainform.refreshInfo(model.getCustomerList(), model.getProductList(), model.getOrderList());
        }

        
        public void onAddCustomer (Customer c)
        {
            model.addCustomer(c);
            RefreshMainForm();
        }

        public void OnEditCustomer(Customer customer, int index)
        {
            model.EditCustomer(customer, index);
            RefreshMainForm();
        }

        public void OnRemoveCustomer(int index)
        {
            model.RemoveCustomer(index);
            RefreshMainForm();
        }


        public void OnCustomerSelected(Customer customer)
        {
            mainform.showCustomer(customer);
        }




        public void onAddProduct(Product product)
        {
            model.AddProduct(product);
            RefreshMainForm();
        }

        public void OnEditProduct(Product product, int index)
        {
            model.EditProduct(product, index);
            RefreshMainForm();
        }

        public void OnRemoveProduct(int index)
        {
            model.RemoveProduct(index);
            RefreshMainForm();
        }

        public void OnProductSelected(Product product)
        {
            mainform.showProduct(product);
        }




        public void onAddOrder(Order order, OrderProductList list)
        {
            model.AddOrder(order);
            model.AddOrderProductList(list);
            RefreshMainForm();
        }

        public void OnEditOrder(Order order, int index)
        {
            model.EditOrder(order, index);
            RefreshMainForm();
        }

        public void OnRemoveOrder(int index)
        {
            model.RemoveProduct(index);
            RefreshMainForm();
        }

        public void OnOrderSelected(Product product)
        {
            RefreshMainForm();
        }


    }
}
