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
        private const string CUSTOMERFILE = "./customers.jsom";

        public List<Customer> LoadCustomerData() {


            return new List<Customer>();
        }

        public void SaveToFile(List<Customer> customers)
        {

            DataContractJsonSerializer serializator = new DataContractJsonSerializer(typeof(Customer));
            FileStream stream = new FileStream(CUSTOMERFILE, FileMode.Create);

            foreach(Customer customer in customers)
            {
                serializator.WriteObject(stream, customer);
            }

            stream.Close();

        }
    }
}
