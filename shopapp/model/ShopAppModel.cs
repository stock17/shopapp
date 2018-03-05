using shopapp.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.model
{
    class ShopAppModel
    {
        private List<Customer> customerList;
        private List<Product> productList;
        private List<OrderProductList> orderProductLists;
        private List<Order> orderList;

        private FileHelper fileHelper;

        public ShopAppModel()
        {
            fileHelper = FileHelper.GetInstance();
            LoadCustomers();
            LoadProducts();
            LoadOrderProductLists();
            LoadOrders();

        }      

        public void SaveData()
        {
            fileHelper.SaveCustomerToFile(customerList);
            fileHelper.SaveProductToFile(productList);
            fileHelper.SaveOrderProductListsToFile(orderProductLists);
            fileHelper.SaveOrdersToFile(orderList);
        }

        /***************************************************/
        /*************  CUSTOMER SECTION  ******************/
        /***************************************************/
        public List<Customer> getCustomerList()
        {
            return customerList;
        }

        public void addCustomer(Customer c)
        {
            customerList.Add(c);            
        }

        public void EditCustomer(Customer customer, int index)
        {
            customerList[index] = customer;            
        }

        public void RemoveCustomer(int index)
        {
            customerList.RemoveAt(index);            
        }

        /***************************************************/
        /*************  PRODUCT SECTION  *******************/
        /***************************************************/
        public List<Product> getProductList()
        {
            return productList;            
        }

        public void AddProduct(Product product)
        {
            productList.Add(product);
        }

        public void EditProduct(Product product, int index)
        {
            productList[index] = product;
        }

        public void RemoveProduct(int index)
        {
            productList.RemoveAt(index);
        }

        /***************************************************/
        /*************  PRODUCT LIST SECTION  **************/
        /***************************************************/
        public List<OrderProductList> getOrderProductList()
        {
            return orderProductLists;
        }

        public void AddOrderProductList(OrderProductList list)
        {
            orderProductLists.Add(list);
        }

        public void EditOrderProductList(OrderProductList list, int index)
        {
            orderProductLists[index] = list;
        }

        public void RemoveOrderProductList(int index)
        {
            orderProductLists.RemoveAt(index);
        }

        /***************************************************/
        /***************  ORDER SECTION  *******************/
        /***************************************************/
        public List<Order> getOrderList()
        {
            return orderList;
        }

        public void AddOrder(Order order)
        {
            orderList.Add(order);
        }

        public void EditOrder(Order order, int index)
        {
            orderList[index] = order;
        }

        public void RemoveOrder(int index)
        {
            OrderProductList list = orderList[index].ProductList;
            orderProductLists.Remove(list);            
            orderList.RemoveAt(index);
        }


        /***************************************************/
        /*******************  LOADERS  *********************/
        /***************************************************/


        private void LoadCustomers() {
            customerList = fileHelper.LoadCustomerFromFile();
            if (customerList.Count > 0)
            {
                var MaxId = (from c in customerList select c.Id).Max();
                Customer.NextId = ++MaxId;
            }
            else
            {
                Customer.NextId = 0;
            }
        }

        private void LoadProducts() {
            productList = fileHelper.LoadProductFromFile();
            if (productList.Count > 0)
            {
                var MaxId = (from p in productList select p.Id).Max();
                Product.NextId = ++MaxId;

                Console.WriteLine("Product max id - " + MaxId);
            }
            else
            {
                Product.NextId = 0;
            }
        }

        private void LoadOrderProductLists()
        {
            orderProductLists = fileHelper.LoadProductListsFromFile();

            if (orderProductLists.Count > 0)
            {
                var MaxId = (from p in orderProductLists select p.Id).Max();
                OrderProductList.NextId = ++MaxId;

                Console.WriteLine("Product max id - " + MaxId);

                foreach (OrderProductList list in orderProductLists) {
                    list.ProductList = new List<Product>();
                    foreach (int id in list.ProductIdList) {

                        var products = from p in productList where p.Id == id select p;
                        foreach (Product prod in products)
                        {
                            list.ProductList.Add(prod);
                        }
                    }                    
                }
            }
            else
            {
                OrderProductList.NextId = 0;
            }
        }

        private void LoadOrders()
        {
            orderList = fileHelper.LoadOrdersFromFile();
            if (orderList.Count > 0)
            {                
                var MaxId = (from p in orderList select p.Id).Max();
                Order.NextId = ++MaxId;

                Console.WriteLine("Product max id - " + MaxId);

                // Load Customers and ProductLists to Orders by ID
                foreach (Order o in orderList) {                    
                    var customers = from cust in customerList where cust.Id == o.CustomerId select cust;                    
                    foreach (Customer c in customers) { 
                        o.OrderCustomer = c;
                    }

                    var productLists = from list in orderProductLists where list.Id == o.ProductListId select list;
                    foreach (OrderProductList list in productLists) {
                        o.ProductList = list;
                    }
                }               

            }
            else
            {
                Order.NextId = 0;
            }
        }


        //======================== REPORT =====================//
        public List<Order> GetReport(List<Customer> cList, int fromAge, int toAge, List<bool> statusList, List<Product> pList,
            DateTime fromDate, DateTime toDate) {

            var request = from o in orderList where
                          cList.Contains(o.OrderCustomer) &&
                          o.OrderCustomer.Age > fromAge &&
                          o.OrderCustomer.Age < toAge && 
                          o.Date > fromDate &&
                          o.Date < toDate
                          select o;

            List < Order > result = new List<Order>();
            foreach (Order o in request)
            {
                foreach(Product p in o.ProductList.ProductList)
                {
                    if (pList.Contains(p))
                        result.Add(o);
                    continue;
                }                
            }

            return result;
        }


    }
}
