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
        private const string FILESDIRECTORY = "./files";
        private const string CUSTOMERFILE = FILESDIRECTORY + "/customers.json";

      
        public void SaveToFile(List<Customer> customers)
        {
            if (!Directory.Exists(FILESDIRECTORY))
                Directory.CreateDirectory(FILESDIRECTORY);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Customer>));
            FileStream stream = new FileStream(CUSTOMERFILE, FileMode.Create);
            serializer.WriteObject(stream, customers);
            stream.Close();
        }

        public List<Customer> LoadFromFile() {
            List<Customer> customerList = null;
            if (File.Exists(CUSTOMERFILE))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Customer>));
                FileStream stream = new FileStream(CUSTOMERFILE, FileMode.Open);
                customerList = (List<Customer>) serializer.ReadObject(stream);
            }
            return customerList;
        }
    }
}
