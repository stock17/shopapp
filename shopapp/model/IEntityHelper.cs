using shopapp.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.model
{
    interface IEntityHelper
    {
        void SaveCustomers(List<Customer> customers);
        List<Customer> LoadCustomers();

        void SaveProducts(List<Product> products);
        List<Product> LoadProducts();

        void SaveOrders(List<Order> orderList);
        List<Order> LoadOrders();

        void SaveOrderProductLists(List<OrderProductList> orderProductLists);
        List<OrderProductList> LoadProductLists();
    }
}
