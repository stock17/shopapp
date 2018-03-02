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
    class FileHelper
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

        public void SaveCustomerToFile(List<Customer> customers)
        {
            if (!Directory.Exists(FILES_DIRECTORY)) Directory.CreateDirectory(FILES_DIRECTORY);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Customer>));
            FileStream stream = new FileStream(CUSTOMER_FILE, FileMode.Create);
            serializer.WriteObject(stream, customers);
            stream.Close();
        }

        public List<Customer> LoadCustomerFromFile()
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

        public List<Product> LoadProductFromFile()
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

        public void SaveProductToFile(List<Product> products)
        {
            if (!Directory.Exists(FILES_DIRECTORY)) Directory.CreateDirectory(FILES_DIRECTORY);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Product>));
            FileStream stream = new FileStream(PRODUCT_FILE, FileMode.Create);
            serializer.WriteObject(stream, products);
            stream.Close();
        }

        
    }
}
