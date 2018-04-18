using shopapp.entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.model
{
    class FileHelper : IEntityHelper
    {
        private static FileHelper fileHelper;

        private FileHelper() { }

        public static FileHelper GetInstance()
        {
            if (fileHelper == null)
                fileHelper = new model.FileHelper();
            return fileHelper;
        }

        private const string FILES_DIRECTORY = "./files";
        private const string CUSTOMER_FILE = FILES_DIRECTORY + "/customers.json";
        private const string PRODUCT_FILE = FILES_DIRECTORY + "/products.json";
        private const string ORDER_FILE = FILES_DIRECTORY + "/orders.json";
        private const string ORDER_PRODUCT_FILE = FILES_DIRECTORY + "/productlists.json";

        public void SaveCustomers(List<Customer> customers)
        {
            if (!Directory.Exists(FILES_DIRECTORY)) Directory.CreateDirectory(FILES_DIRECTORY);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Customer>));
            FileStream stream = new FileStream(CUSTOMER_FILE, FileMode.Create);
            serializer.WriteObject(stream, customers);
            stream.Close();
        }

        public List<Customer> LoadCustomers()
        {                        
            if (File.Exists(CUSTOMER_FILE))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Customer>));
                FileStream stream = new FileStream(CUSTOMER_FILE, FileMode.OpenOrCreate);
                List<Customer> customerList = (List<Customer>)serializer.ReadObject(stream);
                stream.Close();
                return customerList;
            }
            else
            {
                return new List<Customer>();
            }
            
        }

        public List<Product> LoadProducts()
        {
            if (File.Exists(PRODUCT_FILE))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Product>));
                FileStream stream = new FileStream(PRODUCT_FILE, FileMode.OpenOrCreate);
                List<Product> productList = (List<Product>)serializer.ReadObject(stream);
                stream.Close();
                return productList;
            }
            else {
                return new List<Product>();
            }
            
            
        }

        public void SaveProducts(List<Product> products)
        {
            if (!Directory.Exists(FILES_DIRECTORY)) Directory.CreateDirectory(FILES_DIRECTORY);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Product>));
            FileStream stream = new FileStream(PRODUCT_FILE, FileMode.Create);
            serializer.WriteObject(stream, products);
            stream.Close();
        }


        public List<Order> LoadOrders()
        {
            if (File.Exists(ORDER_FILE))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Order>));
                FileStream stream = new FileStream(ORDER_FILE, FileMode.OpenOrCreate);
                List<Order> orderList = (List<Order>)serializer.ReadObject(stream);
                stream.Close();
                return orderList;
            }
            else
            {
                return new List<Order>();
            }


        }

        public void SaveOrders(List<Order> orderList)
        {
            if (!Directory.Exists(FILES_DIRECTORY)) Directory.CreateDirectory(FILES_DIRECTORY);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Order>));
            FileStream stream = new FileStream(ORDER_FILE, FileMode.Create);
            serializer.WriteObject(stream, orderList);
            stream.Close();
        }




        public List<OrderProductList> LoadProductLists()
        {
            if (File.Exists(ORDER_PRODUCT_FILE))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<OrderProductList>));
                FileStream stream = new FileStream(ORDER_PRODUCT_FILE, FileMode.OpenOrCreate);
                List<OrderProductList> orderProductList = (List<OrderProductList>)serializer.ReadObject(stream);
                stream.Close();
                return orderProductList;
            }
            else
            {
                return new List<OrderProductList>();
            }


        }

        public void SaveOrderProductLists(List<OrderProductList> orderProductLists)
        {
            if (!Directory.Exists(FILES_DIRECTORY)) Directory.CreateDirectory(FILES_DIRECTORY);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<OrderProductList>));
            FileStream stream = new FileStream(ORDER_PRODUCT_FILE, FileMode.Create);
            serializer.WriteObject(stream, orderProductLists);
            stream.Close();
        }


    }
}
